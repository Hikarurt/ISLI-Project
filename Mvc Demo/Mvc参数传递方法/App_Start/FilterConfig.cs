using System.Web;
using System.Web.Mvc;

namespace Mvc参数传递方法
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}