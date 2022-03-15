using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace coreNXTProtoV1.DataAccess.Data
{
    public class CategorySearchAttributes
    {
        [Key]//int(11)
        public int CategoryId { get; set; }
        //bigint(20)
        public Int64 AttributeId { get; set; }
        public byte IsActive { get; set; }
        public byte IsPreferred { get; set; }
       //datetime.now may be
        public DateTime LastUpdated { get; set; }


    }
}
