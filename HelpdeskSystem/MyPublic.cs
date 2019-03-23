using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpdeskSystem
{
    class MyPublic
    {
        public static SqlConnection conn;
        private static string serverName = "DESKTOP-KAGK96M\\SQLEXPRESS";
        private static string dbName = "HelpdeskSystem";
        private static string userId = "sa";
        private static string pass = "1234";
        public static string PURVIEW, USERNAME;

        public static void ConnectDatabase()
        {
            string connect = "Data Source="+ serverName + ";Initial Catalog="+ dbName +";User ID="+userId+";Password="+pass;
            conn = new SqlConnection(connect);
            try
            {
                conn.Open();
            }
            catch
            {
                throw;
            }

        }
        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName, SqlDataAdapter daDataAdapter)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conn);
                SqlCommandBuilder cmbCommandBuilder = new SqlCommandBuilder(daDataAdapter);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conn.Close();
            }
            catch (Exception)
            {
            }

        }
        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName)
        {
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conn);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conn.Close();

            }
            catch (Exception)
            {
            }
        }

    }
}
