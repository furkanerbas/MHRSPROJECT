using MHRS303EntityLayer.Enums;
using MHRS303EntityLayer.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Models
{

    [Table("Appointments")]
    public class Appointment : Base<int>
    {
        public string PatientId { get; set; } //betül
        public int HospitalClinicId { get; set; } //100--> Hastane,Klinik,Doktor gelecek
        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; } //27 mayıs
        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Randevu saati XX:XX şeklinde olmalıdır!")]
        public string AppointmentHour { get; set; } //10:00
        public AppointmentStatus AppointmentStatus { get; set; } //Aktif
        [ForeignKey("PatientId")]
        public virtual AppUser Patient { get; set; }
        [ForeignKey("HospitalClinicId")]
        public virtual HospitalClinic HospitalClinic { get; set; }
    }

}
