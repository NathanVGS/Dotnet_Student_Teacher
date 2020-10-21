using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Teacher_CRUD.Data;
using Student_Teacher_CRUD.Models;

namespace student_teacher_CRUD.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Teacher_CRUD.Data.StudentTeacherContext _context;

        public DetailsModel(Student_Teacher_CRUD.Data.StudentTeacherContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
