﻿using Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployeeService
    {
        Employee ValidateEmployee(LoginViewModel model);
        IEnumerable<Employee> GetAllEmployee();
    }
}
