using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class DBConnection
    {
        private static DBConnection _instance;

        // The connection string that is set in settings for this project
        private string connectionString;

        private DBConnection()
        {
            connectionString = Properties.Settings.Default.DBConnectionString;
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null) _instance = new DBConnection();
            return _instance;
        }

        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            using (SqlConnection connToDB = new SqlConnection(connectionString))
            {
                connToDB.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                adapter.Fill(dataSet);
            }

            return dataSet;
        }
    }
}
