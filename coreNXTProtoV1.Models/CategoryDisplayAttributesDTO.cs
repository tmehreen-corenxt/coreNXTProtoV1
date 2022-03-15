namespace coreNXTProtoV1.Models
{
    public class CategoryDisplayAttributesDTO
    {
        // Int(11) 
        public int CategoryId { get; set; }
        // Bigint(20)  
        public Int64 AttributeId { get; set; }
        public int HeaderId { get; set; }
        public byte IsActive { get; set; }
        // Int(11)
        public int TemplateType { get; set; }
        // Int(11)
        public int DefaultDisplayOrder { get; set; }
        // Int(11)
        public int DisplayOrder { get; set; }

        public DateTime LastUpdated { get; set; }


    }
}