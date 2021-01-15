using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeesRecord.Model
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public int DepartmentManagerId { get; set; }
        public virtual DepartmentManager DepartmentManager { get; set; }
    }
}
