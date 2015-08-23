/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：ThirdPartyInfo_Cancel_Auth.cs
    文件功能描述：取消授权的通知
    
    
    创建标识：CQCMXY - 20150313
    
    修改标识：CQCMXY - 20150313
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQCMXY.Weixin.QY.Entities
{
    /// <summary>
    /// 取消授权的通知
    /// </summary>
    public class RequestMessageInfo_Cancel_Auth : ThirdPartyInfoBase, IThirdPartyInfoBase
    {
        public override ThirdPartyInfo InfoType
        {
            get { return ThirdPartyInfo.CANCEL_AUTH; }
        }

        /// <summary>
        /// 授权方企业号的corpid内容
        /// </summary>
        public string AuthCorpId { get; set; }
    }
}
