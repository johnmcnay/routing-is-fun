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

        //[Route("watch")]
        public IActionResult Watch()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;
            //ViewBag.Str = v;

            return View();
        }

//        /gp/buyagain? ie = UTF8 & ref_ = nav_cs_buy_again_42b0b0f447e84602b6bbf4316ba59d2e
        [Route("gp/{act}")]
        public IActionResult BuyAgain(string ie, string ref_, string act)
        {
            ViewBag.act = act;
            ViewBag.ie = ie;
            ViewBag.ref_ = ref_;

            return View();
        }

//        /HighKey-Snacks-Keto-Mini-Cookies/dp/B07JYS45BT? pd_rd_w = fTYaB & pf_rd_p = d93af0ec - 0925 - 424f - adfe - bd7170a550eb & pf_rd_r = DE7PJQ64V04PQW2T185E & pd_rd_r = e8cb0542 - 6743 - 4579 - 983d - cfdfd3169288 & pd_rd_wg = maOVU & pd_rd_i = B07JYS45BT & psc = 1 & ref_ = pd_bap_d_rp_4_i

        [Route("{product}/dp/{id}")]
        public IActionResult Snacks(string pd_rd_w, string pf_rd_p, string pf_rd_r, string pd_rd_r, string pd_rd_wg, string pd_rd_i, string psc, string ref_, string product, string id)
        {

            ViewBag.product = product;
            ViewBag.id = id;
            ViewBag.pd_rd_w = pd_rd_w;
            //this makes me sad
            ViewBag.pf_rd_p = pf_rd_p;
            ViewBag.pf_rd_r = pf_rd_r;
            ViewBag.pd_rd_r = pd_rd_r;
            ViewBag.pd_rg_wg = pd_rd_wg;
            ViewBag.pd_rd_i = pd_rd_i;
            ViewBag.psc = psc;
            ViewBag.ref_ = ref_;

            return View();
        }

        //  /2021/06/15/politics/ufo-report-briefing-pentagon-fighting
        [Route("{year}/{month}/{day}/politics/{slug}")]
        public IActionResult News(string year, string month, string day, string slug)
        {

            ViewBag.year = year;
            ViewBag.month = month;
            ViewBag.day = day;
            ViewBag.slug = slug;

            return View();
        }


        // /shows/big-sky/episode-guide/season-01/02-nowhere-to-run
        [Route("shows/{title}/episode-guide/{season}/{episode}")]
        public IActionResult Shows(string title, string season, string episode)
        {

            ViewBag.title = title;
            ViewBag.season = season;
            ViewBag.episode = episode;

            return View();
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
