using OnlineShop.Areas.Admin.Models;
using OnlineShop.Commom;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                bool res = new AccountAdmin().login(model.Username, model.Password);
                if (res)
                {
                    Session.Add(CommonConstants.ADMIN_SESSION, model.Username);
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Sác");

            }
            return View(model);
        }
        public ActionResult Logout()
        {
            Session[CommonConstants.ADMIN_SESSION] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}