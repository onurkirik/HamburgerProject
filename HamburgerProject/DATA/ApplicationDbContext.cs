using HamburgerProject.ENUMS;
using Microsoft.EntityFrameworkCore;

namespace HamburgerProject.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ExtraMaterial> ExtraMaterials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Menu>().HasData(
                new Menu()
                {
                    Id = 1,
                    MenuName = "Burger King Menüsü",
                    Price = 80.72
                },

                new Menu()
                {
                    Id = 2,
                    MenuName = "Double King Chicken Menu",
                    Price = 100.72
                },

                new Menu()
                {
                    Id = 3,
                    MenuName = "Steak House Menu",
                    Price = 98.72
                },

                new Menu()
                {
                    Id = 4,
                    MenuName = "Whooper Menu",
                    Price = 78.72
                },

                new Menu()
                {
                    Id = 5,
                    MenuName = "Whooper Jr. Menu",
                    Price = 128.72
                },

                new Menu()
                {
                    Id = 6,
                    MenuName = "Chicken Royal Menu",
                    Price = 138.72
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
