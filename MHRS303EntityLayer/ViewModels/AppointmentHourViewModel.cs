using MHRS303EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.ViewModels
{
    public class AppointmentHourViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        public string Hours { get; set; }
        [Required]
        public int HospitalClinicId { get; set; }
        public  HospitalClinicViewModel HospitalClinic { get; set; }


    }
}
