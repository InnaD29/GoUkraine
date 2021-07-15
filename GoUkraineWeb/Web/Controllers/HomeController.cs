using Application.Managers;
using Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Web.Controllers.Base;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : BaseAjaxController
    {
        private readonly ILogger<HomeController> _logger;

        private readonly EmailManager _emailManager;
        private readonly TourManager _tourManager;
        public HomeController(EmailManager emailManager,
            TourManager tourManager,
            ILogger<HomeController> logger) : base(logger)
        {
            _emailManager = emailManager;
            _tourManager = tourManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tours()
        {
            return View();
        }
        public IActionResult HotTours()
        {
            return View();
        }
        public IActionResult BusTours()
        {
            return View();
        }
        public IActionResult ToursOfUkraine()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult TourDescription(int id)
        {
            return View(_tourManager.TourDescription(id));
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult EventsHome0()
        {
            return View();
        }
        public IActionResult EventsHome1()
        {
            return View();
        }
        public IActionResult EventsHome2()
        {
            return View();
        }
        public IActionResult EventsHome3()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AskToCall(ContactUsModel model)
        {
            return ExecPostAjax(() => { _emailManager.SendContactUsEmail(model); });
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
