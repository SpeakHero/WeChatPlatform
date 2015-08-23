/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageVideo.cs
    文件功能描述：接收普通视频消息
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.QY.Entities
{
    public class RequestMessageVideo : RequestMessageBase, IRequestMessageBase
    {
        public override RequestMsgType MsgType
        {
            get { return RequestMsgType.Video; }
        }

        public string MediaId { get; set;}
        public string ThumbMediaId { get; set; }
    }
}
