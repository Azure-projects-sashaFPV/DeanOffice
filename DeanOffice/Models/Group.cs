using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeanOffice.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
    }
}
