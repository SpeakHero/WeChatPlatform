using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CQCMXY.WeiXin.Utilities;
using Cqcmxy.Common.Web;

namespace CQCMXY.WeiXin.MP.Entities
{

    /// <summary>
    /// 百度orc识别
    /// </summary>
    public class BaiduORC
    {
        public string apikey { get; set; } = "f00a6402ab6b2336032f81bfbe9c024b";

        private readonly string url = "http://apis.baidu.com/apistore/idlocr/ocr";

        /// <summary>
        /// 发送HTTP请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数</param>
        /// <returns>请求结果</returns>
        public string ExResult(BodyParam param = null)
        {
            param = param == null ? new BodyParam() : param;

            HttpClient httpclient = new HttpClient(url);
            httpclient.PostingData.Add("apikey", apikey);
            httpclient.PostingData.Add("fromdevice", param.fromdevice);
            httpclient.PostingData.Add("clientip", param.clientip);
            httpclient.PostingData.Add("detecttype", param.detecttype);
            httpclient.PostingData.Add("languagetype", param.languagetype);
            httpclient.PostingData.Add("imagetype", param.imagetype);
            httpclient.PostingData.Add("image", param.image);
            httpclient.RequestHeaders.Add("apikey", apikey);
            string res = httpclient.GetString();
            httpclient.Reset();
            return res;
        }


        public class ResponseBody
        {

            public string errNum { get; set; }
            public string errMsg { get; set; }
            public string querySign { get; set; }

            public RetData retData { get; set; }


        }
        public struct RetData
        {
            public string word { get; set; }
            public Rect rect { get; set; }
        }
        public struct Rect
        {
            public string left { get; set; }

            public string top { get; set; }
            public string width { get; set; }

            public string height { get; set; }
        }
        public class BodyParam
        {

            /// <summary>
            /// 来源，例如：android、iPhone、pc等
            /// </summary>
            public string fromdevice { get; set; } = "pc";

            /// <summary>
            /// 客户端出口IP
            /// </summary>
            public string clientip { get; set; } = "10.10.10.10";
            /// <summary>
            /// OCR接口类型，“LocateRecognize”；“Recognize”；“Locate”；“SingleCharRecognize”。LocateRecognize:整图文字检测、识别,以行为单位;Locate:整图文字行定位;Recognize:整图文字识别;SingleCharRecognize:单字图像识别
            /// </summary>
            public string detecttype { get; set; } = "LocateRecognize";

            /// <summary>
            /// 要检测的文字类型:目前支持 1. CHN_ENG(中英) 2. ENG 3.JAP(日文) 4.KOR(韩文) ，不填写这个字段默认为CHN_ENG
            /// </summary>
            public string languagetype { get; set; } = "CHN_ENG";

            /// <summary>
            /// 图片资源类型, 1.表示经过BASE64编码后的字串，然后需要经过urlencode处理(特别重要)；2.图片原文件
            /// </summary>
            public string imagetype { get; set; } = "1";

            /// <summary>
            /// 图片资源，目前仅支持jpg格式，原始图片size需小于300k （Base64String）
            /// </summary>
            public string image { get; set; } = "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDABMNDxEPDBMREBEWFRMXHTAfHRsbHTsqLSMwRj5KSUU+RENNV29eTVJpU0NEYYRiaXN3fX59S12Jkoh5kW96fXj/2wBDARUWFh0ZHTkfHzl4UERQeHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHh4eHj/wAARCAAfACEDAREAAhEBAxEB/8QAGAABAQEBAQAAAAAAAAAAAAAAAAQDBQb/xAAjEAACAgICAgEFAAAAAAAAAAABAgADBBESIRMxBSIyQXGB/8QAFAEBAAAAAAAAAAAAAAAAAAAAAP/EABQRAQAAAAAAAAAAAAAAAAAAAAD/2gAMAwEAAhEDEQA/APawEBAQEBAgy8i8ZTVV3UY6V1eU2XoWDDZB19S646Gz39w9fkKsW1r8Wm2yo1PYis1be0JG9H9QNYCAgc35Cl3yuVuJZl0cB41rZQa32dt2y6OuOiOxo61vsLcVblxaVyXD3hFFjL6La7I/sDWAgICAgICB/9k=";
        }
    }
}
