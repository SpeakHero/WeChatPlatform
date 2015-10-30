using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQCMXY.WeiXin.Data.Models
{

    /// <summary>
    /// 账号信息
    /// </summary>
    public class WeiXinAccoutInfo
    {
        public string appID { get; set; } = "wxa83c84fb3ff3404a";

        public string appsecret { get; set; } = "645b72602a6b597d91576970df0ab70f";


        public string Token { get; set; } = "cqcmxyWeiXindev";
        public string EncodingAESKey { get; set; }= "cqcmxyWeiXindev";
    }
}
