using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices.Models
{
    class MuskSite
    {
        // Attributes
        private int _siteId { get; set; }
        private string _name { get; set; }
        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        // Constructor
        public MuskSite(int siteId, string name)
        {
            _siteId = siteId;
            _name = name;
        }

        // Methods
        public static DataSet getAllSites()
        {
            // Select all sites from database 
            string queryExpression = String.Format("SELECT * FROM Sites");
            DataSet result = queryExpression.getDataSetFromDB();

            return result;
        }

        public static MuskSite getSite(int siteId)
        {
            string queryExpression = String.Format("SELECT * FROM Sites WHERE SiteID='{0}'", siteId);
            DataRow result = queryExpression.getDataSetFromDB().Tables[0].Rows[0];

            MuskSite site = new MuskSite(
                result.Field<int>("SiteID"),
                result.Field<string>("Name")
                );

            return site;
        }

        public int SiteId
        {
            get { return _siteId; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}