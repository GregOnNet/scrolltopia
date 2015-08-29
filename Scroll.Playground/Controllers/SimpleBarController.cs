using System.Web.Mvc;
using Scroll.Playground.DemoRepositories;

namespace Scroll.Playground.Controllers
{
    public class SimplebarController : Controller
    {
        private readonly SimplebarDemos _demos;

        public SimplebarController()
        {
            _demos = new SimplebarDemos();
        }

        public ViewResult Index()
        {
            return View(_demos.GetAll());
        }

        public ViewResult MinimalSetup()
        {
            return View();
        }

        public ActionResult Scrollbar()
        {
            return View();
        }
    }
}