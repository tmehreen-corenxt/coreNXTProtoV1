using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class Mapped_Category_NamesDTO
    {
        public int CategoryId { get; set; }
        //int 11---ask if it is foreign key to locales
        public int LocaleId { get; set; }
        [StringLength(80)]
        public string Name { get; set; } = null!;


    }
}