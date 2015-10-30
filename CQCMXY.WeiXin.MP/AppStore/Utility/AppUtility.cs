/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：AppUtility.cs
    文件功能描述：获取RequestMessage中ToUserName中的信息
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using CQCMXY.WeiXin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.AppStore.Utility
{
    /// <summary>
    /// 微信请求中ToUserName包含的信息
    /// </summary>
    public class WeiXinRequestInfo
    {
        /// <summary>
        /// 使用此应用的微信账号ID（在微微嗨平台上的唯一ID）
        /// </summary>
        public int WeiXinId { get; set; }

        /// <summary>
        /// 被请求应用的唯一ID
        /// </summary>
        public int AppId { get; set; }
    }

    public static class AppUtility
    {
        /// <summary>
        /// 获取RequestMessage中ToUserName中的信息（这条信息由微微嗨平台向APP发出）
        /// </summary>
        /// <param name="toUserName">RequestMessage中的ToUserName属性</param>
        /// <returns></returns>
        public static WeiXinRequestInfo GetWeiXinRequestInfo(string toUserName)
        {
            var info = new WeiXinRequestInfo();
            try
            {
                var data = toUserName.Split('_');
                info.WeiXinId = int.Parse(data[1]);
                info.AppId = int.Parse(data[2]);
            }
            catch
            {
            }
            return info;
        }

        /// <summary>
        /// 获取RequestMessage中ToUserName中的信息（这条信息由微微嗨平台向APP发出）
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        public static WeiXinRequestInfo GetWeiXinRequestInfo(this IRequestMessageBase requestMessage)
        {
            return GetWeiXinRequestInfo(requestMessage.ToUserName);
        }
    }
}
