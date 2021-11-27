using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class SubHeader
    {
        private int _subHeaderID { get; set; }
        private string _subTitle { get; set; }

        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        // Constructor
        public SubHeader(int subHeaderId, string subTitle)
        {
            _subHeaderID = subHeaderId;
            _subTitle = subTitle;
        }

        // Methods
        public static DataSet getAllSubHeaders()
        {
            // Select all subHeaders from database 
            string queryExpression = String.Format("SELECT * FROM SubHeaders");
            DataSet result = queryExpression.getDataSetFromDB();

            // Empty list of subHeaders
            List<SubHeader> subHeaders = new List<SubHeader>();

            foreach (DataRow row in result.Tables[0].Rows)
            {
                subHeaders.Add(new SubHeader(row.Field<int>("SubHeaderID"), row.Field<string>("SubTitle")));
            }

            return result;

        }

        public int SubHeaderId
        {
            get { return _subHeaderID; }
        }

        public string SubTitle
        {
            get { return _subTitle; }
        }

    }
}
