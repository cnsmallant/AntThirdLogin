using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace QQLoginForMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                ViewBag.QQLoginUrl = UrlStr.QQLoginUrl();
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 回调页面
        /// </summary>
        /// <returns></returns>
        public ActionResult CallBackUrl()
        {
            try
            {
               
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}