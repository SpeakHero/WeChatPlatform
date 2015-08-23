/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：Video.cs
    文件功能描述：响应回复消息 视频类
    
    
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
    public class Video
    {
        public string MediaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
 