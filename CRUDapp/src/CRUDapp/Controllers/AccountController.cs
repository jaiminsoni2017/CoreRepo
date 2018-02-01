using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Models;
using Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDapp.Controllers
{
    public class AccountController : Controller
    {
        IEmployeeService _employeeService;

        public AccountController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = _employeeService.ValidateEmployee(model);
                if (employee != null && employee.EmpID > 0)
                {
                    return RedirectToAction("Employees", "Account");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        // https://joonasw.net/view/attribute-routing-cheat-sheet-for-aspnet-core
        public IActionResult Add()
            => Ok();

        [HttpGet("account/list")]
        public IActionResult Employees()
        {
            var employees = _employeeService.GetAllEmployee();
            return View(employees);
        }

        [HttpGet("emp-get")]
        public IActionResult Edit()
            => Ok();
    }
}
