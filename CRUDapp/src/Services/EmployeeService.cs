using Entities;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly TestDbContext _context;
        public EmployeeService(TestDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            using (_context)
            {
                return _context.Employee.ToList();
            }
        }
        public Employee ValidateEmployee(LoginViewModel model)
        {
            using (_context)
            {
                var employee = _context.Employee.Where(x => x.Email == model.Email && x.EmpPassword == model.Password).FirstOrDefault();
                return employee;
            }
        }
    }
}
