﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：TemplateDataItem.cs
    文件功能描述：模板消息的数据项类型
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs.TemplateMessage
{
    /// <summary>
    /// 模板消息的数据项类型
    /// </summary>
    public class TemplateDataItem
    {
        /// <summary>
        /// 项目值
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 16进制颜色代码，如：#FF0000
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">value</param>
        /// <param name="c">color</param>
        public TemplateDataItem(string v, string c = "#173177")
        {
            value = v;
            color = c;
        }
    }
}
