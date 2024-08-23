using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Model
{
    public class CourseInst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string Evaluate { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
