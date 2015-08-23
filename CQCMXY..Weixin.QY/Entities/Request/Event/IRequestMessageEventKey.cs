/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：IRequestMessageEventKey.cs
    文件功能描述：具有EventKey属性的RequestMessage接口
    
    
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
    /// <summary>
    /// 具有EventKey属性的RequestMessage接口
    /// </summary>
    public interface IRequestMessageEventKey
    {
        string EventKey { get; set; }
    }
}
