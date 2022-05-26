using MHRS303EntityLayer.Enums;
using MHRS303EntityLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.IdentityModels
{ 
    [Index(nameof(TcNumber),IsUnique =true)]  // Aynı tc'den tekrar girilemesin diye Tc'yi unique olarak tanımladık!
    public class AppUser : IdentityUser
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İsim en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "İsim alanı gereklidir")]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyisim en az 2 en çok 50 karakter olmalıdır!")]
        [Required(ErrorMessage = "Soyisim alanı gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "TcKimlik gereklidir!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TcKimlik numarası 11 karakter olmalıdır!")]
        public string TcNumber { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string Picture { get; set; }
        public DateTime? BirthDate { get; set; }
        public Genders Gender { get; set; }

    }
}
