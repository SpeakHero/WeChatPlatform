﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：PostModel.cs
    文件功能描述：微信企业号服务器Post过来的参数集合（不包括PostData）
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.QY.Entities
{
    /// <summary>
    /// 微信企业号服务器Post过来的参数集合（不包括PostData）
    /// </summary>
    public class PostModel : EncryptPostModel
    {
        //以下信息不会出现在微信发过来的信息中，都是企业号后台需要设置（获取的）的信息，用于扩展传参使用
        public string CorpId { get; set; }
    }
}
