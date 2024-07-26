using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI6.Models
{
    public class Student
    {
        public int id { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentGender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string standard { get; set; }
        [Required]
        public string fatherName { get; set; }
    }

}