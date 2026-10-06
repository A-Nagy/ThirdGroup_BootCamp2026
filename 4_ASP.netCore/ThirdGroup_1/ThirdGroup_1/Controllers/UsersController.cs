using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdGroup_1.Data;
using ThirdGroup_1.Models;
using ThirdGroup_1.Repositories.Base;
using ThirdGroup_1.Repositories.Roles;
using ThirdGroup_1.Repositories.Users;

namespace ThirdGroup_1.Controllers
{
    public class UsersController : Controller
    {
        //private readonly AppDbContext _context;
        //private readonly IUserRepository _user;
        //private readonly IRoleRepository _role; 
        private readonly IUnitOfWork _unitOfWork;


        public UsersController(IUnitOfWork unitOfWork)
        {
            ////_context = context;
            //_user = repository;
            //_role = role;
            _unitOfWork = unitOfWork;
        }

        // GET: Users
        public IActionResult Index()
        {
            return View(_unitOfWork.Users.GetAll());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _unitOfWork.Users.GetById(id); 
                
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,UserName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Users.Create(user);
                _unitOfWork.Save();
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
//await _context.Users.FindAsync(id);
            var user = _unitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,UserName,Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(user);
                    //await _context.SaveChangesAsync();
                    _unitOfWork.Users.Update(user);
                    _unitOfWork.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
 //await _context.UsersFirstOrDefaultAsync(m => m.Id == id);
            var user =_unitOfWork.Users.GetById(id.Value);
             
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*await _context.Users.FindAsync(id);*/
           
            var user = _unitOfWork.Users.GetById(id);         
            
            _unitOfWork.Users.Delete(user);
            _unitOfWork.Save();

            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.Id == id);
        //}
        [HttpGet]
        public IActionResult AssignRole(int Id)
        {/*_context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);*/
            User? user = _unitOfWork.Users.GetUserWithRole(Id);
            if (user == null)
            {
                return NotFound();
            }

            /*_context.Roles.ToList();*/
            
            IEnumerable<Role> roles = _unitOfWork.Roles.GetAll();

            ViewBag.Roleslist = roles;

            ViewBag.AssignedRolesList = user.Roles.Select(r => r.Id).ToList();

            return View(user);
        }
        [HttpPost]
        public IActionResult AssignRole(int Id, List<int> roleIds)
        {
            /*_context.Users.Include(u => u.Roles).FirstOrDefault(u => u.Id == Id);*/

            User? user = _unitOfWork.Users.GetUserWithRole(Id);
            if (user == null)
            {
                return NotFound();
            }

            user.Roles.Clear();
            //_context.Roles.Where(r => roleIds.Contains(r.Id)).ToList();

            IEnumerable<Role> selectedRoles = _unitOfWork.Roles.GetSpecificUserRoles(roleIds);

            foreach (Role r in selectedRoles)
            {
                user.Roles.Add(r);
            }

             _unitOfWork.Users.Update(user);
            _unitOfWork.Save();

            return RedirectToAction("Index");

        }
    
    }
}
