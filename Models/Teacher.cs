using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Teacher_CRUD.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }

        //public decimal Price { get; set; }
    }
}