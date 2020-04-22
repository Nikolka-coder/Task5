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
        public DbSet<TheFlower> TheFlowers { get; set; }
        public DbSet<Plantation> Plantations { get; set; }
        public DbSet<PlantationFlower> PlantationFlowers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseFlower> WarehouseFlowers { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyFlower> SupplyFlowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlantationFlower>()
                .HasKey(p => new { p.FlowerId, p.PlantationId });
            modelBuilder.Entity<PlantationFlower>()
                .HasOne(pf => pf.TheFlower)
                .WithMany(s => s.PlantationFlowers)
                .HasForeignKey(pf => pf.FlowerId);

            modelBuilder.Entity<PlantationFlower>()
                 .HasOne(pf => pf.Plantation)
                 .WithMany(c => c.PlantationFlowers)
                 .HasForeignKey(pf => pf.PlantationId);
            

            modelBuilder.Entity<WarehouseFlower>()
                .HasKey(w => new { w.FlowerId, w.WarehouseId });
            modelBuilder.Entity<WarehouseFlower>()
                .HasOne(wf => wf.TheFlower)
                .WithMany(f => f.WarehouseFlowers)
                .HasForeignKey(wf => wf.FlowerId);

            modelBuilder.Entity<WarehouseFlower>()
                .HasOne(wf => wf.Warehouse)
                .WithMany(h => h.WarehouseFlowers)
                .HasForeignKey(wf => wf.WarehouseId);


            modelBuilder.Entity<SupplyFlower>()
                .HasKey(u => new { u.FlowerId, u.SupplyId });
            modelBuilder.Entity<SupplyFlower>()
                .HasOne(sf => sf.TheFlower)
                .WithMany(q => q.SupplyFlowers)
                .HasForeignKey(sf => sf.FlowerId);

            modelBuilder.Entity<SupplyFlower>()
                .HasOne(sf => sf.Supply)
                .WithMany(v => v.SupplyFlowers)
                .HasForeignKey(sf => sf.SupplyId);

        }
    }
}
