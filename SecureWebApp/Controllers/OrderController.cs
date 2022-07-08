using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecureWebApp.Models;
namespace SecureWebApp.Controllers
{

    // Filters : Authentication Filter
    [Authorize]
    public class OrderController : Controller
    {
       
        List <Order> GetOrder()
        {
            List<Order> orders = new List<Order>();
            orders.Add(new Order { ProductID = 11, Product = "gerbera", Price = 23, Quantity = 4 ,OrderDate=new DateTime(2022,01,25),Status="Delivered"});
            orders.Add(new Order { ProductID = 12, Product = "Rose", Price = 34, Quantity = 3, OrderDate = new DateTime(2022, 01, 15), Status = "Canceled" });
            orders.Add(new Order { ProductID = 13, Product = "Lotus", Price = 53, Quantity = 5, OrderDate = new DateTime(2022, 01, 10), Status = "pending" });
            orders.Add(new Order { ProductID = 14, Product = "Jasmine", Price = 75, Quantity = 2, OrderDate = new DateTime(2022, 01, 13), Status = "pending" });
            orders.Add(new Order { ProductID = 15, Product = "Orchid", Price = 10, Quantity = 8, OrderDate = new DateTime(2022, 01, 25), Status = "Delivered" });

            return orders;



        }

        // GET: Order
        public ActionResult Index()
        {
            List<Order> orders = GetOrder();
            ViewData["orders"] = orders;
            return View();
        }
        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}