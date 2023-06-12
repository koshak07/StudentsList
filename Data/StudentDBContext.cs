using Microsoft.EntityFrameworkCore;
using StudentCrudV1.Models;

namespace StudentCrudV1.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
