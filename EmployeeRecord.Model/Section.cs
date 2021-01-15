using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeesRecord.Model
{
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        //[ForeignKey("DepartmentManager")]
        //public int DepartmentManagerId { get; set; }
        //public virtual DepartmentManager DepartmentManager { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
