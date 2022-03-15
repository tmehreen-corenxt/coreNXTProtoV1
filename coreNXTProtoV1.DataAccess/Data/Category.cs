using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class Category
    {
        [Key]
        //Int(11)
        public int CategoryId { get; set; }
        //int11
        public int ParentCategoryId { get; set; }

        public byte IsActive { get; set; }
        //Int(11) 
        public int OrderNumber { get; set; }
        //
        public byte CatLevel { get; set; }
        //Int(11) 
        public int DisplayOrder { get; set; }
        //may be datetime.now
        public DateTime LastUpdated { get; set; }
        
        
    }
}
