﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using CQCMXY.WeiXin.MP.Entities;
using CQCMXY.WeiXin.MP.Helpers;
using CQCMXY.WeiXin.MP.MessageHandlers;
using CQCMXY.WeiXin.Service.CustomMessageHandler;
using CQCMXY.WeiXin.MP.Entities.Request;
using CQCMXY.WeiXin.Service.OpenTicket;
using CQCMXY.WeiXin.Service.Utilities;

namespace CQCMXY.WeiXin.Service.MessageHandlers.OpenMessageHandler
{
    /// <summary>
    /// 开放平台全网发布之前需要做的验证
    /// </summary>
    public class OpenCheckMessageHandler : MessageHandler<CustomMessageContext>
    {
        private string testAppId = "wx570bc396a51b8ff8";
        private string componentAppId = WebConfigurationManager.AppSettings["Component_Appid"];
        private string componentSecret = WebConfigurationManager.AppSettings["Component_Secret"];

        public OpenCheckMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0)
            : base(inputStream, postModel, maxRecordCount)
        {

        }

        public override IResponseMessageBase OnTextRequest(RequestMessageText requestMessage)
        {
            var responseMessage = requestMessage.CreateResponseMessage<ResponseMessageText>();
            if (requestMessage.Content == "TESTCOMPONENT_MSG_TYPE_TEXT")
            {
                responseMessage.Content = requestMessage.Content + "_callback";//固定为TESTCOMPONENT_MSG_TYPE_TEXT_callback
            }
            else if (requestMessage.Content.StartsWith("QUERY_AUTH_CODE:"))
            {
                string openTicket = OpenTicketHelper.GetOpenTicket(componentAppId);
                var query_auth_code = requestMessage.Content.Replace("QUERY_AUTH_CODE:", "");
                try
                {
                    var component_access_token = Open.CommonAPIs.CommonApi.GetComponentAccessToken(componentAppId, componentSecret, openTicket).component_access_token;
                    var oauthResult = Open.ComponentAPIs.ComponentApi.QueryAuth(component_access_token, componentAppId, query_auth_code);

                    //调用客服接口
                    var content = query_auth_code + "_from_api";
                    var sendResult = MP.AdvancedAPIs.CustomApi.SendText(oauthResult.authorization_info.authorizer_access_token,
                          requestMessage.FromUserName, content);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return responseMessage;
        }

        public override IResponseMessageBase OnEventRequest(IRequestMessageEventBase requestMessage)
        {
            var responseMessage = requestMessage.CreateResponseMessage<ResponseMessageText>();
            responseMessage.Content = requestMessage.Event + "from_callback";
            return responseMessage;
        }

        //public override Entities.IResponseMessageBase DefaultResponseMessage(Entities.IRequestMessageBase requestMessage)
        //{
        //    var responseMessage = requestMessage.CreateResponseMessage<ResponseMessageText>();
        //    responseMessage.Content = "默认消息";
        //    return responseMessage;
        //}

        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            throw new NotImplementedException();
        }
    }
}
