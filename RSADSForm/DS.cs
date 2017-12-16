using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;
using System.Xml.Serialization;

namespace RSADSForm
{
    class DS
    {
        //сохранение пути к файлу, который необходимо подписать
        string filePath;
        //хеш данного файла
        string hash;
        //открытый ключ используемый для проверки подписи файла
        Key openKey;
        //открытый ключ используемый для подписи файла
        Key closedKey;

        //конструктор, принимает путь к файлу
        public DS(string filePath)
        {
            //устанавливаем путь к файлу  
            this.filePath = filePath;
            //получаем хеш файла(вызов функции GetHash)
            this.hash = GetHash(filePath);
        }

        public static string GetHash(string filePath)
        {
            //Для получения хеша используем стандартный класс от Microsoft
            MD5 md5 = new MD5CryptoServiceProvider();
            //объявляем массив типа Byte для записи в него хеша
            byte[] hash;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))//создаем поток FileStream
            {
                //получаем хеш файла по потоку
                hash = md5.ComputeHash(fs);

            }
            string result = "";
            //переводим хеш в двоичное число и записываем его в строку
            foreach (var item in hash)
            {
                result += item.ToString("x2");
            }
            return result;
        }

        //функция для подписи файла 
        public string ToSign(Key closedKey)
        {
            //устанавливаем закрытый ключ 
            this.closedKey = closedKey; //
            //переводим хеш в 10x число
            var currentHash = BigInteger.Parse(this.hash, System.Globalization.NumberStyles.AllowHexSpecifier);
            //высчитываем цифровую подпись
            BigInteger sign = BigInteger.ModPow(currentHash, BigInteger.Parse(closedKey.key), BigInteger.Parse(closedKey.n));
            return sign.ToString();
        }

        public bool CheckSing(DigitalSign sign, Key openKey)
        {
            //устанавливаем открытый ключ
            this.openKey = openKey;
            //получаем хеш файла
            string fileHesh_x16 = GetHash(filePath);
            //переводим хеш в 10x число
            var currentHash_x10 = BigInteger.Parse(fileHesh_x16, System.Globalization.NumberStyles.AllowHexSpecifier);
            // устанавливаем подпись
            var currentSign_x10 = BigInteger.Parse(sign.Sing);
            //высчитываем хеш из подписи
            BigInteger sign_x10 = BigInteger.ModPow(currentSign_x10, BigInteger.Parse(openKey.key), BigInteger.Parse(openKey.n));
            // если хеши совпадают возвращаем true, иначе false
            if (currentHash_x10 == sign_x10)
            {
                return true;
            }
            else
                return false;

        }
    }
}