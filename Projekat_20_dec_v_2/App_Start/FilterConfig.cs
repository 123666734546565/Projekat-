using System.Drawing.Drawing2D;
using System.Web;
using System.Web.Mvc;

namespace Projekat_20_dec_v_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
         //   filters.Add(new AuthorizeAttribute());
        }
    }
}
