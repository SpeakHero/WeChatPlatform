/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
 
    文件名：TenPayInfoCollection.cs
    文件功能描述：微信支付信息集合，Key为商户号（PartnerId）
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Exceptions;

namespace CQCMXY.WeiXin.MP.TenPayLib
{
    /// <summary>
    /// 微信支付信息集合，Key为商户号（PartnerId）
    /// </summary>
    public class TenPayInfoCollection : Dictionary<string, TenPayInfo>
    {
        /// <summary>
        /// 微信支付信息集合，Key为商户号（PartnerId）
        /// </summary>
        public static TenPayInfoCollection Data = new TenPayInfoCollection();

        /// <summary>
        /// 注册WeiXinPayInfo信息
        /// </summary>
        /// <param name="WeiXinPayInfo"></param>
        public static void Register(TenPayInfo WeiXinPayInfo)
        {
            Data[WeiXinPayInfo.PartnerId] = WeiXinPayInfo;
        }

        new public TenPayInfo this[string key]
        {
            get
            {
                if (!base.ContainsKey(key))
                {
                    throw new WeiXinException(string.Format("WeiXinPayInfoCollection尚未注册Partner：{0}", key));
                }
                else
                {
                    return base[key];
                }
            }
            set
            {
                base[key] = value;
            }
        }

        public TenPayInfoCollection()
            : base(StringComparer.OrdinalIgnoreCase)
        {

        }
    }
}
