namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewMsgs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "必须选择隶属应用")]
        [DisplayName("隶属应用")]
        public int AppTokenInfoId { get; set; }

        [Required(ErrorMessage = "请填写文章标题")]
        [DisplayName("文章标题")]
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
        [DisplayName("文章内容")]
        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "文章内容不能为空")]
        public string Contents { get; set; }
        [DisplayName("创建时间")]
        public DateTime? CreateTime { get; set; } = DateTime.Now;
        [DisplayName("更新时间")]
        public DateTime? UpTime { get; set; } = DateTime.Now;
        [DisplayName("文章作者")]
        [StringLength(50)]
        public string Author { get; set; }
        [Required(ErrorMessage = "必须选择隶属栏目")]
        [DisplayName("隶属栏目")]
        public int meunsId { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }

        public virtual menus menus { get; set; }
    }
}
