namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewMsgs
    {

        [Key]
        public int Id { get; set; }

        public int AppTokenInfoId { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Contents { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpTime { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        public int meunsId { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }

        public virtual menus menus { get; set; }
    }
}
