using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class HeaderNamesDTO
    {
        public int HeaderId { get; set; }
        [StringLength(80)]
        public string Name { get; set; } = null!;
        //Int(11) 
        public int LocaleId { get; set; }

    }
}