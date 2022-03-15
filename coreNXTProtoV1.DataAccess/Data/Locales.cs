using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreNXTProtoV1.DataAccess.Data
{
    public class Locales
    {
        [Key]
        //Int(11) 
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
