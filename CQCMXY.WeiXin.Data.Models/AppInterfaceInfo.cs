﻿namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppInterfaceInfo")]
    public partial class AppInterfaceInfo
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string Token { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [Required]
        [StringLength(250)]
        public string JSDomain { get; set; }
        [Required(ErrorMessage = "请选择公众号")]
        [DisplayName("公众号")]
        public int AppTokenInfoId { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }
    }
}
