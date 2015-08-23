﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ComponentAccessTokenResult.cs
    文件功能描述：获取第三方平台access_token
    
    
    创建标识：CQCMXY - 20150430
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.Open.Entities
{
    /// <summary>
    /// 获取第三方平台access_token
    /// </summary>
    public class ComponentAccessTokenResult
    {
        /// <summary>
        /// 第三方平台access_token
        /// </summary>
        public string component_access_token { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public int expires_in { get; set; }
    }
}
