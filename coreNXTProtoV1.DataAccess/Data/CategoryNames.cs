using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace coreNXTProtoV1.DataAccess.Data
{
    public class CategoryNames
    {
        [Key]//int(11)
        public int CategoryId { get; set; }
       [StringLength(80)]
        public string? Name { get; set; }
        //int(11) 
        public int LocaleId { get; set; }


    }
}
