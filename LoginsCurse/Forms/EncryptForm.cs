using LoginsCurse.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginsCurse.Forms
{
    public partial class EncryptForm : Form
    {
        private bool isEncrypted;
        private string password;
        public EncryptForm(bool _isEncrypted, string _password)
        {
            InitializeComponent();
            isEncrypted = _isEncrypted;
            password = _password;
            if (isEncrypted)
            {
                this.Text = "Decrypt";
            }
            else
            {
                this.Text = "Encrypt";
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (isEncrypted && textBox.Text != "")
            {
                Helper.EncryptedValue = Decrypt(password, textBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(textBox.Text != "")
            {
                Helper.EncryptedValue = Encrypt(password, textBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        public static string Encrypt(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes("SaltValue"), 10000))
                {
                    aes.Key = keyDerivationFunction.GetBytes(32);
                    aes.IV = keyDerivationFunction.GetBytes(16);
                }

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var writer = new StreamWriter(cs))
                    {
                        writer.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                using (var keyDerivationFunction = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes("SaltValue"), 10000))
                {
                    aes.Key = keyDerivationFunction.GetBytes(32);
                    aes.IV = keyDerivationFunction.GetBytes(16);
                }

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
