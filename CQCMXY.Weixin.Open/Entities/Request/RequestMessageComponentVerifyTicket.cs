/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageComponentVerifyTicket.cs
    文件功能描述：推送component_verify_ticket协议
    
    
    创建标识：CQCMXY - 20150430
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.Open
{
    public class RequestMessageComponentVerifyTicket : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.component_verify_ticket; }
        }
        public string ComponentVerifyTicket { get; set; }
    }
}
