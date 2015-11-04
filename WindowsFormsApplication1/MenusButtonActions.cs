namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MenusButtonActions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenusButtonActions()
        {
            menus = new HashSet<menus>();
        }

        public int Id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionType { get; set; }

        [Required]
        [StringLength(50)]
        public string Actiondes { get; set; }

        [Required]
        [StringLength(350)]
        public string ActionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<menus> menus { get; set; }
    }
}
