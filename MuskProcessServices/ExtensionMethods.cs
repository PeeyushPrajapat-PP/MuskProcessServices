using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    public static class ExtensionMethods
    {
        public static DataSet getDataSetFromDB(this String queryExpression)
        {
            DBConnection dbConnection = DBConnection.getInstanceOfDBConnection();
            DataSet dataset = dbConnection.getDataSet(queryExpression);
            return dataset;
        }
    }
}
