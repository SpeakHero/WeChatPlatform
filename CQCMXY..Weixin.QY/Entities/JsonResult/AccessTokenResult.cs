﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：AccessTokenResult.cs
    文件功能描述：access_token请求后的JSON返回格式
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.Weixin.Entities;

namespace CQCMXY.Weixin.QY.Entities
{
    /// <summary>
    /// GetToken请求后的JSON返回格式
    /// </summary>
    public class AccessTokenResult : QyJsonResult
    {
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        public string access_token { get; set; }
    }
}
