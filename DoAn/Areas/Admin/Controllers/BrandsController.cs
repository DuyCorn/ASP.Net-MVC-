﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn.Models;
using DoAn.Filters;

namespace DoAn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class BrandsController : Controller
    {
        // GET: Admin/Brands
        public ActionResult Index()
        {
            WebDBContext db = new WebDBContext();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}