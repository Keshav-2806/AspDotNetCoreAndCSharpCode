using Microsoft.EntityFrameworkCore;

namespace CodeFirstASPCore6Demo.Models
{
    //DbContext class is used for interacting to database and table
    public class StudentDBContext:DbContext
    {
        //DbContextOptions instance carries configuration information such a the connection string, database provider to use 
        //here base(options) is used for calling the parent class constructor here parent class is DbContext
        public StudentDBContext(DbContextOptions options):base(options)
        {
                
        }
        //DbSet is represent the database table
        public DbSet<Student> Students { get; set; }
    }
}
