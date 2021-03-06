﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
 
    文件名：TenPayRights.cs
    文件功能描述：微信支付维权接口
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

/*
    官方API：https://mp.WeiXin.qq.com/htmledition/res/bussiness-course2/wxm-payment-kf-api.pdf
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.MP.CommonAPIs;
using CQCMXY.WeiXin.HttpUtility;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs
{
    /// <summary>
    /// 微信支付维权接口，官方API：https://mp.WeiXin.qq.com/htmledition/res/bussiness-course2/wxm-payment-kf-api.pdf
    /// </summary>
    public static class TenPayRights
    {
        /// <summary>
        /// 标记客户的投诉处理状态
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="openId">支付该笔订单的用户 ID</param>
        /// <param name="feedBackId">投诉单号</param>
        /// <returns></returns>
        public static WxJsonResult UpDateFeedBack(string accessToken, string openId, string feedBackId)
        {
            var urlFormat = "https://api.WeiXin.qq.com/payfeedback/update?access_token={0}&openid={1}&feedbackid={2}";
            var url = string.Format(urlFormat, accessToken, openId, feedBackId);

            return Get.GetJson<WxJsonResult>(url);
        }
    }
}
