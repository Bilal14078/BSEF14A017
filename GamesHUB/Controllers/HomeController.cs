using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesHUB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["Login"]==null)
            {
                ViewBag.email = "";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
        public ActionResult sendfeedback()
        {
            var context = new gamesHubDbEntities();

            var newFeedback = new feedback()
            {
                f_name= Request["fn"],
                l_name = Request["ln"],
                email= Request["email"],
                comment = Request["txt"]
            };          
            context.feedbacks.Add(newFeedback);
            context.SaveChanges();
            return View();
        }
        public ActionResult signIn()
        {
            
            return View();
        }
        public ActionResult signIn1()
        {
            String userId = Request["user"];
            String pass = Request["pwd"];
            var context = new gamesHubDbEntities();
            var userList = context.accounts.ToList();
            foreach(var user in userList )
            {
                if(user.email==userId && user.password==pass && userId != "admin@gmail.com")
                {
                    Session["Login"] = userId;
                    ViewBag.email = userId;
                    return Redirect("~/Home/Index ");

                  //  return Redirect("/Home/Index");

                    ViewBag.Msg = "Login success";
                }
                else if(user.email == userId && user.password == pass && userId=="admin@gmail.com")
                {
                    return Redirect("/products/insertProduct");

                }
                else
                {
                    
                }
            }
           

            return View();
        }
        public ActionResult signUp()
        {

            return View();
        }
        public ActionResult signUp1()
        {
           
            var context = new gamesHubDbEntities();

            var newAccount = new account()
            {
                email=Request["user"],
                password=Request["pwd"]
            };
            context.accounts.Add(newAccount);
            context.SaveChanges();
            return View();
        }
    }
}