using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class AttributeNamesDTO
    {
        public Int64 AttributeId { get; set; }
        [StringLength(110)]
        public string Name { get; set; } = null!;
        public int LocaleId { get; set; }


    }
}