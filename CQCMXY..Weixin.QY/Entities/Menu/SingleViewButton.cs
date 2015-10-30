﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：SingleViewButton.cs
    文件功能描述：Url按钮
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities.Menu
{
    /// <summary>
    /// Url按键
    /// </summary>
    public class SingleViewButton : SingleButton
    {
        /// <summary>
        /// 类型为view时必须
        /// 网页链接，用户点击按钮可打开链接，不超过256字节
        /// </summary>
        public string url { get; set; }

        public SingleViewButton()
            : base(ButtonType.view.ToString())
        {
        }
    }
}
