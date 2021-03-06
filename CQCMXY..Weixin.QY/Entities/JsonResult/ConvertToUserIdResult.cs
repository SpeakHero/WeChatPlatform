﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ConvertToUserIdResult.cs
    文件功能描述：openid转换成userid接口返回的Json结果
    
    
    创建标识：CQCMXY - 20150722
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.QY.Entities
{
    /// <summary>
    /// openid转换成userid接口返回的Json结果
    /// </summary>
    public class ConvertToUserIdResult : QyJsonResult
    {
        /// <summary>
        /// 该openid在企业号中对应的成员userid
        /// </summary>
        public string userid { get; set; }
    }
}
