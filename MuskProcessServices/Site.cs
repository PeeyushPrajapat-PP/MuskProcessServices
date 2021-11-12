using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class MuskSite
    {
        
        private int siteId { get; set; }
        private string name { get; set; }
        public MuskSite(int siteId, string name)
        {
            this.siteId = siteId;
            this.name = name;
        }
        public MuskSite()
        {

        }
        public static List<MuskSite> getAllSites()
        {
            //select all sites from database 
            string queryExpression = String.Format("SELECT * FROM Sites");
            DataSet result = queryExpression.getDataSetFromDB();

            // User currentUser = FormatDataRowToObject(result.Tables[0].Rows[0]);

            //map data from the database to class site

            // Empty list of sites
            List<MuskSite> sites = new List<MuskSite>();

            foreach (DataRow row in result.Tables[0].Rows)
            {
                // map and add new site to list
                MuskSite site = new MuskSite();

                site.siteId = row.Field<int>("SiteID");
                site.name = row.Field<string>("Name");


                sites.Add(site);
            }

            
            return sites;
        }

        public int SiteId
        {
            get { return siteId; }
            set { siteId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
