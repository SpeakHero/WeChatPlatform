﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：Passport.cs
    文件功能描述：P2P通行证
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.AppStore
{
    /// <summary>
    /// P2P通行证
    /// </summary>
    public class Passport : IAppResultData
    {
        public string Token { get; set; }
        public string AppKey { get; set; }
        public string Secret { get; set; }
        /// <summary>
        /// API常规URL
        /// </summary>
        public string ApiUrl { get; set; }

        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 供微微嗨服务器记录唯一开发人员ID
        /// </summary>
        public int DeveloperId { get; set; }
    }
}
