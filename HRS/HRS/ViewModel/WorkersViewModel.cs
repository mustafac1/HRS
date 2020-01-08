using HRS.ComplexType;
using HRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRS.ViewModel
{
    public class WorkersViewModel
    {
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

        public List<Roles> Roles { get; set; }
        public List<Workers> Workers { get; set; }
        public List<WokerAndRoles> WokerAndRoles { get; set; }
    }
 
}
