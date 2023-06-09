using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentCrudV1.Models;

namespace StudentCrudV1.Controllers
{
    

    public class StudentController : Controller
    {
        private readonly StudentDBContext _context;

        public StudentController(StudentDBContext context)
        {
            _context = context;
        }

        

        // GET: Students
        public async Task<IActionResult> Index()

        {
            var students = await _context.Students.ToListAsync();

            return View(students);
        }
        // GET: Student/AddOrEdit  
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Student());
            else
                return View(_context.Students.Find(id));
        }

        // POST: Student/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddOrEdit([Bind("StudentId,StudentSurname,StudentName,StudentCourse,PhoneNumber,Date,Email")] Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.StudentId == 0)
                {
                    student.Date = DateTime.Now;
                    _context.Add(student);
                }
                else
                    _context.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }

   
}
