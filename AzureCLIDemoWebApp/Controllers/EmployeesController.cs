using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureCLIDemoWebApp.DataAccessLayer;
using AzureCLIDemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureCLIDemoWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly CompanyDbContext _context;
        public EmployeesController(CompanyDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> list =
                await _context.Employees.ToListAsync();
            if (list == null)
                list = new List<Employee>();
            return View(list);
        }

    }
}