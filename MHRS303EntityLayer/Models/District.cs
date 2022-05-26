using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Models
{
   [Table("Districts")]
    public class District:Base<int>
    {
        [Required]
        [StringLength(50,MinimumLength =2, ErrorMessage ="İlçe adı en az 2 en çok 50 karakter olmalıdır!")]
        public string DistrictName { get; set; }
        public byte CityId { get; set; }
        //ilişki
        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public virtual ICollection<Hospital> Hospitals { get; set; }
    }
}
