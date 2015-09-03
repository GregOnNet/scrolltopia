using System.Web.Mvc;
using Scrolltopia.Web.DemoRepositories;

namespace Scrolltopia.Web.Controllers
{
    public class IscrollController : Controller
    {
        private readonly IscrollDemos _demos;

        public IscrollController()
        {
            _demos = new IscrollDemos();
        }

        public ActionResult Index()
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

        public ViewResult FadingScrollbar()
        {
            return View();
        }

        public ViewResult InteractiveScrollbar()
        {
            return View();
        }

        public ActionResult ShrinkedScrollbar()
        {
            return View();
        }

        public ActionResult ClickableElements()
        {
            return View();
        }



        public ActionResult ResizingContainer()
        {
            return View();
        }

        public ActionResult ResizingScrollingContent()
        {
            return View();
        }

        public ActionResult Deceleration()
        {
            return View();
        }

        public ActionResult TriggeringControls()
        {
            return View();
        }

        public ActionResult AnimatedScrollingContent()
        {
            return View();
        }

        public ActionResult HandleScrollEvents()
        {
            return View();
        }
    }
}