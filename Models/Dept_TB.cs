using System;
using System.Collections.Generic;

namespace POCO.Models
{
    public partial class Dept_TB
    {
        public Dept_TB()
        {
            this.Emp_TB = new List<Emp_TB>();
        }

        public int dept_no { get; set; }
        public string dept_name { get; set; }
        public string dept_location { get; set; }
        public virtual ICollection<Emp_TB> Emp_TB { get; set; }
    }
}
