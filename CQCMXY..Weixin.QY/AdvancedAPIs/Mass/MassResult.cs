﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.HttpUtility;

namespace CQCMXY.WeiXin.QY.AdvancedAPIs.Mass
{
    /// <summary>
    /// 发送消息返回结果
    /// 如果对应用或收件人、部门、标签任何一个无权限，则本次发送失败；如果收件人、部门或标签不存在，发送仍然执行，但返回无效的部分。
    /// </summary>
    public class MassResult : QyJsonResult
    {
        public string invaliduser { get; set; }
        public string invalidparty { get; set; }
        public string invalidtag { get; set; }
    }
}
