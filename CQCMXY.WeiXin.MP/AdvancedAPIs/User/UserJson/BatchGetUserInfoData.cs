/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：BatchGetUserInfoData.cs
    文件功能描述：批量获取用户基本信息数据
    
    
    创建标识：CQCMXY - 20150727
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.Weixin.Entities;

namespace CQCMXY.Weixin.MP.AdvancedAPIs.User
{
    /// <summary>
    /// 批量获取用户基本信息数据
    /// </summary>
    public class BatchGetUserInfoData
    {
        /// <summary>
        /// 用户的标识，对当前公众号唯一
        /// 必填
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 国家地区语言版本，zh_CN 简体，zh_TW 繁体，en 英语，默认为zh-CN
        /// 非必填
        /// </summary>
        public Language lang { get; set; }
    }
}
