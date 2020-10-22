using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Student_Teacher_CRUD.Data;


namespace Student_Teacher_CRUD.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string Email { get; set; }

        //[BindProperty]
        [Required]
        [ForeignKey("TeacherId")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}