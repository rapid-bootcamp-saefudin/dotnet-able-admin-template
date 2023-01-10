using Microsoft.EntityFrameworkCore;

namespace POS.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<ClientEntity> ClientEntities => Set<ClientEntity>();
        public DbSet<DivisionEntity> DivisionEntities => Set<DivisionEntity>();
        public DbSet<EmployeeEntity> EmployeeEntities => Set<EmployeeEntity>();
        public DbSet<InventarisEntity> InventarisEntities => Set<InventarisEntity > ();
        public DbSet<ProductEntity> ProductEntities => Set<ProductEntity>();
    }
}
