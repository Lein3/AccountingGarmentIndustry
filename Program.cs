using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AGI
{
    static public class GlobalUser
    {
        static public string name;
        static public string role;
    }
    static public class SelectedId
    {
        static public string id = null;
    }

    public class MyConnectionClass
    {
        static public SqlConnection MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AGI_DB"].ConnectionString);

        public void OpenConnection()
        {
            if (MyConnection.State == System.Data.ConnectionState.Closed)
                MyConnection.Open();
        }
        public void CloseConnection()
        {
            if (MyConnection.State == System.Data.ConnectionState.Open)
                MyConnection.Close();
        }
        public SqlConnection GetConnection()
        {
            return MyConnection;
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

    }
}
