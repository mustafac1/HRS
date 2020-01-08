using HRS.ComplexType;
using HRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.ViewModel
{
    public class DoktorsViewModel
    {
        public List<Doctors> Doctors { get; set; }
        public List<Clinic> Clinics { get; set; }
        public List<WorkerAndDoctor> workerAndDoctors { get; set; }
        //public List<WokerAndRoles> WokerAndRoles { get; set; }
    }
}
