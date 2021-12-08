using System;
using System.Collections.Generic;
using System.Data;

namespace MuskProcessServices
{
    class SubHeader
    {
        // Attributes

        private int _subHeaderID { get;}
        private string _subTitle { get;}
        private int _headerID { get;}
        private DateTime? _updatedAt { get;}
        private DateTime? _createdAt { get;}

        // Constructor
        public SubHeader(int subHeaderId, string subTitle, int headerId)
        {
            //item from database
            _subHeaderID = subHeaderId;
            _subTitle = subTitle;
            _headerID = headerId;
        }

        // Methods
        public static DataSet getAllSubHeaders()
        {
            // Query - Select all subHeaders from database 
            string queryExpression = String.Format("SELECT * FROM SubHeaders");
            //Using query method from SharedMethod.cs
            DataSet result = queryExpression.getDataSetFromDB();

            // Empty subHeaders in a new list
            List<SubHeader> subHeaders = new List<SubHeader>();

            //Obtaining data from DB table SubHeaders and Headers
            foreach (DataRow row in result.Tables[0].Rows)
            {
                subHeaders.Add(new SubHeader(row.Field<int>("SubHeaderID"), row.Field<string>("SubTitle"), row.Field<int>("HeaderID")));
            }

            return result;

        }

        public static List<SubHeader> getSubHeaders()
        {

            string queryExpression = String.Format("SELECT * FROM SubHeaders");
            DataTable result = queryExpression.getDataSetFromDB().Tables[0];
            List<SubHeader> subHeaders = new List<SubHeader>();

            foreach (DataRow row in result.Rows)
            {
                SubHeader subHeader = new SubHeader(
                    row.Field<int>("SubHeaderID"),
                    row.Field<string>("SubTitle"),
                    row.Field<int>("HeaderID")
                    );

                subHeaders.Add(subHeader);
            }

            return subHeaders;
        }

        public int SubHeaderId
        {
            get { return _subHeaderID; }
        }

        public string SubTitle
        {
            get { return _subTitle; }
        }
        public int HeaderId
        {
            get { return _headerID; }
        }

    }
}
