using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSOwebApp4_ASP.NET_Core.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            if (email == "jawale@gmail.com")
            {

                return RedirectToAction("index", "EPramaan");

            }
            return View();

        }
    }
}
