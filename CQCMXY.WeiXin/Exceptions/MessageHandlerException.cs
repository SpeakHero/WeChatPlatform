/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：MessageHandlerException.cs
    文件功能描述：微信消息异常处理类
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.Exceptions
{
    public class MessageHandlerException : WeiXinException
    {
          public MessageHandlerException(string message)
            : base(message, null)
        {
        }

          public MessageHandlerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
