using Microsoft.EntityFrameworkCore;

namespace StudentFormCsv.Models
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Register> Registers{ get; set; }
        public DbSet<Student> Students { get; set; }    
    }

}

