using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class Mapped_Category_Taxonomy
    {
        [Key]
        public int CategoryId { get; set; }

        //is it foreign key to category table
        public int ParentCategoryId { get; set; }
    }
}
