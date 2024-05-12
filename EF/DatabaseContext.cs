using Microsoft.EntityFrameworkCore;
using MVCApplication.Models;

namespace MVCApplication.EF
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
                
        }
        public DbSet<ApplicationUser> EmpTable { get; set; }
    }
}
