using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up02.MyClass
{
    internal class DBConnection
    {
        static string connectionString = @"database = 'vd_up_z1';
                                    data source = 'localhost';
                                    user = 'root'; password = 'qwerty';
                                    charset = 'utf8mb4'";
        static MySqlConnection myConnect;
        static public MySqlCommand myCommand;
        static public MySqlDataAdapter myAdapter;
        static public MySqlDataReader myReader;
        static public DataTable dtMaterials = new DataTable();
        static public DataTable dtMaterialType = new DataTable();

        static public bool ConnectDB()
        {
            try
            {
                myConnect = new MySqlConnection(connectionString);
                myConnect.Open();
                myCommand = new MySqlCommand();
                myCommand.Connection = myConnect;
                myAdapter = new MySqlDataAdapter(myCommand);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool CloseDB()
        {
            try
            {
                myConnect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
