﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：GetIdResult.cs
    文件功能描述：获取用户分组ID返回结果
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs.Groups
{
    /// <summary>
    /// 获取用户分组ID返回结果
    /// </summary>
    public class GetGroupIdResult : WxJsonResult
    {
        public int groupid { get; set; }
    }
}
