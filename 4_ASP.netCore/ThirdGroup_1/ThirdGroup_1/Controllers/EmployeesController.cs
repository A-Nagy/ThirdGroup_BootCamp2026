using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

            IEnumerable<Employee> empdata = 
                _context.Employees.Include(e=>e.Department).ToList();

            return View(empdata); 
        }
        [HttpGet]
        public IActionResult Details(int Id) 
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
            Employee? employee = _context.Employees.Find(Id);

            return View(employee);
        }

        [HttpGet]
        public IActionResult Insert() 
        {
            return View(); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
              return View(employee);

        }
        [HttpGet]
        public IActionResult Update(int Id) 
        {
            Employee? employee = _context.Employees.Find(Id);
            if (employee == null) 
            {
            return NotFound();//like 404 error
            }
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee employee)
        {  if (ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
              return View(employee);
           
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Employee? employee = _context.Employees.Find(Id);
            if (employee == null)
            {
                return NotFound();//like 404 error
            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        { 
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Search() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string name)
        {
            if (name.IsNullOrEmpty()) 
            {
                return NotFound();
            }
            Employee? emp = _context.Employees.FirstOrDefault(d=> name == d.EmployeeName);

            return RedirectToAction("Details", new { id = emp.EmployeeId });
            //return RedirectToAction("Details", emp.EmployeeId);
        }

    }
}
