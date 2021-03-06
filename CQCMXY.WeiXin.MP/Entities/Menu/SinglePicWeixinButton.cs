﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：SinglePicWeiXinButton.cs
    文件功能描述：调起微信相册按钮
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.Entities.Menu
{
    /// <summary>
    /// 单个按键
    /// </summary>
    public class SinglePicWeiXinButton : SingleButton
    {
        /// <summary>
        /// 类型为pic_WeiXin时必须。
        /// 用户点击按钮后，微信客户端将调起微信相册，完成选择操作后，将选择的相片发送给开发者的服务器，并推送事件给开发者，同时收起相册，随后可能会收到开发者下发的消息。
        /// 仅支持微信iPhone5.4.1以上版本，和Android5.4以上版本的微信用户，旧版本微信用户点击后将没有回应，开发者也不能正常接收到事件推送。
        /// </summary>
        public string key { get; set; }

        public SinglePicWeiXinButton()
            : base(ButtonType.pic_WeiXin.ToString())
        {
        }
    }
}
