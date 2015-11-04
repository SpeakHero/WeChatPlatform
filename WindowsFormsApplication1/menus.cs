namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
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

        public int Id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        public int AppTokenInfoId { get; set; }

        public int pid { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        public int Action { get; set; }

        public int MenusButtonActionId { get; set; }

        public virtual AppTokenInfo AppTokenInfo { get; set; }

        public virtual MenusButtonActions MenusButtonActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewMsgs> NewMsgs { get; set; }
    }
}
