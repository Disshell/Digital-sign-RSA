using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WolframAlphaNET;

namespace RSADSForm
{
    class RsaKeyGenerator
    {
        BigInteger _p, _q;
        BigInteger _n;
        BigInteger _fn;
        BigInteger _e;
        BigInteger _d;


        public RsaKeyGenerator()
        {
            try
            {
                this._p = BigInteger.Parse(GeneratePrimeNumber());
                this._q = BigInteger.Parse(GeneratePrimeNumber());
            }
            catch (Exception)
            {

                throw;
            }
            this._n = _p * _q;
            this._fn = (_p - 1) * (_q - 1);
            this._e = 65537;
            this._d = GenerateClosedExp(_e, _fn);
        }

        private BigInteger GenerateClosedExp(BigInteger a, BigInteger p)
        {
            BigInteger t = 0; BigInteger newt = 1;
            BigInteger r = p; BigInteger newr = a;
            while (newr != 0)
            {
                BigInteger q = r / newr;
                BigInteger temp;

                temp = t;
                t = newt;
                newt = temp - q * newt;

                temp = r;
                r = newr;
                newr = temp - q * newr;
            }
            if (t < 0)
                return t + p;
            return t;

        }

        public Key GetOpenKey()
        {
            return new Key { key = _e.ToString(), n = _n.ToString() };
        }

        public Key GetClosedKey()
        {
            return new Key { key = _d.ToString(), n = _n.ToString() };
        }

        private string GeneratePrimeNumber()
        {
            WolframAlpha wolfram = new WolframAlpha("H6JLXP-RJ7Y7RVPPE");
            try
            {
                var queryResult = wolfram.Query("nextPrime[2^1022 + RandomInteger(2^1023)]");
                if (queryResult == null)
                {
                    throw new Exception("Нет доступа в интернет");
                }

                if (queryResult.Error != null)
                {
                    throw new Exception(queryResult.Error.Message);
                }
                string result = queryResult?.Pods[1]?.SubPods[0]?.Plaintext;
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
