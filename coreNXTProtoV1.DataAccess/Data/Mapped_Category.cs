using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class Mapped_Category
    {
       [Key] //int11
       public int ProductId { get; set; }
       //int 11----ask is it fk to mapped cat names?
       public int CategoryId { get; set; }

    }
}
