using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        // Navigation properties
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}
