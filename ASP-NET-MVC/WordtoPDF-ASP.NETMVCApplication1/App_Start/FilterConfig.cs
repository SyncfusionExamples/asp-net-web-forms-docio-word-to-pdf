using System.Web;
using System.Web.Mvc;

namespace WordtoPDF_ASP.NETMVCApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
