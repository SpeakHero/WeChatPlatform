﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CQCMXY.Weixin.MP.CommonAPIs;
using CQCMXY.Weixin.MP.Entities;

namespace CQCMXY.Weixin.MP.AdvancedAPIs
{
    /// <summary>
    /// 微小店接口，官方API：http://mp.weixin.qq.com/wiki/index.php?title=%E5%BE%AE%E4%BF%A1%E5%B0%8F%E5%BA%97%E6%8E%A5%E5%8F%A3
    /// </summary>
    public static class WeixinShopPicture
    {

        public static PictureResult GetByIdOrder(string accessToken, string fileName)
        {
            var urlFormat = "https://api.weixin.qq.com/merchant/common/upload_img?access_token={0}&filename={1}";
            var url = string.IsNullOrEmpty(accessToken) ? urlFormat : string.Format(urlFormat, accessToken, fileName);

            var json=new PictureResult();

            using (var fs = CQCMXY.Weixin.Helpers.FileHelper.GetFileStream(fileName))
            {
                var jsonText = CQCMXY.Weixin.HttpUtility.RequestUtility.HttpPost(url, null, fs);
                json = CQCMXY.Weixin.HttpUtility.Post.GetResult<PictureResult>(jsonText);
            }
            return json;
        }
    }
}