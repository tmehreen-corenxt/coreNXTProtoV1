using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    [Keyless]
    public class Mapped_Category_Names
    {

       //int 11---ask if it is foreign key to mapped cat taxonomy
        public int CategoryId { get; set; }
       //int 11---ask if it is foreign key to locales
        public int LocaleId { get; set; }
       [StringLength(80)]
       public string Name { get; set; } = null!;
    }
}
