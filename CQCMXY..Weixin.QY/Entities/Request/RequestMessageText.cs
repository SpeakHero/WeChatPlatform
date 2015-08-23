/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageText.cs
    文件功能描述：接收普通文本消息
    
    
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
    public class RequestMessageText : RequestMessageBase,IRequestMessageBase
    {
        public override RequestMsgType MsgType
        {
            get { return RequestMsgType.Text; }
        }
        public string Content { get; set; }
    }
}
