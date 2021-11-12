using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class Site
    {
        
        private int siteId { get; set; }
        private string name { get; set; }
        public Site(int siteId, string name)
        {
            this.siteId = siteId;
            this.name = name;
        }
        public Site()
        {

        }
        public List<Site> getAllSites()
        {
            //select all sites from database 
            string queryExpression = String.Format("SELECT * FROM Sites");
            DataSet result = queryExpression.getDataSetFromDB();

            // User currentUser = FormatDataRowToObject(result.Tables[0].Rows[0]);

            //map data from the database to class site

            // Empty list of sites
            List<Site> sites = new List<Site>();

            foreach (DataRow row in result.Tables[0].Rows)
            {
                // map and add new site to list
                Site site = new Site();

                site.siteId = row.Field<int>("SiteID");
                site.name = row.Field<string>("Name");


                sites.Add(site);
            }

            
            return sites;
        }



    }
}
