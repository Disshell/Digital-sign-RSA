using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace RSADSForm
{
    public partial class Form1 : Form
    {
        //путь к файлу
        string filePath;
        //подпись файла
        string singPath;
        //открытый ключ для проверки
        string verifiablePathOpenKey;
        //путь файла для проверки подписи
        string verifiableFilePath;
        //путь к подписи для проверки 
        string verifiableSignPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void filePathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                fileNameTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void generateKeyButton_Click(object sender, EventArgs e)
        {
            string saveFilePath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            RsaKeyGenerator rsaGenerator;
            Key openKey = new Key();
            Key closeKey = new Key();
            try
            {

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Key));
                    rsaGenerator = new RsaKeyGenerator();
                    openKey = rsaGenerator.GetOpenKey();
                    closeKey = rsaGenerator.GetClosedKey();
                    saveFilePath = folderBrowserDialog1.SelectedPath;
                    using (FileStream fs = new FileStream(saveFilePath + "\\openKey.xml", FileMode.Create))
                    {
                        serializer.Serialize(fs, openKey);
                    }
                    using (FileStream fs = new FileStream(saveFilePath + "\\closedKey.xml", FileMode.Create))
                    {
                        serializer.Serialize(fs, closeKey);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {

            try
            {
                DS ds = new DS(filePath);
                XmlSerializer serializer = new XmlSerializer(typeof(Key));
                Key ClosedKey;
                DigitalSign currentSign = new DigitalSign();

                using (FileStream fs = new FileStream(singPath, FileMode.Open))
                {
                    ClosedKey = (Key)serializer.Deserialize(fs);
                }

                currentSign.Sing = ds.ToSign(ClosedKey);

                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(filePath + ".sign", FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, currentSign);
                }

                MessageBox.Show("Файл успешно подписан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void singPathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                singPath = openFileDialog1.FileName;
                SingPathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void checkFilePathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                verifiableFilePath = openFileDialog1.FileName;
                checkFileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void checkSignPathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                verifiableSignPath = openFileDialog1.FileName;
                checkSignTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void checkSignButton_Click(object sender, EventArgs e)
        {
            try
            {
                DS ds = new DS(verifiableFilePath);
                Key openKey = new Key();
                DigitalSign currentSign = new DigitalSign();
                BinaryFormatter bf = new BinaryFormatter();
                XmlSerializer serializer = new XmlSerializer(typeof(Key));
                using (FileStream fs = new FileStream(verifiableSignPath, FileMode.Open))
                {
                    currentSign = (DigitalSign)bf.Deserialize(fs);
                }

                using (FileStream fs = new FileStream(verifiablePathOpenKey, FileMode.Open))
                {
                    openKey = (Key)serializer.Deserialize(fs);
                }
                if (ds.CheckSing(currentSign, openKey))
                    MessageBox.Show("Подпись корректна", "Проверка подписи", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Подпись некорректна, возможно файл был изменен, поврежден или была попытка изменить файл", "Проверка подписи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openKeyPathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                verifiablePathOpenKey = openFileDialog1.FileName;
                OpenKeyTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void wolframLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.wolframalpha.com");
        }

        private void codedByLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Disshell");

        }
    }
}
