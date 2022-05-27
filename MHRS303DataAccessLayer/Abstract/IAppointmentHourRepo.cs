using MHRS303EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303DataAccessLayer.Abstract
{
    public interface IAppointmentHourRepo : IBaseRepository<AppointmentHour,int>
    {
    }
}
