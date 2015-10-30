using CQCMXY.WeiXin.MP;
using CQCMXY.WeiXin.MP.Entities.Request;
using CQCMXY.WeiXin.MP.MvcExtension;
using CQCMXY.WeiXin.Service.CustomMessageHandler;
using CQCMXY.WeiXin.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class WeiXinController : Controller
    {


        public WeiXinAccoutInfo WeiXininfo = new WeiXinAccoutInfo();

        //public static readonly string Token = WeiXininfo.Token;//与微信公众账号后台的Token设置保持一致，区分大小写。
        //public static readonly string EncodingAESKey = WeiXininfo.WeiXinEncodingAESKey;//与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。
        //public static readonly string AppId = WeiXininfo.appID;//与微信公众账号后台的AppId设置保持一致，区分大小写。

        /// <summary>
        /// 微信后台验证地址（使用Get），微信后台的“接口配置信息”的Url填写如：http://WeiXin.cqcmxy.com/WeiXin
        /// </summary>
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Get(PostModel postModel, string echostr)
        {
            if (CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, WeiXininfo.Token))
            {
                return Content(echostr); //返回随机字符串则表示验证通过
            }
            else
            {
                return Content("failed:" + postModel.Signature + "," + WeiXin.MP.CheckSignature.GetSignature(postModel.Timestamp, postModel.Nonce, WeiXininfo.Token) + "。" +
                    "如果你在浏览器中看到这句话，说明此地址可以被作为微信公众账号后台的Url，请注意保持Token一致。");
            }
        }

        /// <summary>
        /// 用户发送消息后，微信平台自动Post一个请求到这里，并等待响应XML。
        /// </summary>
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Post(PostModel postModel)
        {
            if (!CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, this.WeiXininfo.Token))
            {
                return Content("参数错误！");
            }

            postModel.Token = WeiXininfo.Token;
            postModel.EncodingAESKey = WeiXininfo.EncodingAESKey;//根据自己后台的设置保持一致
            postModel.AppId = WeiXininfo.appID;//根据自己后台的设置保持一致
            //每个人上下文消息储存的最大数量，防止内存占用过多，如果该参数小于等于0，则不限制
            var maxRecordCount = 10;
            var logPath = Server.MapPath(string.Format("~/App_Data/MP/{0}/", DateTime.Now.ToString("yyyy-MM-dd")));
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            //自定义MessageHandler，对微信请求的详细判断操作都在这里面。
            var messageHandler = new CustomMessageHandler(Request.InputStream, postModel, maxRecordCount);
            try
            {

                //测试时可开启此记录，帮助跟踪数据，使用前请确保App_Data文件夹存在，且有读写权限。
                messageHandler.RequestDocument.Save(Path.Combine(logPath, string.Format("{0}_Request_{1}.txt", DateTime.Now.Ticks, messageHandler.RequestMessage.FromUserName)));
                if (messageHandler.UsingEcryptMessage)
                {
                    messageHandler.EcryptRequestDocument.Save(Path.Combine(logPath, string.Format("{0}_Request_Ecrypt_{1}.txt", DateTime.Now.Ticks, messageHandler.RequestMessage.FromUserName)));
                }
                messageHandler.OmitRepeatedMessage = true; //消息去重功能

                //执行微信处理过程
                messageHandler.Execute();

                //测试时可开启，帮助跟踪数据

                //if (messageHandler.ResponseDocument == null)
                //{
                //    throw new Exception(messageHandler.RequestDocument.ToString());
                //}

                if (messageHandler.ResponseDocument != null)
                {
                    messageHandler.ResponseDocument.Save(Path.Combine(logPath, string.Format("{0}_Response_{1}.txt", DateTime.Now.Ticks, messageHandler.RequestMessage.FromUserName)));
                }

                if (messageHandler.UsingEcryptMessage)
                {
                    //记录加密后的响应信息
                    messageHandler.FinalResponseDocument.Save(Path.Combine(logPath, string.Format("{0}_Response_Final_{1}.txt", DateTime.Now.Ticks, messageHandler.RequestMessage.FromUserName)));
                }
                return new FixWeiXinBugWeiXinResult(messageHandler);//为了解决官方微信5.0软件换行bug暂时添加的方法
            }
            catch (Exception ex)
            {
                using (TextWriter tw = new StreamWriter(Server.MapPath("~/App_Data/Error_" + DateTime.Now.Ticks + ".txt")))
                {
                    tw.WriteLine("ExecptionMessage:" + ex.Message);
                    tw.WriteLine(ex.Source);
                    tw.WriteLine(ex.StackTrace);
                    //tw.WriteLine("InnerExecptionMessage:" + ex.InnerException.Message);

                    if (messageHandler.ResponseDocument != null)
                    {
                        tw.WriteLine(messageHandler.ResponseDocument.ToString());
                    }

                    if (ex.InnerException != null)
                    {
                        tw.WriteLine("========= InnerException =========");
                        tw.WriteLine(ex.InnerException.Message);
                        tw.WriteLine(ex.InnerException.Source);
                        tw.WriteLine(ex.InnerException.StackTrace);
                    }

                    tw.Flush();
                    tw.Close();
                }
                return Content("");
            }
        }


        /// <summary>
        /// 最简化的处理流程（不加密）
        /// </summary>
        [HttpPost]
        [ActionName("MiniPost")]
        public ActionResult MiniPost(PostModel postModel)
        {
            if (!CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, this.WeiXininfo.Token))
            {
                //return Content("参数错误！");//v0.7-
                return new WeiXinResult("参数错误！");//v0.8+
            }
            postModel.Token = WeiXininfo.Token;
            postModel.EncodingAESKey = WeiXininfo.EncodingAESKey;//根据自己后台的设置保持一致
            postModel.AppId = WeiXininfo.appID;//根据自己后台的设置保持一致
            var messageHandler = new CustomMessageHandler(Request.InputStream, postModel, 10);
            messageHandler.Execute();//执行微信处理过程
            return new FixWeiXinBugWeiXinResult(messageHandler);//v0.8+
        }



        /// <summary>
        /// 为测试并发性能而建
        /// </summary>
        /// <returns></returns>
        public ActionResult ForTest()
        {
            //异步并发测试（提供给单元测试使用）
            DateTime begin = DateTime.Now;
            int t1, t2, t3;
            System.Threading.ThreadPool.GetAvailableThreads(out t1, out t3);
            System.Threading.ThreadPool.GetMaxThreads(out t2, out t3);
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.5));
            DateTime end = DateTime.Now;
            var thread = System.Threading.Thread.CurrentThread;
            var result = string.Format("TId:{0}\tApp:{1}\tBegin:{2:mm:ss,ffff}\tEnd:{3:mm:ss,ffff}\tTPool：{4}",
                    thread.ManagedThreadId,
                    HttpContext.ApplicationInstance.GetHashCode(),
                    begin,
                    end,
                    t2 - t1
                    );
            return Content(result);
        }
    }
}