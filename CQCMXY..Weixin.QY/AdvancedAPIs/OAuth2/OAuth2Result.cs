﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：OAuth2Result.cs
    文件功能描述：获取成员信息返回结果
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
 
    修改标识：CQCMXY - 20150316
    修改描述：添加DeviceId字段
 
    修改标识：CQCMXY - 20150316
    修改描述：GetUserIdResult变更为GetUserInfoResult，增加OpenId字段
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.QY.AdvancedAPIs.OAuth2
{
    /// <summary>
    /// 获取成员信息返回结果
    /// </summary>
    public class GetUserInfoResult : QyJsonResult
    {
        /// <summary>
        /// 员工UserID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 非企业成员的OpenId
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 手机设备号(由微信在安装时随机生成)
        /// </summary>
        public string DeviceId { get; set; }
    }
}
