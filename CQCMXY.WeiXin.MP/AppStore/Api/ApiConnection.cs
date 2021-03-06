﻿/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：ApiConnection.cs
    文件功能描述：API链接
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System;
using CQCMXY.WeiXin.Exceptions;
using CQCMXY.WeiXin.MP;

namespace CQCMXY.WeiXin.MP.AppStore.Api
{
    public class ApiConnection
    {
        private Passport _passport;
        public ApiConnection(Passport passport)
        {
            if (passport == null)
            {
                throw new WeiXinException("Passport不可以为NULL！");
            }
            _passport = passport;
        }

        /// <summary>
        /// 自动更新Passport的链接方法
        /// </summary>
        /// <param name="apiFunc"></param>
        /// <returns></returns>
        public IAppResult<T> Connection<T>(Func<IAppResult<T>> apiFunc) where T : IAppResultData
        {
            var result = apiFunc();
            if (result.Result == AppResultKind.账户验证失败)
            {
                //更新Passport
                AppStoreManager.ApplyPassport(_passport.AppKey, _passport.Secret, _passport.ApiUrl);
                result = apiFunc();
            }
            return result;
        }
    }
}
