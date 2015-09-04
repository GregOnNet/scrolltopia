using System.Web.Mvc;
using Scrolltopia.Web.DemoRepositories;

namespace Scrolltopia.Web.Controllers
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

        public ViewResult Scrollbar()
        {
            return View();
        }

        public ViewResult TriggeringControls()
        {
            return View();
        }

        public ViewResult ScrollInAbsoultePositionedContainers()
        {
            return View();
        }

        public ViewResult CustomizingScrollbar()
        {
            return View();
        }

        public ViewResult Ie8CssOptimization()
        {
            return View();
        }
    }
}