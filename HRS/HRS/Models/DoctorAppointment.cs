using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.Models
{
    public class DoctorAppointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int TimeId { get; set; }
    }
}
