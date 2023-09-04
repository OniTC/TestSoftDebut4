using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using TestSoftDebut4.Models;
using TestSoftDebut4.Data;

namespace TestSoftDebut4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public HomeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<EmployeeModel> employeeList = _db.Employee.ToList();

            return View(employeeList);
        }

    }
}
