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
    public class ProductAccessories
    {

        //Int(11)
        public int ProductId { get; set; }
        // Int(11) 

        public int? AccessoryProductId { get; set; }
        public Product? AccessoryProduct { get; set; }

        public byte IsActive { get; set; }
   
        public byte IsPreferred { get; set; }
        public byte IsOption { get; set; }
        public string Note { get; set; } = null!;
        public float Recommendation_Weight { get; set; }
       


    }
}
