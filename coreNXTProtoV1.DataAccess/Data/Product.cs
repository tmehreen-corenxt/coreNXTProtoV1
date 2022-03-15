using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class Product
    {

        [Key]
        //Int(11) 
        public int ProductId { get; set; }
        
        // Int(11)
        public int ManufacturerId { get; set; }

        public byte IsActive { get; set; }

        [StringLength(70)]
        public string MfgPartNo { get; set; } = null!;
        //Int(11)
        public int CategoryId { get; set; }
        public byte IsAccessory { get; set; }
        public double Equivalency { get; set; }
        public DateTime CreationDate { get; set; }    
        public DateTime ModifiedDate { get; set; }  
        //datetime.now may be 
        public DateTime LastUpdated { get; set; }
       
    }
}
