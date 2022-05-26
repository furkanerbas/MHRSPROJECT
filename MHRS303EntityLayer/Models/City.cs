using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Models
{
    [Index(nameof(PlateCode),IsUnique =true)] //plaka kodunun tekrar etmemesi
    //unique olması
    [Table("Cities")]
    public class City : Base<byte> //iller tablosunun PK'sı byte tipinde olsun. Çünkü Türkiyede 81 il var.
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "İl adı en az 3 en çok 50 karakter aralığında olmalıdır!")]
        public string CityName { get; set; }
        [Required]
        public byte PlateCode { get; set; }

        //ilişkinin karşılığı
        //1 ilin 1-den çok ilçesi olabilir.
        public virtual ICollection<District> Districts { get; set; }
        
    }
}
