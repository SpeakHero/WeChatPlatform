﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ButtonGroup.cs
    文件功能描述：整个按钮设置（可以直接用ButtonGroup实例返回JSON对象）
    
    
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
    /// 整个按钮设置（可以直接用ButtonGroup实例返回JSON对象）
    /// </summary>
    public class ButtonGroup
    {
        /// <summary>
        /// 按钮数组，按钮个数应为2~3个
        /// </summary>
        public List<BaseButton> button { get; set; }

        public ButtonGroup()
        {
            button = new List<BaseButton>();
        }
    }
}
