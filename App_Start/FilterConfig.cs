using System.Web;
using System.Web.Mvc;

namespace MVR_Casa_Pronta
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
