﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：AppApi.cs
    文件功能描述：管理企业号应用接口
    
    
    创建标识：CQCMXY - 20150316
  
    增加功能：获取应用概况列表
    修改标识：Bemguin - 20150614 
----------------------------------------------------------------*/

/*
    官方文档：http://qydev.WeiXin.qq.com/wiki/index.php?title=%E7%AE%A1%E7%90%86%E4%BC%81%E4%B8%9A%E5%8F%B7%E5%BA%94%E7%94%A8
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.QY.AdvancedAPIs.App;
using CQCMXY.WeiXin.QY.CommonAPIs;
using CQCMXY.WeiXin.QY.Entities;
using CQCMXY.WeiXin.HttpUtility;

namespace CQCMXY.WeiXin.QY.AdvancedAPIs
{
    /// <summary>
    /// 管理企业号应用
    /// </summary>
    public static class AppApi
    {
        /// <summary>
        /// 获取企业号应用信息
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="agentId">企业应用的id，可在应用的设置页面查看</param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static GetAppInfoResult GetAppInfo(string accessToken, int agentId, int timeOut = Config.TIME_OUT)
        {
            string url = string.Format("https://qyapi.WeiXin.qq.com/cgi-bin/agent/get?access_token={0}&agentid={1}", accessToken, agentId);

            return Get.GetJson<GetAppInfoResult>(url);
        }

        /// <summary>
        /// 设置企业号应用
        /// 此App只能修改现有的并且有权限管理的应用，无法创建新应用（因为新应用没有权限）
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="data">设置应用需要Post的数据</param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static QyJsonResult SetApp(string accessToken, SetAppPostData data, int timeOut = Config.TIME_OUT)
        {
            string url =string.Format( "https://qyapi.WeiXin.qq.com/cgi-bin/agent/set?access_token={0}",accessToken);

            return Get.GetJson<QyJsonResult>(url);
        }

        /// <summary>
        /// 获取应用概况列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static GetAppListResult GetAppList(string accessToken, int timeOut = Config.TIME_OUT)
        {
            string url = string.Format("https://qyapi.WeiXin.qq.com/cgi-bin/agent/list?access_token={0}",accessToken);

            return Get.GetJson<GetAppListResult>(url);
        }

    }
}
