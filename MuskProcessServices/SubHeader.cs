using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class SubHeader
    {
        public int subHeaderId { get; set; }
        public string subTitle { get; set; }

        public SubHeader(int subHeaderId, string subTitle) 
        {
            this.subHeaderId = subHeaderId;
            this.subTitle = subTitle;
        }

        public SubHeader() 
        {
        
        }

        public static List<SubHeader> getAllSubHeaders() 
        {

            string queryExpression = String.Format("SELECT * FROM SubHeader");

            List<SubHeader> subHeaders = new List<SubHeader>();

            foreach (DataRow row in result.Table[0].Rows) 
            {
                SubHeader subHeader = new SubHeader();

                subHeader.subHeaderId = row.Field<int>("SubHeaderID");
                subHeader.subTitle = row.Field<string>("SubTitle");

                return subHeaders;
            

            }
        }

        public int SubHeaderId
        {
            get { return SubHeaderId; }
            set { SubHeaderId = value; }
        }

        public string SubTitle
        {
            get { return subTitle; }
            set { subTitle = value; }
        }



    }


}
