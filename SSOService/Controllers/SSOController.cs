using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.Mvc;

namespace SSOService.Controllers
{
    [Authorize]
    public class SSOController : Controller
    {
        // GET: SSO
        public ActionResult Index()
        {
            Console.WriteLine("In SSO Index");
            return View();
        }


    
        public ActionResult EPramaanAuth( )
        {
            //Service services = new Service();
            /*
                        services.AddAuthentication()
                // other registrations
                .AddOpenIdConnect("oidc", options => {
                    options.Authority = "http://localhost:5000";
                    options.RequireHttpsMetadata = false; // dev only

                    options.ClientId = "pkce_client";
                    options.ClientSecret = "acf2ec6fb01a4b698ba240c2b10a0243";
                    options.ResponseType = "code";
                    options.ResponseMode = "form_post";
                    options.CallbackPath = "/signin-oidc";
                });*/
            ViewBag.msg = "Hello Epramaan";

            return View();
        }
    }
}