using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiNgay7hang9.Models;

namespace BaiNgay7hang9.Controllers
{
    public class DemoController : Controller
    {
        kethua gtp = new kethua();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GPT(string soX, string soY)
        {
            double soa = Convert.ToDouble(soX);
            double sob = Convert.ToDouble(soY);
            double z = gtp.GiaiPhuongtrinh(soa, sob);
            ViewBag.Giatriz = z;

            return View();

        }
    }
}