/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageShortVideo.cs
    文件功能描述：接收小视频消息
    
    
    创建标识：CQCMXY - 20150708
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    public class RequestMessageShortVideo : RequestMessageBase, IRequestMessageBase
    {
        public override RequestMsgType MsgType
        {
            get { return RequestMsgType.ShortVideo; }
        }

        public string MediaId { get; set;}
        public string ThumbMediaId { get; set; }
    }
}
