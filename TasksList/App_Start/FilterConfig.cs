using System.Web;
using System.Web.Mvc;

namespace TasksList
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // Make the Every Controllers Authorized
            filters.Add(new AuthorizeAttribute());
        }
    }
}
