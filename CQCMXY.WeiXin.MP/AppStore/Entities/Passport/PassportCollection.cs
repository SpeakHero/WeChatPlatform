﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：PassportCollection.cs
    文件功能描述：同时管理多个应用的Passport的容器
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System.Collections.Generic;

namespace CQCMXY.WeiXin.MP.AppStore
{
    /// <summary>
    /// 同时管理多个应用的Passport的容器
    /// </summary>
    public class PassportCollection : Dictionary<string, PassportBag>
    {
        /// <summary>
        /// 统一URL前缀，如http://api.weiweihi.com:8080/App/Api
        /// </summary>
        public string BasicUrl { get; set; }
        public string MarketingToolUrl { get; set; }
        public PassportCollection()
        {
        }
    }
}
