/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageUnauthorized.cs
    文件功能描述：推送取消授权通知
    
    
    创建标识：CQCMXY - 20150430
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.Open
{
    public class RequestMessageUnauthorized : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.unauthorized; }
        }
        public string AuthorizerAppid { get; set; }
    }
}
