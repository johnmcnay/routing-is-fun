using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingIsFun.Models;

namespace RoutingIsFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("watch")]
        public IActionResult Watch()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;
            //ViewBag.Str = v;

            return View("Routing");
        }

       [Route("gp/{act}")]
        public IActionResult BuyAgain()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("{product}/dp/{id}")]
        public IActionResult Snacks()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("{year}/{month}/{day}/politics/{slug}")]
        public IActionResult News()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("shows/{title}/episode-guide/{season}/{episode}")]
        public IActionResult Shows()
        {

            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("shows/{title}/video/{id}/{episode}")]
        public IActionResult ShowVideo()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("{language}/powerapps/{section}/{topic}")]
        public IActionResult PowerApps()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("main")]
        public IActionResult Main()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("manage/environments/{id1}/flows/{id2}/details")]
        public IActionResult Manage()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("environments/environment/{id}/hub")]
        public IActionResult Environment()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        [Route("{lang}/pdp")]
        public IActionResult Pdp()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }

        // /2021/06/15/uberall-raises-115m-acquires-momentfeed-to-scale-up-its-location-marketing-services/
        [Route("{year}/{month}/{day}/{topic}")]
        public IActionResult Article()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("Routing");
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
