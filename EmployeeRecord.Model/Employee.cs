using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesRecord.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public string MBO { get; set; }
        public bool Active { get; set; }
        public DateTime BirthDate { get; set; }
        [ForeignKey("Section")]
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<EmployeeStay> EmployeeStays { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

    }
}
