using DataMVCCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DataMVCCore.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly BusinessDbContext _context;

        public EmployeesController(BusinessDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeController
        public async Task<ActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: EmployeeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Empid == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            ViewData["Storeid"] = new SelectList(_context.Stores, "Storeid", "Storeid");
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Empid,Lastname,Firstname,Title,Hiredate,Phone,Storeid")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var store = await _context.Stores.FindAsync(employee.Storeid);
                if(store!=null) employee.Store = store;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Storeid"] = new SelectList(_context.Stores, "Storeid", "Storeid", employee.Storeid);
            return View(employee);
        }

        // GET: EmployeeController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
          if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["Storeid"] = new SelectList(_context.Stores, "Storeid", "Storeid", employee.Storeid);
            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [Bind("Empid,Lastname,Firstname,Title,Hiredate,Phone,Storeid")] Employee employee)
        {
            var store = await _context.Stores.FindAsync(employee.Storeid);
            if (id != employee.Empid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Empid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Storeid"] = new SelectList(_context.Stores, "Storeid", "Storeid", employee.Storeid);
            return View(employee);
        }

        private bool EmployeeExists(int empid)
        {
            return _context.Employees.Any(e => e.Empid == empid);
        }

        // GET: EmployeeController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Empid == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            if (_context.Employees == null)
            {
                return Problem("Entity set 'BusinessDbContext.Employees'  is null.");
            }
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
