using System.ComponentModel.DataAnnotations;

namespace coreNXTProtoV1.Models
{
    public class ManufacturerDTO
    {
        public int ManufacturerId { get; set; }
        [StringLength(60)]
        public string Name { get; set; } = null!;
        [StringLength(60)]
        public string Address1 { get; set; } = null!;
        [StringLength(60)]
        public string Address2 { get; set; } = null!;
        [StringLength(30)]
        public string City { get; set; } = null!;
        [StringLength(10)]
        public string Zip { get; set; } = null!;
        [Url]
        [StringLength(100)]
        public string Url { get; set; } = null!;
        [Phone]
        [StringLength(20)]
        public string Phone { get; set; } = null!;
        [StringLength(20)]
        public string Fax { get; set; } = null!;
        [StringLength(20)]
        public string Country { get; set; } = null!;
        [StringLength(60)]
        public string State { get; set; } = null!;
        //datetime.now may be
        public DateTime LastUpdated { get; set; }

    }
}