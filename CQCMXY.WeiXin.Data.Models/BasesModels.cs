using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQCMXY.WeiXin.Data.Models
{
    public class BasesModels
    {
        [Timestamp]
      
        public Byte[] Timestamp { get; set; }
    }
}
