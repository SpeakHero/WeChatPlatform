﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageEvent_Kf_Switch_Session.cs
    文件功能描述：事件之多客服接入会话(kf_switch_session)
    
    
    创建标识：CQCMXY - 20150309
    
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.Entities
{
    /// <summary>
    /// 事件之多客服转接会话kf_switch_session)
    /// </summary>
    public class RequestMessageEvent_Kf_Switch_Session : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.kf_switch_session; }
        }

        /// <summary>
        /// 完整客服账号，格式为：账号前缀@公众号微信号
        /// </summary>
        public string FromKfAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ToKfAccount { get; set; }
    }
}
