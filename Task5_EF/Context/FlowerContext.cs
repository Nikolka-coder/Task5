using Microsoft.EntityFrameworkCore;
using Task5_EF.Entities;

namespace Task5_EF.Context
{
    class FlowerContext : DbContext
    {
        public FlowerContext(DbContextOptions<FlowerContext> options)
                 : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<PlantationFlower> PlantationFlowers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseFlower> WarehouseFlowers { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyFlower> SupplyFlowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        
        }

    }
}
