using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :
            base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
