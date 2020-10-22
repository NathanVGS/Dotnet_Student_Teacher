using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Teacher_CRUD.Data;
using Student_Teacher_CRUD.Models;

namespace student_teacher_CRUD.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Student_Teacher_CRUD.Data.StudentTeacherContext _context;

        public CreateModel(Student_Teacher_CRUD.Data.StudentTeacherContext context)
        {
            _context = context;
        }

        /*public IActionResult OnGet()
        {
            return Page();
        } 
        public async Task OngetAsync() can't have return type with page, but 
        public async Task<IActionResult> OnGetAsync() can return the Page()
        */
        
        //added this method for workshop
        public IList<Teacher> Teacher { get;set; }
        public async Task<IActionResult> OnGetAsync()
        {
            Teacher = await _context.Teacher.ToListAsync();
            //add teachers?
            return Page();
        }
        //end of added method

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
