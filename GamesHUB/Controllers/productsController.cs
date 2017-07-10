using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GamesHUB.Controllers
{
    public class productsController : Controller
    {
        // GET: products
        public ActionResult products()
        {
            ViewBag.pid = 1;
            return View();
        }
        public ActionResult details()
        {
            ViewBag.pid = 1;
            return View();
        }

        public ActionResult insertProduct()
        {
            return View();
        }

       [HttpPost]
        public ActionResult inserted(HttpPostedFileBase img1)
        {
          
            var context = new gamesHubDbEntities();
            
            var newProduct = new product()
            {
                p_name = Request["pname"],
                p_price = Convert.ToInt32(Request["price"]),
                c_id = Convert.ToInt32(Request["category"]),
                p_desc = Request["desc"],
                p_keywords = Request["keyw"],
                region = Convert.ToInt32(Request["region"])
               
            };
            if (img1 != null)
            {
                newProduct.p_img1 = new byte[img1.ContentLength];
                img1.InputStream.Read(newProduct.p_img1, 0, img1.ContentLength);
            }
            context.products.Add(newProduct);
            context.SaveChanges();
            return View();
        }
        public ActionResult searchProduct()
        {
            return View();
        }

    }
}