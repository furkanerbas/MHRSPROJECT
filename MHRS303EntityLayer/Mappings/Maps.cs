using AutoMapper;
using MHRS303EntityLayer.Models;
using MHRS303EntityLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Mappings
{
  public  class Maps :Profile
    {
        public Maps()
        {
            //Appointment nesnesini viewmodele dönüştürdü
            //CreateMap<Appointment, AppointmentViewModel>();
            //CreateMap<AppointmentViewModel, Appointment>();

            //Yukarıdaki 2 satırı tek seferde yapabiliyor.
            //Appointment -->> viewmodel
            //AppointmentViewModel --> appointmenta dönüşebilir
            CreateMap<Appointment, AppointmentViewModel>()
                .ReverseMap();
            CreateMap<City, CityViewModel>()
                .ReverseMap();
            CreateMap<District, DistrictViewModel>()
               .ReverseMap();
            CreateMap<Clinic, ClinicViewModel>()
               .ReverseMap();
            CreateMap<Hospital, HospitalViewModel>()
               .ReverseMap();
            CreateMap<HospitalClinic, HospitalClinicViewModel>()
               .ReverseMap();
            CreateMap<AppointmentHour, AppointmentHourViewModel>()
               .ReverseMap();
        }
    }
}
