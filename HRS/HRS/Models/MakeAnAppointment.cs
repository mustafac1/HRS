using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.Models
{
    public class MakeAnAppointment
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public int DoctorId { get; set; }
        public int TimeId { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
