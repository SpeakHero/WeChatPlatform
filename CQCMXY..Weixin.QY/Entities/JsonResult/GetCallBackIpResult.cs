﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：GetCallBackIpResult.cs
    文件功能描述：获取微信服务器的ip段的JSON返回格式
    
    
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
    public class GetCallBackIpResult : QyJsonResult
    {
        public string[] ip_list { get; set; }
    }
}