using System;
using System.Data;

namespace MuskProcessServices
{
    // Shared methods to use across the application.
    public static class SharedMethods
    {
        public static User _currentUser { get; set; }

        /**
         * Access data related to the currently logged in user. 
         */
        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        /**
         * Combobox item to format dropdown list
         */
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        /**
         * A shared metod to use whenever getting data from the Database using SQL string.
         */
        public static DataSet getDataSetFromDB(this String queryExpression)
        {
            DBConnection dbConnection = DBConnection.getInstanceOfDBConnection();
            DataSet dataset = dbConnection.getDataSet(queryExpression);
            return dataset;
        }
    }
}
