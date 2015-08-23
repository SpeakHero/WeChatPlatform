/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：BroswerUtility.cs
    文件功能描述：浏览器公共类
    
    
    创建标识：CQCMXY - 20150419
    
----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CQCMXY.Weixin.BrowserUtility
{
    public static class BroswerUtility
    {
        /// <summary>
        /// 判断是否在微信内置浏览器中
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static bool SideInWeixinBroswer(HttpContextBase httpContext)
        {
            var userAgent = httpContext.Request.UserAgent;
            if (string.IsNullOrEmpty(userAgent) || (!userAgent.Contains("MicroMessenger") && !userAgent.Contains("Windows Phone")))
            {
                //在微信外部
                return false;
            }
            //在微信内部
            return true;
        }
    }
}
