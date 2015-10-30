/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：MemberApi.cs
    文件功能描述：获取用户信息Api
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.WeiXin.MP.AppStore.Api
{
    public class MemberApi : BaseApi
    {
        public MemberApi(Passport passport)
            : base(passport)
        {
        }

        private GetMemberResult GetMemberFunc(int WeiXinId, string openId)
        {
            var url = _passport.ApiUrl + "GetMember";
            var formData = new Dictionary<string, string>();
            formData["token"] = _passport.Token;
            formData["openid"] = openId;
            formData["WeiXinId"] = WeiXinId.ToString();

            var result = HttpUtility.Post.PostGetJson<GetMemberResult>(url, formData: formData);
            return result;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public GetMemberResult GetMember(int WeiXinId, string openId)
        {
            return ApiConnection.Connection(() => GetMemberFunc(WeiXinId, openId)) as GetMemberResult;
        }
    }
}
