namespace coreNXTProtoV1.Models
{
    public class Mapped_Category_TaxonomyDTO
    {
        public int CategoryId { get; set; }

        //is it foreign key to category table
        public int ParentCategoryId { get; set; }

    }
}