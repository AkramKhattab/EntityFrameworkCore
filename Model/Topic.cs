using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Model
{
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<Course> Courses { get; set; }
    }
}
