namespace MuskProcessServices
{
    internal class MuskSiteBase
    {

        public static List<MuskSite> AddSite()
        {
            string queryExpression = String.Format("INSERT sites INTO Sites");
            DataSet result = queryExpression.getDataSetFromDB();

            List<MuskSite> sites = new List<MuskSite>();

        }
    }
}