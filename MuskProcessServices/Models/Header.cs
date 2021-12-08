using System;
using System.Data;
using System.Collections.Generic;

namespace MuskProcessServices
{
    public class Header
    {
        // Attributes
        private int _headerId { get;}
        private string _title { get;}
        private DateTime? _updatedAt { get;}
        private DateTime? _createdAt { get;}

        // Constructor
        public Header(int headerId, string title)
        {
            _headerId = headerId;
            _title = title;
        }

        // Methods
        public static List<Header> getHeaders()
        {

            //Query - Get data from DB table Header and add header selection to new list Header
        
            string queryExpression = String.Format("SELECT * FROM Headers");
            //Using query method from SharedMethod.cs
            DataTable result = queryExpression.getDataSetFromDB().Tables[0];
            List<Header> headers = new List<Header>();


            foreach (DataRow row in result.Rows)
            {
                Header header = new Header(
                    row.Field<int>("HeaderID"),
                    row.Field<string>("Title")
                    );

                headers.Add(header);
            }

            return headers;
        }

        public int HeaderId
        {
            get { return _headerId; }
        }

        public string Title
        {
            get { return _title; }
        }
    }

}