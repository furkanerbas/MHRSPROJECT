using MHRS303EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.ViewModels
{
   public class DistrictViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İlçe adı en az 2 en çok 50 karakter olmalıdır!")]
        public string DistrictName { get; set; }
        public int CityId { get; set; }      
        public  CityViewModel City { get; set; }
        public  ICollection<HospitalViewModel> Hospitals { get; set; }
    }
}
