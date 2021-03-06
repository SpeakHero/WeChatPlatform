﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：Semantic_SearchResult.cs
    文件功能描述：语意理解接口网页搜索（search）返回信息
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.MP.Entities;

namespace CQCMXY.WeiXin.MP.AdvancedAPIs.Semantic
{
    /// <summary>
    /// 网页搜索（search））
    /// </summary>
    public class Semantic_SearchResult : BaseSemanticResultJson
    {
        public Semantic_Search semantic { get; set; }
    }

    public class Semantic_Search : BaseSemanticIntent
    {
        public Semantic_Details_Search details { get; set; }
    }

    public class Semantic_Details_Search
    {
        /// <summary>
        /// 关键词
        /// </summary>
        public string keyword { get; set; }
        /// <summary>
        /// 搜索引擎类型：google, baidu, sogou, 360, taobao,jingdong
        /// </summary>
        public string channel { get; set; }
    }
}