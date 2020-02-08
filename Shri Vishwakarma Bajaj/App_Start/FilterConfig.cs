using System.Web;
using System.Web.Mvc;

namespace Shri_Vishwakarma_Bajaj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
