/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：StreamUtility.cs
    文件功能描述：微信对象公共类
    
    
    创建标识：CQCMXY - 20150703
    
----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.Utilities.WeixinUtility
{
    public static class ApiUtility
    {
        /// <summary>
        /// 判断accessTokenOrAppId参数是否是AppId
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <returns></returns>
        public static bool IsAppId(string accessTokenOrAppId)
        {
            return accessTokenOrAppId != null && accessTokenOrAppId.Length <= 18/*wxc3c90837b0e76080*/;
        }
    }
}
