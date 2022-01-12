using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeanOffice.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public double Rate { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
