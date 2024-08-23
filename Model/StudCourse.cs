using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Model
{
    public class StudCourse
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
