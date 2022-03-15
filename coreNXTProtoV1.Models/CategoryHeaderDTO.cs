namespace coreNXTProtoV1.Models
{
    public class CategoryHeaderDTO
    {
        //Int(11)
        public int CategoryId { get; set; }
        //int11
        public int HeaderId { get; set; }

        public byte IsActive { get; set; }
        //Int(11) 
        public int TemplateType { get; set; }
        //Int(11)
        public int DefaultDisplayOrder { get; set; }
        //Int(11) 
        public int DisplayOrder { get; set; }
        //datetime.now may be
        public DateTime LastUpdated { get; set; }


    }
}