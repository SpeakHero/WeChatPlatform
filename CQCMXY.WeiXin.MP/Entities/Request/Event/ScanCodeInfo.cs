﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ScanCodeInfo.cs
    文件功能描述：扫码事件中的ScanCodeInfo
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.Entities
{
    /// <summary>
    /// 扫码事件中的ScanCodeInfo
    /// </summary>
    public class ScanCodeInfo
    {
        public string ScanType { get; set; }
        public string ScanResult { get; set; }
    }
}
