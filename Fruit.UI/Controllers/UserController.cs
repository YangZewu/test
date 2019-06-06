using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fruit.BLL;
using Fruit.Model;
namespace Fruit.UI.Controllers
{
    public class UserController : Controller
    {
        private UserServsr user = new UserServsr();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        //注册页
        public ActionResult Reg()
        {
            return View();
        }
        //登录页
        public ActionResult Login()
        {
            return View();
        }
        //注册方法
        public JsonResult Add(userTable u)
        {
            u.userRegTime = System.DateTime.Now.ToString();
            u.userType = "消费者";
            if (user.Add(u))
            {
                return Json(new { msg = "添加成功", success = true });
            }
            else
            {
                return Json(new { msg = "添加失败", success = false });
            }
        }
        //登录方法
        public JsonResult GetUser(userTable u)
        {
            if (user.GetList(a => a.userName == u.userName && a.userPwd == u.userPwd).Count >= 1)
            {
                return Json(new { msg = "登录成功", success = true });
            }
            else
            {
                return Json(new { msg = "登录失败", success = false });
            }
        }
        //找回方法
        public JsonResult Edit(userTable u)
        {
            if (user.Updata(u))
            {
                return Json(new { msg = "找回成功", success = true });
            }
            else
            {
                return Json(new { msg = "找回失败", success = false });
            }
        }
    }
}