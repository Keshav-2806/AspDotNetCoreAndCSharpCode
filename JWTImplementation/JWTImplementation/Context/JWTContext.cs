using JWTImplementation.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTImplementation.Context
{
    public class JWTContext: DbContext
    {
        public JWTContext(DbContextOptions<JWTContext> options ):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
