﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RefreshAuthorizerTokenResult.cs
    文件功能描述：获取（刷新）授权公众号的令牌返回结果
    
    
    创建标识：CQCMXY - 20150726
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.Open.Entities;

namespace CQCMXY.WeiXin.Open.ComponentAPIs
{
    /// <summary>
    /// 获取（刷新）授权公众号的令牌返回结果
    /// </summary>
    public class RefreshAuthorizerTokenResult : WxJsonResult
    {
        /// <summary>
        /// 授权方令牌
        /// </summary>
        public string authorizer_access_token { get; set; }
        /// <summary>
        /// 有效期，为2小时
        /// </summary>
        public int expires_in { get; set; }
        /// <summary>
        /// 刷新令牌
        /// </summary>
        public string authorizer_refresh_token { get; set; }
    }
}