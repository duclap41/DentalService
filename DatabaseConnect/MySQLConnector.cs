using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace DentalService
{
    internal class MySQLConnector
    {
        static MySqlConnection conn = null;
        public static MySqlConnection GetConnection(string dbName)
        {
            if (conn == null )
            {
                string connString = $"Server=localhost;" +
                                    $"Database={dbName};" +
                                    $"User=root;" +
                                    $"Password=;" +
                                    $"Port=3306;";
                try { conn = new MySqlConnection(connString); } 
                catch (Exception ex) { MessageBox.Show("Không thể kết nối! Lỗi: " + ex.Message); }
            }
            
            return conn;
        }

        // Query compiler, make easy to query mySQL
        static QueryFactory database;
        public static QueryFactory Database(string dbName)
        {
            if (database == null)
            {
                var compiler = new MySqlCompiler();
                database = new QueryFactory(GetConnection(dbName), compiler);
            }

            return database;
        }

    }
}
