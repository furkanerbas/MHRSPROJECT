﻿using MHRS303EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.ViewModels
{
    public class HospitalViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(400, MinimumLength = 2, ErrorMessage = "Hastane adı en az 2 en çok 400 karakter olabilir!")]
        public string HospitalName { get; set; }
        [Required]
        public int DistrictId { get; set; }

        [StringLength(500, ErrorMessage = "Adres bilgisi en fazla 500 karakter olmalıdır!")]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Başında 0 olmadan 10 haneli olacak şekilde girilmelidir!")] //216XXXAABB
        public string PhoneNumber { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public  DistrictViewModel HospitalDistrict { get; set; }
        public  ICollection<HospitalClinicViewModel> HospitalClinics
        { get; set; }
    }
}
