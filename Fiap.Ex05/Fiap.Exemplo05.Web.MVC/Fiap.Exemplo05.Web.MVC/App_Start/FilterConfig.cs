using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo05.Web.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
