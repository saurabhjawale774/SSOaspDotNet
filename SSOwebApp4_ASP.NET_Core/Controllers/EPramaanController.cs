using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSOwebApp4_ASP.NET_Core.Controllers
{
    public class EPramaanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
