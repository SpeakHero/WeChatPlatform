using CQCMXY.WeiXin.Data.Entity;
using CQCMXY.WeiXin.MP.CommonAPIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class BasesController : Controller
    {
        // GET: GetToken
        public JsonResult GetToken(int Id)
        {
            try
            {
                using (var Db = new Db())
                {
                    GetAppTokenInfo appTokenInfo = Db.AppTokenInfo.Where(c => c.Id == Id).Select(d => new GetAppTokenInfo { Id = d.Id, appId = d.appID, appSecret = d.appsecret }).FirstOrDefault();

                    var result = AccessTokenContainer.TryGetToken(appTokenInfo.appId, appTokenInfo.appSecret);
                    return Json(result, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception e)
            {
                //TODO:为简化代码，这里不处理异常（如Token过期）
                return Json(new { error = "执行过程发生错误！", ex = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
    public class GetAppTokenInfo
    {
        public int Id { get; set; }
        public string appId { get; set; }
        public string appSecret { get; set; }
    }
}