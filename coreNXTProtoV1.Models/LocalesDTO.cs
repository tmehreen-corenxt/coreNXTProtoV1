using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class LocalesDTO
    {
        public int LocaleId { get; set; }
        public byte IsActive { get; set; }
        [StringLength(5)]
        public string LanguageCode { get; set; } = null!;
        [StringLength(5)]
        public string Countrycode { get; set; } = null!;
        [StringLength(8)]
        public string Name { get; set; } = null!;
    }
}