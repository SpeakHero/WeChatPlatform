/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：PassportBag.cs
    文件功能描述：Passport包
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.AppStore
{
    public class PassportBag
    {
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public string AppUrl { get; set; }

        public Passport Passport { get; set; }

        public PassportBag(string appKey, string appSecret, string appUrl)
        {
            AppKey = appKey;
            AppSecret = appSecret;
            AppUrl = appUrl;
        }
    }
}
