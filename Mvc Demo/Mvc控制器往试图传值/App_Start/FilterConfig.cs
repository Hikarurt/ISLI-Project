using System.Web;
using System.Web.Mvc;

namespace Mvc控制器往试图传值
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}