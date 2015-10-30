using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CQCMXY.WeiXin.MP.Entities;
namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public string Index()
        {

            BaiduORC bdorc = new BaiduORC();
           var res= bdorc.ExResult();
            return res;
        }
    }
}