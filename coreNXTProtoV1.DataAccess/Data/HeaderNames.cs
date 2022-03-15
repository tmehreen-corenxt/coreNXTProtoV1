using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class HeaderNames
    {
        //int11
        [Key]
        public int HeaderId { get; set; }
        [StringLength(80)]
        public string Name { get; set; } = null!;
        //Int(11) 
        public int LocaleId { get; set; }
        
    }
}
