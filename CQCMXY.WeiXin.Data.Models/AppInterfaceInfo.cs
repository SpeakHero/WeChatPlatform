namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
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
        [Required(ErrorMessage = "«Î—°‘Ò”¶”√")]
        public int AppTokenId { get; set; }
        [Timestamp]
        public Byte[] Timestamp { get; set; }
        [Required]
        [StringLength(250)]
        public string JSDomain { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }
    }
}
