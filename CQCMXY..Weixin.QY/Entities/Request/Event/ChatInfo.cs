﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ChatInfo.cs
    文件功能描述：会话信息
    
    
    创建标识：CQCMXY - 20150728
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    /// <summary>
    /// 会话信息
    /// </summary>
    public class ChatInfo
    {
        /// <summary>
        /// 会话id
        /// </summary>
        public string ChatId { get; set; }
        /// <summary>
        /// 会话标题
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 管理员userid
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// 会话成员列表，成员用userid标识，成员间以竖线“|”分隔
        /// </summary>
        public string UserList { get; set; }
    }
}
