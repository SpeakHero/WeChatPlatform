using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQCMXY.WeiXin.Data.Models
{
    public class MenusButtonAction
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenusButtonAction()
        {
            menus = new HashSet<menus>();
        }

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] Timestamp { get; set; }
        
        [DisplayName("动作方法")]
        [Required]
        [StringLength(50)]
        public string ActionType { get; set; }
        [DisplayName("动作说明")]
        [Required]
        [StringLength(50)]
        public string Actiondes { get; set; }
        [DisplayName("动作解释")]
        [Required]
        [StringLength(350)]
        public string ActionDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<menus> menus { get; set; }
    }
}
