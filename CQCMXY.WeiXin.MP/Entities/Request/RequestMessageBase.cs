﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：RequestMessageBase.cs
    文件功能描述：接收到请求的消息基类
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.MP.Entities
{
    public interface IRequestMessageBase : WeiXin.Entities.IRequestMessageBase
    {
        RequestMsgType MsgType { get; }
        string Encrypt { get; set; }
        new long   MsgId { get; set; }
    }

    /// <summary>
    /// 接收到请求的消息
    /// </summary>
    public class RequestMessageBase : WeiXin.Entities.RequestMessageBase, IRequestMessageBase
    {
        public virtual RequestMsgType MsgType
        {
            get { return RequestMsgType.Text; }
        }

        public string Encrypt { get; set; }

        public RequestMessageBase()
        {

        }

        //public override RequestMsgType MsgType
        //{
        //    get { return RequestMsgType.Text; }
        //}

        public long MsgId { get; set; }
    }
}
