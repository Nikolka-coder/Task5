using System.Collections.Generic;
using Flower.BAL.Interface;
using Flower.DAL.Interface;
using Task5_EF.Entities;

namespace Flower.BAL.Services
{
    class FlowerService : IFlowerService
    {
        private readonly IFlowerRepository _flowerRepository;
        public FlowerService(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public void DeletePlantationFlower(int plantationId, int flowerId)
        {
            _flowerRepository.DeletePlantationFlower(plantationId, flowerId); 
        }

        public void DeleteSupplyFlower(int supplyId, int flowerId)
        {
            _flowerRepository.DeleteSupplyFlower(supplyId, flowerId);
        }

        public void DeleteWarehouseFlower(int warehouseId, int flowerId)
        {
            _flowerRepository.DeleteWarehouseFlower(warehouseId, flowerId);
        }

        public PlantationFlower GetPlantationFlowerByID(int plantationId, int flowerId)
        {
            return _flowerRepository.GetPlantationFlowerByID(plantationId, flowerId);
        }

        public IEnumerable<PlantationFlower> GetPlantationFlowers()
        {
            return _flowerRepository.GetPlantationFlowers();
        }

        public SupplyFlower GetSupplyFlowerByID(int supplyId, int flowerId)
        {
            return _flowerRepository.GetSupplyFlowerByID(supplyId, flowerId);
        }

        public IEnumerable<SupplyFlower> GetSupplyFlowers()
        {
            return _flowerRepository.GetSupplyFlowers();
        }

        public WarehouseFlower GetWarehouseFlowerByID(int warehouseId, int flowerId)
        {
            return _flowerRepository.GetWarehouseFlowerByID(warehouseId, flowerId);
        }

        public IEnumerable<WarehouseFlower> GetWarehouseFlowers()
        {
            return _flowerRepository.GetWarehouseFlowers();
        }

        public void InsertPlantationFlower(PlantationFlower plantationFlower)
        {
            _flowerRepository.InsertPlantationFlower(plantationFlower);
        }

        public void InsertSupplyFlower(SupplyFlower supplyFlower)
        {
            _flowerRepository.InsertSupplyFlower(supplyFlower);
        }

        public void InsertWarehouseFlower(WarehouseFlower warehouseFlower)
        {
            _flowerRepository.InsertWarehouseFlower(warehouseFlower);
        }

        public void Save()
        {
            _flowerRepository.Save();
        }

        public void UpdatePlantationFlower(PlantationFlower plantationFlower)
        {
            _flowerRepository.UpdatePlantationFlower(plantationFlower);
        }

        public void UpdateSupplyFlower(SupplyFlower supplyFlower)
        {
            _flowerRepository.UpdateSupplyFlower(supplyFlower);
        }

        public void UpdateWarehouseFlower(WarehouseFlower warehouseFlower)
        {
            _flowerRepository.UpdateWarehouseFlower(warehouseFlower);
        }
    }
}
