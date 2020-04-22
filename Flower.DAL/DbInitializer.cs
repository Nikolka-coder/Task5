using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task5_EF.Context;
using Task5_EF.Entities;

namespace Flower.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(FlowerContext flowerContext)
        {
            flowerContext.Database.EnsureCreated();
            
            if (flowerContext.TheFlowers.Any())
            {
                return;   // DB has been seeded
            }
            var flowers = new TheFlower[]
                {
                 new TheFlower{ Id = 1, Name ="Tulip"},
                 new TheFlower{ Id = 2, Name = "Rose"},
                 new TheFlower{ Id = 3, Name = "Phalenopsis"}
                };
            foreach (TheFlower f in flowers)
            {
                flowerContext.TheFlowers.Add(f);
            }
            flowerContext.SaveChanges();

            var plantations = new Plantation[]
                {
                    new Plantation{ Id = 1, Name = "First", Address = "Philadelphia, 1020"},
                    new Plantation{ Id = 2, Name = "Second", Address = "Pensilvania, 1452"}
                };
            foreach (Plantation p in plantations)
            {
                flowerContext.Plantations.Add(p);
            }
            flowerContext.SaveChanges();
            var plantationFlowers = new PlantationFlower[]
                {
                    new PlantationFlower{ PlantationId = 1, FlowerId = 1, Amount = 50},
                    new PlantationFlower{ PlantationId = 2, FlowerId = 2, Amount = 100}
                };
            foreach (PlantationFlower pf in plantationFlowers)
            {
                flowerContext.PlantationFlowers.Add(pf);
            }
            flowerContext.SaveChanges();
            var warehouses = new Warehouse[]
                {
                    new Warehouse{Id = 1, Name = "First", Address = "Philadelphia, 1020"},
                    new Warehouse{Id = 2, Name = "Second", Address = "Pensilvania, 1452"}
                };
            foreach (Warehouse w in warehouses)
            {
                flowerContext.Warehouses.Add(w);
            }
            flowerContext.SaveChanges();
            var warehouseFlowers = new WarehouseFlower[]
                {
                    new WarehouseFlower{ WarehouseId =  1, FlowerId = 1, Amount = 50},
                    new WarehouseFlower{ WarehouseId =  2, FlowerId = 2, Amount = 100}
                };
            foreach (WarehouseFlower wf in warehouseFlowers)
            {
                flowerContext.WarehouseFlowers.Add(wf);
            }
            flowerContext.SaveChanges();
            var supplies = new Supply[]
                {
                    new Supply{ Id = 1, PlantationId = 1, WarehouseId = 1, SheduledDate = DateTime.Parse("2020-04-10"), ClosedDate = DateTime.Parse("2020-04-05"), Status =Entities.Enum.Status.Closed },
                    new Supply{ Id = 2, PlantationId = 2, WarehouseId = 2, SheduledDate = DateTime.Parse("2020-04-06"), ClosedDate = DateTime.Parse("2020-04-21"), Status = Entities.Enum.Status.Sheduled}
                };
            foreach (Supply s in supplies)
            {
                flowerContext.Supplies.Add(s);
            }
            flowerContext.SaveChanges();
            var supplyFlowers = new SupplyFlower[]
                {
                    new SupplyFlower{ SupplyId = 1, FlowerId = 1, Amount = 75},
                    new SupplyFlower{ SupplyId = 2, FlowerId = 2, Amount = 85}
                };
            foreach (SupplyFlower sf in supplyFlowers)
            {
                flowerContext.SupplyFlowers.Add(sf);
            }
            flowerContext.SaveChanges();

        }
    }
}
