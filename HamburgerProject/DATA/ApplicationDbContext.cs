using HamburgerProject.ENUMS;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.DATA
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ExtraMaterial> ExtraMaterials { get; set; }
    }
}
