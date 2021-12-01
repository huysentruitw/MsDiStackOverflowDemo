using MsDiStackOverflowDemo.Services;
using System.Diagnostics;
using System.Web.Mvc;

namespace MsDiStackOverflowDemo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(Service1 service)
        {
            Debug.Assert(service != null);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}