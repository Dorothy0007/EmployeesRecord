using EmployeesRecord.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRecord.DAL
{
    public class EmployeeRepository
    {
        private EmployeeRecordDbContext _context;

        public EmployeeRepository(EmployeeRecordDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee Get(int id)
        {
            Employee result = _context.Employees.Find(id);

            return result;
        }

        public bool Delete(int id)
        {
            var result = _context.Employees.Find(id);

            _context.Remove(result);

            return true;
        }
    }
}
