using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    [Keyless]
    public class CategoryDisplayAttributes
    {
        // Int(11) 
        public int CategoryId { get; set; }
        // Bigint(20)  
        public Int64 AttributeId { get; set; }
        public int HeaderId { get; set; }
        public byte IsActive { get; set; }
        // Int(11)
        public int TemplateType { get; set; }
        // Int(11)
        public int DefaultDisplayOrder { get; set; }
        // Int(11)
        public int DisplayOrder { get; set; }

        public DateTime LastUpdated { get; set; }
        

    }
}
