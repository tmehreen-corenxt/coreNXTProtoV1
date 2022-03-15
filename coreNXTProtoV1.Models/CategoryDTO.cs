namespace coreNXTProtoV1.Models
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }

        public byte IsActive { get; set; }
        public int OrderNumber { get; set; }
        public byte CatLevel { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}