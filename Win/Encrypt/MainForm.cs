using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encrypt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private byte[] md5(String text)
        {
            return MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(text));
        }

        private ICryptoTransform create(RijndaelManaged cipher, String password, bool enc)
        {
            byte[] key = md5(password);
            byte[] iv = new byte[16];
            System.Array.Copy(key, iv, 16);
            cipher.Key = key;
            cipher.IV = iv;
            cipher.Mode = CipherMode.CBC;
            cipher.Padding = PaddingMode.PKCS7;
            if (enc)
            {
                return cipher.CreateEncryptor();
            }
            else
            {
                return cipher.CreateDecryptor();
            }
        }

        private bool checkInput()
        {
            if (srcTextBox.Text.Length == 0)
            {
                MessageBox.Show("源内容为空");
                return false;
            }
            if (passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            return true;
        }

        private void encButton_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            
            using (RijndaelManaged cipher = new RijndaelManaged())
            using (ICryptoTransform transform = create(cipher, passwordTextBox.Text, true))
            {
                byte[] srcBytes = Encoding.UTF8.GetBytes(srcTextBox.Text);
                byte[] dstBytes = transform.TransformFinalBlock(srcBytes, 0, srcBytes.Length);
                dstTextBox.Text = Convert.ToBase64String(dstBytes);
            }
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }

            using (RijndaelManaged cipher = new RijndaelManaged())
            using (ICryptoTransform transform = create(cipher, passwordTextBox.Text, false))
            {
                byte[] srcBytes = Convert.FromBase64String(srcTextBox.Text);
                byte[] dstBytes = transform.TransformFinalBlock(srcBytes, 0, srcBytes.Length);
                dstTextBox.Text = Encoding.UTF8.GetString(dstBytes);
            }
        }
    }
}
