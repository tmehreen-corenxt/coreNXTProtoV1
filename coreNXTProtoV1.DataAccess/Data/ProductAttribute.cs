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
    public class ProductAttribute
    {
        //max length 11
        public int ProductId { get; set; }

        //max length 20
        public Int64 AttributeId { get; set; }

        //max length 11
        public int CategoryId { get; set; }
        public string DisplayValue { get; set; } = null!;
        public double AbsoluteValue { get; set; }
        //max length 11--Foreign key to the unit table 

        public int UnitId { get; set; }
        public byte IsAbsolute { get; set; }
        public byte IsActive { get; set; }
        //max length 11
        public int LocaleId { get; set; }
        



    }
}
