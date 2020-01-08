using HRS.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.ViewModel
{
    public class AppointmentViewModel
    {
        public List<WorkerAndDoctor> GetDoctors { get; set; }

        public List<Models.Times> GetTimes { get; set; }

    }
}
