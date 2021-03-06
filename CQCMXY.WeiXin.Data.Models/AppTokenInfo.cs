﻿namespace CQCMXY.WeiXin.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }

        [Required(ErrorMessage = "公众号名称必须填写")]
        [DisplayName("公众号名称")]
        [StringLength(50)]
        public string AppTitle { get; set; }

        [Required(ErrorMessage = "公众号appID必须填写")]
        [DisplayName("公众号appID")]
        [StringLength(150)]
        public string appID { get; set; }

        [Required(ErrorMessage = "公众号appsecret必须填写")]
        [DisplayName("公众号appsecret")]
        [StringLength(150)]
        public string appsecret { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppInterfaceInfo> AppInterfaceInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<menus> menus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewMsgs> NewMsgs { get; set; }

    }
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class UniqueAttribute : ValidationAttribute
    {
        public override Boolean IsValid(Object value)
        {
            
            return true;
        }
    }
}
