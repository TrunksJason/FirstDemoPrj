using Microsoft.AspNetCore.Mvc;

namespace FirstDemoPrj.Web.Controllers
{
    public class HomeController : FirstDemoPrjControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}