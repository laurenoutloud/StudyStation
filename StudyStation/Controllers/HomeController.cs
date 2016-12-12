using System.Web.Mvc;
using StudyStation.Models; //Include models to organize generated data

namespace StudyStation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(); //Open home view
        }
    }
}