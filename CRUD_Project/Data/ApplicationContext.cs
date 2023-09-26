using CRUD_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Data
{
    public class ApplicationContext:DbContext
    {
       public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classs { get; set; }
    }
}
