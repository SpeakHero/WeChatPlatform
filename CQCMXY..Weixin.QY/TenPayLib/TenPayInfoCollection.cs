/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
 
    文件名：TenPayInfoCollection.cs
    文件功能描述：微信支付信息集合，Key为商户号（MchId）
    
    
    创建标识：CQCMXY - 20150722
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Exceptions;

namespace CQCMXY.WeiXin.QY.TenPayLib
{
    /// <summary>
    /// 微信支付信息集合，Key为商户号（MchId）
    /// </summary>
    public class TenPayInfoCollection : Dictionary<string, TenPayInfo>
    {
        /// <summary>
        /// 微信支付信息集合，Key为商户号（MchId）
        /// </summary>
        public static TenPayInfoCollection Data = new TenPayInfoCollection();

        /// <summary>
        /// 注册TenPayInfo信息
        /// </summary>
        /// <param name="tenPayInfo"></param>
        public static void Register(TenPayInfo tenPayInfo)
        {
            Data[tenPayInfo.MchId] = tenPayInfo;
        }

        new public TenPayInfo this[string key]
        {
            get
            {
                if (!base.ContainsKey(key))
                {
                    throw new WeiXinException(string.Format("TenPayInfoCollection尚未注册Mch：{0}", key));
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
