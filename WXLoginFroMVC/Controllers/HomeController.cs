﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WXLoginFroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                ViewBag.WXLoginUrl = UrlStr.WXLoginUrl();
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        ///回调页面
        /// </summary>
        /// <returns></returns>
        public ActionResult CallBackUrl(string code)
        {
            try
            {
                var url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=wx5da57aa47edf8eb8&secret=253cf3aa5bd73d13146c610e055a007d&code=" + code + "&grant_type=authorization_code";//获取access_token和openid请求链接
                string resp = WebToRequest.PushToWeb(url);
                CallBackModel cb = JSONHelper.DeserializeJsonToObject<CallBackModel>(resp);
                #region 数据操作
                //此处可进行数据相互相关代码
                #endregion
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}