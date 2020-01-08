using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRS.Models;
using HRS.ComplexType;

namespace HRS.ViewModel
{
    public class MakeAnAppointmentViewModel
    {
        
        public MakeAnAppointmentViewModel()
        {
            TransactionDate = DateTime.Now;
        }
        
        public int ClinicId { get; set; }
        public int DoctorId { get; set; }
        public int TimeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public List<Clinic> clinics { get; set; }
        public List<WorkerAndDoctor> workerAndDoctors { get; set; }
        
    }
}
