using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices.Models
{
    class Intervention
    {
        private int _interventionId { get; set; }
        private int _siteInspectionId { get; set; }
        private int _subHeaderId { get; set; }
        private int _count { get; set; }
        private string _comment { get; set; }
        private bool _completed { get; set; }
        private string _actionTaken { get; set; }

        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        public Intervention() { }

        public Intervention(int siteInspectionId, int subHeaderId, int count, string comment, bool completed, string actionTaken)
        {
            _siteInspectionId = siteInspectionId;
            _subHeaderId = subHeaderId;
            _count = count;
            _comment = comment;
            _completed = completed;
            _actionTaken = actionTaken;
        }

        public static List<Intervention> getInterventions(int siteInspectionId)
        {
            string queryExpression = String.Format("SELECT * FROM Interventions WHERE SiteInspectionID='{0}'", siteInspectionId);
            DataTable result = queryExpression.getDataSetFromDB().Tables[0];
            List<Intervention> interventions = new List<Intervention>();

            foreach (DataRow row in result.Rows)
            {
                Intervention intervention = new Intervention(
                    row.Field<int>("SiteInspectionID"),
                    row.Field<int>("SubHeaderID"),
                    row.Field<int>("Count"),
                    row.Field<string>("Comment"),
                    Convert.ToBoolean(row.Field<int>("Completed")),
                    row.Field<string>("ActionTaken")
                    );

                interventions.Add(intervention);
            }

            return interventions;
        }

        public static void SaveToDB(string sqlQuery, Intervention item, int siteInspectionId)
        {
            using (SqlConnection connToDB = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                // Open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("SiteInspectionID", siteInspectionId));
                sqlCommand.Parameters.Add(new SqlParameter("SubHeaderID", item.SubHeaderID));
                sqlCommand.Parameters.Add(new SqlParameter("Count", item.Count));
                sqlCommand.Parameters.Add(new SqlParameter("Comment", item.Comment));
                sqlCommand.Parameters.Add(new SqlParameter("Completed", item.Completed));
                sqlCommand.Parameters.Add(new SqlParameter("ActionTaken", item.ActionTaken));

                // execute the command
                sqlCommand.ExecuteNonQuery();
            }
        }

        public int InterventionID
        {
            get { return _interventionId; }
            set { _interventionId = value; }
        }
        public int SiteInspectionID
        {
            get { return _siteInspectionId; }
            set { _siteInspectionId = value; }
        }
        public int SubHeaderID
        {
            get { return _subHeaderId; }
            set { _subHeaderId = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        public string ActionTaken
        {
            get { return _actionTaken; }
            set { _actionTaken = value; }
        }

    }
}
