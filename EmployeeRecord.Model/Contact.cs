using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeesRecord.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string PrivateEmail { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessTelephone { get; set; }
        public string BusinessMobilePhone { get; set; }
        public string PrivateMobilePhone { get; set; }
    }
}
