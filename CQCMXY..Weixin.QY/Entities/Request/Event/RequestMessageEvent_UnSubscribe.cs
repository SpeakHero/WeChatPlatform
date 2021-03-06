﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageEvent_Unsubscribe.cs
    文件功能描述：事件之取消关注事件的推送（unsubscribe）
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    /// <summary>
    /// 事件之取消关注事件的推送（unsubscribe）
    /// </summary>
    public class RequestMessageEvent_UnSubscribe : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.unsubscribe; }
        }
    }
}
