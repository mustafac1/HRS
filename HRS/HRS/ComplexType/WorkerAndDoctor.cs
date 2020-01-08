using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.ComplexType
{
    public class WorkerAndDoctor
    {
        public int WorkerId { get; set; }
        public int ClinicId { get; set; }
        public string Rank { get; set; }
        public bool Status { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}