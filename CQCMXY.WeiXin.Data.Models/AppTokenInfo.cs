namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppTokenInfo")]
    public partial class AppTokenInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppTokenInfo()
        {
            AppInterfaceInfo = new HashSet<AppInterfaceInfo>();
            menus = new HashSet<menus>();
            NewMsgs = new HashSet<NewMsgs>();
        }

        [Key]
        public int Id { get; set; }

        [Timestamp]
        public Byte[] Timestamp { get; set; }
        [Required(ErrorMessage ="请填写应用标题")]
        [StringLength(50)]
        public string AppTitle { get; set; }

        [Required]
        [StringLength(150)]
        public string appID { get; set; }

        [Required]
        [StringLength(150)]
        public string appsecret { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppInterfaceInfo> AppInterfaceInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<menus> menus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewMsgs> NewMsgs { get; set; }
    }
}
