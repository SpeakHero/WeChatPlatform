/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
    
    文件名：GetMenuResult.cs
    文件功能描述：获取菜单返回的Json结果
    
    
    创建标识：CQCMXY - 20150211
    
    修改标识：CQCMXY - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQCMXY.WeiXin.Entities;
using CQCMXY.WeiXin.MP.Entities.Menu;

namespace CQCMXY.WeiXin.MP.Entities
{
    /// <summary>
    /// GetMenu返回的Json结果
    /// </summary>
    public class GetMenuResult : WxJsonResult
    {
        public ButtonGroup menu { get; set; }

        public GetMenuResult()
        {
            menu = new ButtonGroup();
        }
    }
}
