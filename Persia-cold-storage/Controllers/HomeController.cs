using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Persia_cold_storage.Models;

namespace Persia_cold_storage.Controllers
{
    public class HomeController : Controller
    {
        private Persia db = new Persia();

        // GET: /Home/
        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        public ActionResult administrator()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
