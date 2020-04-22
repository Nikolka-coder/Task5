using System;
using System.Collections.Generic;
using System.Text;
using Task5_EF.Entities;

namespace Flower.BAL.Interface
{
    public interface IFlowerService
    {
        IEnumerable<PlantationFlower> GetPlantationFlowers();
        PlantationFlower GetPlantationFlowerByID(int plantationId, int flowerId);
        void InsertPlantationFlower(PlantationFlower plantationFlower);
        void DeletePlantationFlower(int plantationId, int flowerId);
        void UpdatePlantationFlower(PlantationFlower plantationFlower);
        void Save();
        IEnumerable<WarehouseFlower> GetWarehouseFlowers();
        WarehouseFlower GetWarehouseFlowerByID(int warehouseId, int flowerId);
        void InsertWarehouseFlower(WarehouseFlower warehouseFlower);
        void DeleteWarehouseFlower(int warehouseId, int flowerId);
        void UpdateWarehouseFlower(WarehouseFlower warehouseFlower);
        IEnumerable<SupplyFlower> GetSupplyFlowers();
        SupplyFlower GetSupplyFlowerByID(int supplyId, int flowerId);
        void InsertSupplyFlower(SupplyFlower supplyFlower);
        void DeleteSupplyFlower(int supplyId, int flowerId);
        void UpdateSupplyFlower(SupplyFlower supplyFlower);
    }
}
