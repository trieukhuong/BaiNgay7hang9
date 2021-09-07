﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiNgay7hang9.Controllers
{
    public class DemoController : Controller
    {
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
            double ketqua = -sob / soa;
            ViewBag.Giaipt = ketqua;

            return View();

        }
    }
}