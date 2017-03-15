using System.Web;
using System.Web.Mvc;

namespace HotelWebservice1_LocalDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
