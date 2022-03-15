namespace coreNXTProtoV1.Models
{
    public class CategorySearchAttributesDTO
    {
        public int CategoryId { get; set; }
        //bigint(20)
        public Int64 AttributeId { get; set; }
        public byte IsActive { get; set; }
        public byte IsPreferred { get; set; }
        //datetime.now may be
        public DateTime LastUpdated { get; set; }

    }
}