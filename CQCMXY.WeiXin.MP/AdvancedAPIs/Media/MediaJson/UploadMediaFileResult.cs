﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：UploadMediaFileResult.cs
    文件功能描述：上传媒体文件返回结果
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
    
    修改标识：CQCMXY - 20150320
    修改描述：修改结果类型（有临时和永久之分）
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs.Media
{
    /// <summary>
    /// 上传临时媒体文件返回结果
    /// </summary>
    public class UploadTemporaryMediaResult : WxJsonResult
    {
        public UploadMediaFileType type { get; set; }
        public string media_id { get; set; }
        /// <summary>
        /// 上传缩略图返回的meidia_id参数.
        /// </summary>
        public string thumb_media_id { get; set; }
        public long created_at { get; set; }
    }

    /// <summary>
    /// 上传永久媒体文件返回结果
    /// </summary>
    public class UploadForeverMediaResult : WxJsonResult
    {
        public string media_id { get; set; }
    }
}
