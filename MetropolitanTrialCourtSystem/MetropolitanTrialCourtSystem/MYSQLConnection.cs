using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace MetropolitanTrialCourtSystem
{
    public partial class MYSQLConnection : Form
    {
        MySqlConnection connection;

        public MYSQLConnection()
        {
            InitializeComponent();
        }
        public static string AES_Encrypt(string clearText, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string encryptedString = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(clearText);
                encryptedString = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception)
            {
                return "";
            }
            return encryptedString;
        }
        public static string AES_Decrypt(string encryptedText, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string decryptedString = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESDecrypter = AES.CreateDecryptor();
                byte[] buffer = Convert.FromBase64String(encryptedText);
                decryptedString = ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception)
            {
                return "";
            }
            return decryptedString;
        }
        public static void CreateRegistryKey(string key, string value)
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
                regKey.CreateSubKey("DBsettings");
                regKey = regKey.OpenSubKey("DBsettings", true);
                regKey.SetValue(key, value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string ReadRegistryKey(string key, string passkey)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
            regKey.CreateSubKey("DBsettings ");
            regKey = regKey.OpenSubKey("DBsettings", true);
            return AES_Decrypt(regKey.GetValue(key).ToString(), passkey);
        }

        private void btnTest_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtDatabase.Text != "" && txtPort.Text != "" && txtServer.Text != "" && txtUsernameID.Text != "")
                {
                    string constr = "SERVER=" + txtServer.Text + ";" +
                                         "PORT=" + txtPort.Text + ";" +
                                         "DATABASE=" + txtDatabase.Text + ";" +
                                         "UID=" + txtUsernameID.Text + ";" +
                                         "PASSWORD=" + txtPassword.Text + ";";
                    string DBenc = AES_Encrypt(constr, "password");

                    CreateRegistryKey("MTCSystem", DBenc);
                    string connString = AES_Decrypt(DBenc, "password");
                    connection = new MySqlConnection();
                    connection.ConnectionString = connString;

                    connection.Open();
                    try
                    {
                        MessageBox.Show("Valid Connection.");
                    }
                    catch (Exception et)
                    {
                        MessageBox.Show(et.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all requirements");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApply_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtDatabase.Text != "" && txtPort.Text != "" && txtServer.Text != "" && txtUsernameID.Text != "")
                {
                    string constr = "SERVER=" + txtServer.Text + ";" +
                                         "PORT=" + txtPort.Text + ";" +
                                         "DATABASE=" + txtDatabase.Text + ";" +
                                         "UID=" + txtUsernameID.Text + ";" +
                                         "PASSWORD=" + txtPassword.Text + ";";
                    string DBenc = AES_Encrypt(constr, "password");

                    CreateRegistryKey("MTCSystem", DBenc);
                    string connString = AES_Decrypt(DBenc, "password");
                    connection = new MySqlConnection();
                    connection.ConnectionString = connString;

                    connection.Open();
                    try
                    {
                        this.Close();
                    }
                    catch (Exception et)
                    {
                        MessageBox.Show(et.Message);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all requirements");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnTest_MouseHover(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.LightSteelBlue;
        }

        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            btnTest.BackColor = Color.Empty;
        }

        private void btnApply_MouseHover(object sender, EventArgs e)
        {
            btnApply.BackColor = Color.DarkSeaGreen;
        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            btnApply.BackColor = Color.Empty;
        }

    }
}