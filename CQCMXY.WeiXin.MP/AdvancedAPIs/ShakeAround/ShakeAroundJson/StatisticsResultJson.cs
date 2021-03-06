﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：StatisticsResultJson.cs
    文件功能描述：数据统计返回结果
    
    
    创建标识：CQCMXY - 20150512
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.MP.AdvancedAPIs.GroupMessage;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs.ShakeAround
{
    /// <summary>
    /// 数据统计返回结果
    /// </summary>
    public class StatisticsResultJson : WxJsonResult
    {
        /// <summary>
        /// 数据统计返回数据
        /// </summary>
        public List<Statistics_DataItem> data { get; set; }
    }

    public class Statistics_DataItem
    {
        /// <summary>
        /// 点击摇周边消息的次数
        /// </summary>
        public int click_pv { get; set; }
        /// <summary>
        /// 点击摇周边消息的人数
        /// </summary>
        public int click_uv { get; set; }
        /// <summary>
        /// 当天0点对应的时间戳
        /// </summary>
        public long ftime { get; set; }
        /// <summary>
        /// 摇周边的次数
        /// </summary>
        public int shake_pv { get; set; }
        /// <summary>
        /// 摇周边的人数
        /// </summary>
        public int shake_uv { get; set; }
    }
}