/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：WxJsonResult.cs
    文件功能描述：JSON返回结果
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.MP.AppStore
{
    /// <summary>
    /// JSON返回结果（用于菜单接口等）
    /// </summary>
    public class WxJsonResult
    {
        public int errcode { get; set; }
        public string errmsg { get; set; }
    }
}
