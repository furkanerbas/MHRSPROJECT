using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303EntityLayer.Enums
{
    public class AllEnums
    {
    }
     public enum Genders : byte
    {
        Unknown,
        Woman,
        Man
    }

    public enum AppointmentStatus: byte
    {
        Past,
        Active,
        Cancelled
    }

    public enum MHRSRoles: byte
    {
        Passive,
        Admin,
        Patient,
        PassiveDoctor,
        ActiveDoctor
    }





}
