using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQCMXY.WeiXin.WebServer.Controllers
{
    public class UpLoadDataController : BasesController
    {


        // GET: Admin/UpLoadData
        public JsonResult Index(string dir = "image")
        {
            ///文件保存目录路径
            String savePath = "/attached/";
            //文件保存目录URL
            String saveUrl = "/attached/";
            //定义允许上传的文件扩展名
            Hashtable extTable = new Hashtable();
            extTable.Add("image", "gif,jpg,jpeg,png,bmp");
            extTable.Add("flash", "swf,flv");
            extTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
            extTable.Add("file", "doc,docx,xls,xlsx,ppt,htm,html,txt,zip,rar,gz,bz2");
            //string message = string.Empty;
            //bool cheack=false;
            var files = Request.Files;
            if (files.Count > 0)
            {
                //最大文件大小
                int maxSize = 1000000;

                var imgFile = files[0];
                if (imgFile == null)
                {
                    return showError("请选择文件。");
                }
                String dirPath = Server.MapPath(savePath);
                if (!Directory.Exists(dirPath))
                {
                    return showError("上传目录不存在。");
                }
                if (!extTable.ContainsKey(dir))
                {
                    return showError("目录名不正确。");
                }
                String fileName = imgFile.FileName;
                String fileExt = Path.GetExtension(fileName).ToLower();

                if (imgFile.InputStream == null || imgFile.InputStream.Length > maxSize)
                {
                    return showError("上传文件大小超过限制。");
                }

                if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(((String)extTable[dir]).Split(','), fileExt.Substring(1).ToLower()) == -1)
                {
                    return showError("上传文件扩展名是不允许的扩展名。\n只允许" + ((String)extTable[dir]) + "格式。");
                }

                //创建文件夹
                dirPath += dir + "/";
                saveUrl += dir + "/";
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                String ymd = DateTime.Now.ToString("yyyyMMdd", DateTimeFormatInfo.InvariantInfo);
                dirPath += ymd + "/";
                saveUrl += ymd + "/";
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                String newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_ffff", DateTimeFormatInfo.InvariantInfo) + fileExt;
                String filePath = dirPath + newFileName;
                imgFile.SaveAs(filePath);
                String fileUrl = saveUrl + newFileName;
                return Json(new { error = 0, url = fileUrl }, JsonRequestBehavior.AllowGet);
            }
            return showError("请选择文件。");
        }
        public JsonResult showError(string message)
        {
            return Json(new { error = 1, message = message }, JsonRequestBehavior.AllowGet);
        }


    }
}