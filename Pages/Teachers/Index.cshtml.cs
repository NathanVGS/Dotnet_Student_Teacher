using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Teacher_CRUD.Data;
using Student_Teacher_CRUD.Models;

namespace student_teacher_CRUD.Pages.Teachers
{
    public class IndexModel : PageModel
    {
        private readonly Student_Teacher_CRUD.Data.StudentTeacherContext _context;

        public IndexModel(Student_Teacher_CRUD.Data.StudentTeacherContext context)
        {
            _context = context;
        }

        public IList<Teacher> Teacher { get;set; }

        public async Task OnGetAsync()
        {
            Teacher = await _context.Teacher.ToListAsync();
        }
    }
}
