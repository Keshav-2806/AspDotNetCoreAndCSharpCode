using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore6Demo.Models
{
    public class Student
    {
        //key is for primary key
        [Key]
        public int Id { get; set; }
        [Column("StudentName",TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Column("StudentGender",TypeName ="varchar(20)")]
        public string Gender { get; set; }
        public int Age { get; set; }

        public int Standard{ get; set; }
    }
}
