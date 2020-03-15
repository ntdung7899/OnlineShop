using OnlineShop.Commom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            try
            {
                var session = Session[CommonConstants.ADMIN_SESSION];
                if (session.Equals(null))
                {
                    return RedirectToAction("Index", "Login");
                }
            } catch (Exception e)
            {
                return RedirectToAction("Index", "Login");
            }
               
                
            
            return View();          
        }
        
    }
}