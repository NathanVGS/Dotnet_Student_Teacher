using System;
using Microsoft.EntityFrameworkCore;

namespace Student_Teacher_CRUD.Data
{
    public class StudentTeacherContext : DbContext
    {
        public StudentTeacherContext (
            DbContextOptions<StudentTeacherContext> options)
            : base(options)
        {
        }

        //public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
        public DbSet<Student_Teacher_CRUD.Models.Teacher> Teacher { get; set; }
        public DbSet<Student_Teacher_CRUD.Models.Student> Student { get; set; }
        
    }
}