using Microsoft.AspNetCore.Mvc;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;

namespace ThirdGroup_1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context ;

        public EmployeesController(AppDbContext context)
        {
            _context = context; 
        }

        [HttpGet]
        public IActionResult Index()
        {

            //ViewBag.EmployeeId    = 1;
            //ViewBag.EmployeeName  = "Ahmad";
            //ViewBag.EmployeeEmail = "Ahmad@abad.com";
            //ViewBag.EmployeePhone = "0001";

            //Employee employee = new Employee();

            //employee.EmployeeId = 1;
            //employee.EmployeeName = "Ahmad";
            //employee.EmployeeEmail = "Ahmad@abad.com";
            //employee.EmployeePhone = "0001";
            //employee.EmployeeAge = 25;
            //employee.EmployeeSalary = 5000.00m;
            //return View(employee);

            List<Employee> empdata = _context.Employees.ToList();

            return View(empdata); 
        }
        public IActionResult Details() 
        {

            //List<Employee> employees = new List<Employee>();

            //Employee employee1 = new Employee
            //{
            //    EmployeeId = 1,
            //    EmployeeName = "Ahmad",
            //    EmployeeEmail = "Ahmad@abad.com",
            //    EmployeeSalary = 5000
            //};
            //Employee employee2 = new Employee
            //{
            //    EmployeeId = 2,
            //    EmployeeName = "Ahmad",
            //    EmployeeEmail = "Ahmad@abad.com",
            //    EmployeeSalary = 5000
            //};
            //Employee employee3 = new Employee
            //{
            //    EmployeeId = 3,
            //    EmployeeName = "Ahmad",
            //    EmployeeEmail = "Ahmad@abad.com",
            //    EmployeeSalary = 5000
            //};
            //employees.Add(employee1);
            //employees.Add(employee2);
            //employees.Add(employee3);

            //return View(employees);

            return View();
        }

        [HttpGet]
        public IActionResult Insert() 
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Insert(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
