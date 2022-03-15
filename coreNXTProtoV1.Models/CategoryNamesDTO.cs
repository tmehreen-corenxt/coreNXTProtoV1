using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class CategoryNamesDTO
    {
        public int CategoryId { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        //int(11) 
        public int LocaleId { get; set; }

    }
}