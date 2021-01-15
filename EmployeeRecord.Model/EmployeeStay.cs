using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmployeesRecord.Model
{
    public class EmployeeStay
    {
        [Key]
        public int Id { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public string Remark { get; set; }
        public string DepartureReason { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
