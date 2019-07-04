using System;
using System.Collections.Generic;

namespace POCO.Models
{
    public partial class Emp_TB
    {
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public Nullable<int> mgr_emp_id { get; set; }
        public int dept_no { get; set; }
        public virtual Dept_TB Dept_TB { get; set; }
    }
}
