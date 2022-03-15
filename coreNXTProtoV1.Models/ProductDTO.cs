using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class ProductDTO
    {
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