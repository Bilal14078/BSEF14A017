using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GamesHUB.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Order()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult orderConfirm()
        {
            var context = new gamesHubDbEntities();

            var newOrder = new order()
            {
                u_name = Request["fn"],
                o_date = DateTime.Now,
                p_id = Convert.ToInt32(Request["pid"]),
                u_email = Request["email"],
                u_phone = Request["ph"],
                u_address = Request.Form["txt"],
                o_payment = Convert.ToInt32(Request["payment"]),
                o_paymentStatus = "unpaid",
                o_deliveryStatus = "undelivered",
                p_quantity = Convert.ToInt32(Request["pq"]),
           


            };
            
            context.orders.Add(newOrder);         
            context.SaveChanges();
        
            return View();
        }
        public ActionResult viewOrders()
        {
            return View();
        }
        public ActionResult showOrders()
        {
            return View();
        }

    }
}