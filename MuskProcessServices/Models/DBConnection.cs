using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MuskProcessServices
{
    public class DBConnection
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
        public static void SaveSiteInspectionToDB(string sqlQuery, SiteInspection item)
        {
            using (SqlConnection connToDB = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                // Open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("SiteID", item.SiteId));
                sqlCommand.Parameters.Add(new SqlParameter("CompletedBy", item.CompletedBy));
                sqlCommand.Parameters.Add(new SqlParameter("Supervisor", item.Supervisor));
                sqlCommand.Parameters.Add(new SqlParameter("Inspector", item.Inspector));
                sqlCommand.Parameters.Add(new SqlParameter("WorkArea", item.WorkArea));
                sqlCommand.Parameters.Add(new SqlParameter("JobDescription", item.JobDescription));
                sqlCommand.Parameters.Add(new SqlParameter("Type", item.Type));
                sqlCommand.Parameters.Add(new SqlParameter("Status", item.Status));

                MessageBox.Show(item.SiteId.ToString());

                // execute the command
                sqlCommand.ExecuteNonQuery();
            }
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
