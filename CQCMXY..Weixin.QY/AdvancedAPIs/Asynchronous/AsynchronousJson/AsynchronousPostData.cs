/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：AsynchronousPostData.cs
    文件功能描述：异步任务接口提交数据Json
    
    
    创建标识：CQCMXY - 20150408
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.QY.AdvancedAPIs.Asynchronous
{
    public class Asynchronous_CallBack
    {
        public string url { get; set; }
        public string token { get; set; }
        public string encodingaeskey { get; set; }
    }
}
