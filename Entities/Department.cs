﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        public string Address { get; set; }
    }
}
