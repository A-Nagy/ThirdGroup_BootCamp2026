using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;
using ThirdGroup_1.Repositories.EmployeeRepository;
using ThirdGroup_1.Security;

namespace ThirdGroup_1.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {

      //private readonly AppDbContext _context ;
      //private readonly IRepository<Department> _Deptrepo;
     // private readonly IRepository<Employee> _repository;
     // private readonly IEmployeeRepository _employeeRepository ;
     private readonly IUnitOfWork _unitOfWork;
        public EmployeesController(IUnitOfWork unitOfWork)
        {
         //   _context = context; 
         //   _employeeRepository = employeeRepository;
         //   _Deptrepo = Deptrepo;

            _unitOfWork = unitOfWork;
        }

        [Authorize(Policy =PermissionsNames.EmployeesView)]
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

            //IEnumerable<Employee> empdata = _context.Employees.Include(e =>e.Department).ToList();
            var empdate = _unitOfWork.Employees.GetAllWithDepartments();

            return View(empdate); 
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
             //Employee? employee = _context.Employees.Find(Id);
            
            return View(_unitOfWork.Employees.GetById(Id));

        }

        [Authorize(Policy = PermissionsNames.EmployeesCreate)]

        [HttpGet]
        public IActionResult Insert() 
        {

            LoadDepartents();
            return View(); 
        }

        [Authorize(Policy = PermissionsNames.EmployeesCreate)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Employee employee)
        {
            if(ModelState.IsValid)
            {
                //_context.Employees.Add(employee);
                //_context.SaveChanges();
                _unitOfWork.Employees.Create(employee);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
          LoadDepartents();
            return View(employee);

        }

        [Authorize(Policy =PermissionsNames.EmployeesEdit)]
        [HttpGet]
        public IActionResult Update(int Id) 
        {
            Employee? employee = _unitOfWork.Employees.GetById(Id);
            // _context.Employees.Find(Id);
            if (employee == null) 
            {
              return NotFound();//like 404 error
            }
            LoadDepartents();
            return View(employee);
        }
        [Authorize(Policy = PermissionsNames.EmployeesEdit)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee employee)
        {  if (ModelState.IsValid)
            {
                //_context.Employees.Update(employee);
                //_context.SaveChanges();
                _unitOfWork.Employees.Update(employee);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            LoadDepartents();
            return View(employee);
           
        }

        [Authorize(Policy = PermissionsNames.EmployeesDelete)]
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Employee? employee = _unitOfWork.Employees.GetById(Id);
            //Employee? employee = _context.Employees.Find(Id);
            if (employee == null)
            {
                return NotFound();//like 404 error
            }
            return View(employee);
        }
        [Authorize(Policy = PermissionsNames.EmployeesDelete)]
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _unitOfWork.Employees.Delete(employee);
            _unitOfWork.Save();
            //_context.Employees.Remove(employee);
            //_context.SaveChanges();
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
            //Employee? emp = _context.Employees.FirstOrDefault(d=> name == d.EmployeeName);
            Employee emp = _unitOfWork.Employees.GetEmployeebyName(name); 
            return RedirectToAction("Details", new { id = emp.EmployeeId });
            //return RedirectToAction("Details", emp.EmployeeId);
        }
        private void LoadDepartents()
        {/*_context.Department.ToList()*/
            IEnumerable<Department> departments  = _unitOfWork.Departments.GetAll() ;
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
        }

    }
}
