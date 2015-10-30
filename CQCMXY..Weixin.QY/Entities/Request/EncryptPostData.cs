/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：EncryptPostData.cs
    文件功能描述：原始加密信息
    
    
    创建标识：CQCMXY - 20150313
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    public class EncryptPostData
    {
        public string ToUserName { get; set; }
        public string Encrypt { get; set; }
        public int AgentID { get; set; }
    }
}
