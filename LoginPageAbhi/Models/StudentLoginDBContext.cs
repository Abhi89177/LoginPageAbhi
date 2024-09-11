using Microsoft.EntityFrameworkCore;

namespace LoginPageAbhi.Models
{
    public class StudentLoginDBContext : DbContext
    {
        public StudentLoginDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<StudentLogin> studentLogins { get; set; }
    }
}
