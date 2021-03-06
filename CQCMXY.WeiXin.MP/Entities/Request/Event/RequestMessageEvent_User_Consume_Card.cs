﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageEvent_User_Consume_Card.cs
    文件功能描述：事件之卡券核销
    
    
    创建标识：CQCMXY - 20150722
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.Entities
{
    public class RequestMessageEvent_User_Consume_Card : RequestMessageEventBase, IRequestMessageEventBase
    {
        /// <summary>
        /// 卡券核销
        /// </summary>
        public override Event Event
        {
            get { return Event.user_consume_card; }
        }

        /// <summary>
        /// 卡券ID
        /// </summary>
        public string CardId { get; set; }
        /// <summary>
        /// 卡券Code码
        /// </summary>
        public string UserCardCode { get; set; }
        /// <summary>
        /// 核销来源。支持开发者统计API核销（FROM_API）、公众平台核销（FROM_MP）、卡券商户助手核销（FROM_MOBILE_HELPER）（核销员微信号）
        /// </summary>
        public string ConsumeSource { get; set; }
    }
}
