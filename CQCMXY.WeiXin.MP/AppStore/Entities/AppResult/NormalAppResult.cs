/*----------------------------------------------------------------
    Copyright (C) 2015 CQCMXY
  
    文件名：NormalAppResult.cs
    文件功能描述：普通API返回类型
    
    
    创建标识：CQCMXY - 20150319
----------------------------------------------------------------*/

namespace CQCMXY.Weixin.MP.AppStore
{
    /// <summary>
    /// 普通API返回类型
    /// </summary>
    public class NormalAppResult : AppResult<NormalAppData>
    {

    }

    public class NormalAppData : IAppResultData
    {
        public object Object { get; set; }
    }
}
