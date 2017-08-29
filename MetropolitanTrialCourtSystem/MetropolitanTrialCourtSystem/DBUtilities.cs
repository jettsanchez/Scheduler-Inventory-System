using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace MetropolitanTrialCourtSystem
{
    class DBUtilities
    {
        private static MySqlCommand command;
        private MySqlConnection connection;
        private MySqlDataAdapter myAdapter;

        public string GetSettings()
        {

            string temp = string.Empty;

            try
            {

                string DbDec = ReadRegistryKey("MTCSystem", "password");
                string constr = AES_Decrypt(DbDec, "password");
                connection = new MySqlConnection();
                connection.ConnectionString = DbDec;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temp;
        }
        public MySqlDataReader ExecuteQuery(string query)
        {
            try
            {
                command = new MySqlCommand(query, OpenConnection());
                MySqlDataReader r = command.ExecuteReader();
                return r;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public string s()
        {

            string x = "";
            while (true)
            {
                try
                {

                    string DbDec = ReadRegistryKey("MTCSystem", "password");
                    string constr = AES_Decrypt(DbDec, "password");
                    connection = new MySqlConnection();
                    connection.ConnectionString = DbDec;

                    connection.Open();

                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
            return x;
        }
        public string AES_Encrypt(string clearText, string passkey)
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
        public string AES_Decrypt(string encryptedText, string passkey)
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
        public void CreateRegistryKey(string key, string value)
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
        public string ReadRegistryKey(string key, string passkey)
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
            regKey.CreateSubKey("DBsettings");
            regKey = regKey.OpenSubKey("DBsettings", true);
            return AES_Decrypt(regKey.GetValue(key).ToString(), passkey);
        }

        //bytes converter // to string again getbytes converttoint then to char then to string
        public string ConvertToBytes(string value)
        {
            string retval = "";
            try
            {
                byte[] arr = Encoding.ASCII.GetBytes(value);
                foreach (byte b in arr)
                {
                    retval += b.ToString();
                }
            }
            catch (Exception)
            {
                return value;
            }
            return retval;
        }
        public DBUtilities()
        {
            connection = new MySqlConnection();
            command = new MySqlCommand();
            myAdapter = new MySqlDataAdapter();
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        private MySqlConnection OpenConnection()
        {
            try
            {
                connection.ConnectionString = GetSettings();
                connection.Open();
                return connection;
            }
            catch (Exception)
            {
                return connection;
            }
        }
        public void InsertQuery(string query)
        {
            command.CommandText = query;
            try
            {
                command.Connection = OpenConnection();
                command.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public DataTable SelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                myAdapter = new MySqlDataAdapter(query, OpenConnection());
                myAdapter.Fill(dt);
                myAdapter.Dispose();
                CloseConnection();
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
