using EmployeesRecord.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesRecord.DAL
{
    public class EmployeeRecordDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
