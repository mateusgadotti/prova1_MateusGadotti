using System.Web;
using System.Web.Mvc;

namespace Prova1_MateusGadotti
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
