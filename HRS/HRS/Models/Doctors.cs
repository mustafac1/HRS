using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.Models
{
    public class Doctors
    {
        private bool? _status;
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public int ClinicId { get; set; }
        public string Rank { get; set; }
        public bool Status
        {
            get => _status ??true;
            set => _status = value;
        }
    }
}
