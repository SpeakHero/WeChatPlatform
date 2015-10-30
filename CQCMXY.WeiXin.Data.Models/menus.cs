namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class menus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public menus()
        {
            NewMsgs = new HashSet<NewMsgs>();
        }
        [Timestamp]

        public Byte[] Timestamp { get; set; }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "请选择公众号")]
        [DisplayName("公众号")]
        public int AppTokenInfoId { get; set; }
        [DisplayName("上一级菜单")]
        [Required]
        [StringLength(10)]
        public string pid { get; set; }
        [DisplayName("菜单标题")]
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [DisplayName("执行方法")]
        [Required]
        [StringLength(50)]
        public string Action { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewMsgs> NewMsgs { get; set; }
    }
    public enum MenusActionType
    {
        /// <summary>
        /// 点击推事件
        /// </summary>
        click,
        /// <summary>
        /// 跳转URL
        /// </summary>
        view,
        /// <summary>
        /// 扫码推事件
        /// </summary>
        scancode_push,
        /// <summary>
        /// 扫码推事件且弹出“消息接收中”提示框
        /// </summary>
        scancode_waitmsg,
        /// <summary>
        /// 弹出系统拍照发图
        /// </summary>
        pic_sysphot,
        /// <summary>
        /// 弹出拍照或者相册发图
        /// </summary>
        pic_photo_or_album,
        /// <summary>
        /// 弹出微信相册发图器
        /// </summary>
        pic_weixin,
        /// <summary>
        /// 弹出地理位置选择器
        /// </summary>
        location_select,
        /// <summary>
        /// 下发消息（除文本消息）
        /// </summary>
        media_id,

        /// <summary>
        /// 跳转图文消息URL
        /// </summary>
        view_limited
    }
}
