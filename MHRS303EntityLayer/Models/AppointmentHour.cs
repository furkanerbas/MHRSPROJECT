using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Models
{
    [Table("AppointmentHours")]
    public class AppointmentHour : Base<int>
    {
        public int HospitalClinicId { get; set; } // Hastane,Klinik,Doktor

        [Required]
        public string Hours { get; set; } //09:30,09:45,10:30,10:50,14:00,14.15

        [ForeignKey("HospitalClinicId")]
        public virtual HospitalClinic HospitalClinic { get; set; }
    }
}
