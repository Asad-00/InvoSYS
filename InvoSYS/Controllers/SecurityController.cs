using InvoSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace InvoSYS.Controllers
{
    public class SecurityController : Controller
    {
        Inventory_managementEntities db = new Inventory_managementEntities();

        // GET: Security


        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Logout()
        {
            
            return RedirectToAction("Login");
        }

    }
}
