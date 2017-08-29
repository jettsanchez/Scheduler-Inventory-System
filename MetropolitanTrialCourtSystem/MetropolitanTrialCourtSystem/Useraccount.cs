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
    public partial class Useraccount : Form
    {
        MySqlConnection connection;
        DBUtilities db = new DBUtilities();
        public string usertype = "";
        DataTable dt = new DataTable();

        public Useraccount()
        {
            InitializeComponent();
        }
        private void Useraccount_Load(object sender, EventArgs e)
        {
            GetConnection();
            pbCheck.Visible = false;
            pbWrong.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        public string GetConnection()
        {

            string d = "";
            {
                try
                {

                    string DbDec = ReadRegistryKey("MTCSystem", "password");
                    string constr = AES_Decrypt(DbDec, "password");
                    connection = new MySqlConnection();
                    connection.ConnectionString = DbDec;

                    connection.Open();

                }
                catch (Exception)
                {
                    MYSQLConnection mdi = new MYSQLConnection();
                    mdi.ShowDialog();
                }
            }
            return d;
        }
        public static string ReadRegistryKey(string key, string passkey)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
            regKey.CreateSubKey("DBsettings");
            regKey = regKey.OpenSubKey("DBsettings", true);
            return AES_Decrypt(regKey.GetValue(key).ToString(), passkey);
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
           // bool loggedIn = true;
            pbCheck.Visible = true;
            pbWrong.Visible = true;
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (Username == "" && Password == "")
            {
                pbCheck.ImageLocation = path + "\\wrong.png";
                pbWrong.ImageLocation = path + "\\wrong.png";
            }
            else
            {
                LoginSuccess();
            }
        }
        public void LoginSuccess()
        {
            string path1 = Application.StartupPath;
            DataTable dt1 = new DataTable();
            dt1 = db.SelectQuery("SELECT * FROM tblusers");
            string Username = "";
            string Password = "";
            if (dt1 != null)
            {
                if (dt1.Rows.Count != 0)
                {
                    foreach (DataRow r in dt1.Rows)
                    {
                        Username = r["Username"].ToString();
                        Password = r["Password"].ToString();

                        if (txtUsername.Text == Username && txtPassword.Text == Password)
                        {
                            FORM form = new FORM();
                            form.Show();
                            this.Hide();
                        }
                        else if (txtUsername.Text != Username && txtPassword.Text == Password)
                        {
                            pbCheck.ImageLocation = path1 + "\\wrong.png";
                            pbWrong.ImageLocation = path1 + "\\check.png";
                        }
                        else if (txtPassword.Text != Password && txtUsername.Text == Username)
                        {
                            pbWrong.ImageLocation = path1 + "\\wrong.png";
                            pbCheck.ImageLocation = path1 + "\\check.png";
                        }
                    }
                }
            }
        }

        private void chkShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow_Hide.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
