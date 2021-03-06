﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
 
    文件名：TenPayInfo.cs
    文件功能描述：微信支付基础信息储存类
    
    
    创建标识：CQCMXY - 20150722
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.TenPayLib
{
    /// <summary>
    /// 微信支付基础信息储存类
    /// </summary>
    public class TenPayInfo
    {
        /// <summary>
        /// 第三方用户唯一凭证appid
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 第三方用户唯一凭证密钥，即appsecret
        /// </summary>
        public string AppSecret { get; set; }
        /// <summary>
        /// 商户ID
        /// </summary>
        public string MchId { get; set; }
        /// <summary>
        /// 商户支付密钥Key。登录微信商户后台，进入栏目【账户设置】【密码安全】【API 安全】【API 密钥】
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 支付完成后的回调处理页面
        /// </summary>
        public string TenPayNotify { get; set; } // = "http://localhost/payNotifyUrl.aspx";

        public TenPayInfo(string appId, string appSecret, string mchId, string key, string tenPayNotify)
        {
            AppId = appId;
            AppSecret = appSecret;
            MchId = mchId;
            Key = key;
            TenPayNotify = tenPayNotify;
        }
    }
}
