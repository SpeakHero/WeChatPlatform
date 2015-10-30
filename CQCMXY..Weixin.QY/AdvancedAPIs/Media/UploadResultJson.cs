﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：UploadResultJson.cs
    文件功能描述：上传媒体文件返回结果
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.QY.AdvancedAPIs.Media
{
    /// <summary>
    /// 上传临时媒体文件返回结果
    /// </summary>
    public class UploadTemporaryResultJson : QyJsonResult
    {
        public UploadMediaFileType type { get; set; }
        public string media_id { get; set; }
        public long created_at { get; set; }
    }

    /// <summary>
    /// 上传永久素材返回结果
    /// </summary>
    public class UploadForeverResultJson : QyJsonResult
    {
        public string media_id { get; set; }
    }
}
