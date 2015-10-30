/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：WeiXinException.cs
    文件功能描述：微信自定义异常基类
    
    
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
    /// <summary>
    /// 微信自定义异常基类
    /// </summary>
    public class WeiXinException : ApplicationException
    {
        public WeiXinException(string message)
            : base(message, null)
        {
        }

        public WeiXinException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
