
namespace coreNXTProtoV1.Models
{
    public class ProductAccessoriesDTO
    {
        //Int(11)
        public int ProductId { get; set; }
        // Int(11) 

        public int? AccessoryProductId { get; set; }
        /// <summary>
        /// look proudct or productdto 
        /// </summary>
        public ProductDTO? AccessoryProduct { get; set; }

        public byte IsActive { get; set; }

        public byte IsPreferred { get; set; }
        public byte IsOption { get; set; }
        public string Note { get; set; } = null!;
        public float Recommendation_Weight { get; set; }

    }
}