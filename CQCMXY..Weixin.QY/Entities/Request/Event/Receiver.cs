﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：Receiver.cs
    文件功能描述：接收人
    
    
    创建标识：CQCMXY - 20150728
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    /// <summary>
    /// 接收人
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// 接收人类型：single|group，分别表示：群聊|单聊
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 接收人的值，为userid|chatid，分别表示：成员id|会话id
        /// </summary>
        public string Id { get; set; }
    }
}
