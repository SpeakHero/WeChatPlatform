/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：WiFiQrcodeResultJson.cs
    文件功能描述：获取物料二维码返回结果
    
    
    创建标识：CQCMXY - 20150709
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.Weixin.Entities;
using CQCMXY.Weixin.MP.AdvancedAPIs.GroupMessage;

namespace CQCMXY.Weixin.MP.AdvancedAPIs.WiFi
{
    /// <summary>
    /// 获取物料二维码返回结果
    /// </summary>
    public class GetQrcodeResult : WxJsonResult
    {
        public GetQrcode_Data date { get; set; }
    }

    public class GetQrcode_Data
    {
        /// <summary>
        /// 二维码图片url
        /// </summary>
        public string qrcode_url { get; set; }
    }
}
