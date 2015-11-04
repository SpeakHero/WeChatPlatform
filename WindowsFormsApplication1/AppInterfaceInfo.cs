namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppInterfaceInfo")]
    public partial class AppInterfaceInfo
    {
        public int Id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string URL { get; set; }

        [Required]
        [StringLength(50)]
        public string Token { get; set; }

        public int AppTokenId { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [Required]
        [StringLength(250)]
        public string JSDomain { get; set; }
        [Required]
        public int AppTokenInfo_Id { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }
    }
}
