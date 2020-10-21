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
    public class IndexModel : PageModel
    {
        private readonly Student_Teacher_CRUD.Data.StudentTeacherContext _context;

        public IndexModel(Student_Teacher_CRUD.Data.StudentTeacherContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
