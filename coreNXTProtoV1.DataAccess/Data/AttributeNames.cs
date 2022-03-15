using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class AttributeNames
    {
        [Key]
        public Int64 AttributeId {get;set; }
        [StringLength(110)] 
        public string Name { get; set; } = null!;
        public int LocaleId { get; set; }
        
    }
}
