﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.MessageHandlers;

namespace CQCMXY.WeiXin.MP.MvcExtension
{

   
    /// <summary>
    /// 返回MessageHandler结果
    /// </summary>
    public class WeiXinResult : ContentResult
    {
        //private string _content;
        protected IMessageHandlerDocument _messageHandlerDocument;

        public WeiXinResult(string content)
        {
            //_content = content;
            base.Content = content;
        }

        public WeiXinResult(IMessageHandlerDocument messageHandlerDocument)
        {
            _messageHandlerDocument = messageHandlerDocument;
        }

        /// <summary>
        /// 获取ContentResult中的Content或IMessageHandler中的ResponseDocument文本结果。
        /// 一般在测试的时候使用。
        /// </summary>
        new public string Content
        {
            get
            {
                if (base.Content != null)
                {
                    return base.Content;
                }
                else if (_messageHandlerDocument != null && _messageHandlerDocument.FinalResponseDocument != null)
                {
                    return _messageHandlerDocument.FinalResponseDocument.ToString();
                }
                else
                {
                    return null;
                }
            }
            set { base.Content = value; }
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (base.Content == null)
            {
                //使用IMessageHandler输出
                if (_messageHandlerDocument == null)
                {
                    throw new CQCMXY.WeiXin.Exceptions.WeiXinException("执行WeiXinResult时提供的MessageHandler不能为Null！", null);
                }

                if (_messageHandlerDocument.FinalResponseDocument == null)
                {
                    //throw new CQCMXY.WeiXin.MP.WeiXinException("ResponseMessage不能为Null！", null);
                }
                else
                {
                    context.HttpContext.Response.ClearContent();
                    context.HttpContext.Response.ContentType = "text/xml";
                    _messageHandlerDocument.FinalResponseDocument.Save(context.HttpContext.Response.OutputStream);
                }
            }

            base.ExecuteResult(context);
        }
    }
}
