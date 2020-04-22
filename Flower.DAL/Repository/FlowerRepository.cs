using System;
using System.Collections.Generic;
using System.Linq;
using Flower.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using Task5_EF.Context;
using Task5_EF.Entities;

namespace Flower.DAL.Repositories
{
    class FlowerRepository :IFlowerRepository
    {
        private readonly FlowerContext _flowerContext;
        public FlowerRepository(FlowerContext flowerContext)
        {
            _flowerContext = flowerContext;
        }

        public void DeletePlantationFlower(int plantationId, int flowerId)
        {
            PlantationFlower plantationFlower = _flowerContext.PlantationFlowers.Find(plantationId, flowerId);
            _flowerContext.PlantationFlowers.Remove(plantationFlower);
        }

        public void DeleteSupplyFlower(int supplyId, int flowerId)
        {
            SupplyFlower supplyFlower = _flowerContext.SupplyFlowers.Find(supplyId, flowerId);
            _flowerContext.SupplyFlowers.Remove(supplyFlower);
        }

        public void DeleteWarehouseFlower(int warehouseId, int flowerId)
        {
            WarehouseFlower warehouseFlower  = _flowerContext.WarehouseFlowers.Find( warehouseId,  flowerId);
            _flowerContext.WarehouseFlowers.Remove(warehouseFlower);
        }

        public PlantationFlower GetPlantationFlowerByID(int plantationId, int flowerId)
        {
            return _flowerContext.PlantationFlowers.Find(plantationId, flowerId);
        }

        public IEnumerable<PlantationFlower> GetPlantationFlowers()
        {
            return _flowerContext.PlantationFlowers.ToList();
        }

        public SupplyFlower GetSupplyFlowerByID(int supplyId, int flowerId)
        {
            return _flowerContext.SupplyFlowers.Find(supplyId, flowerId);
        }

        public IEnumerable<SupplyFlower> GetSupplyFlowers()
        {
            return _flowerContext.SupplyFlowers.ToList();
        }

        public WarehouseFlower GetWarehouseFlowerByID(int warehouseId, int flowerId)
        {
            return _flowerContext.WarehouseFlowers.Find(warehouseId, flowerId);
        }

        public IEnumerable<WarehouseFlower> GetWarehouseFlowers()
        {
            return _flowerContext.WarehouseFlowers.ToList();
        }

        public void InsertPlantationFlower(PlantationFlower plantationFlower)
        {
            _flowerContext.PlantationFlowers.Add(plantationFlower);
        }

        public void InsertSupplyFlower(SupplyFlower supplyFlower)
        {
            _flowerContext.SupplyFlowers.Add(supplyFlower);
        }

        public void InsertWarehouseFlower(WarehouseFlower warehouseFlower)
        {
            _flowerContext.WarehouseFlowers.Add(warehouseFlower);
        }

        public void Save()
        {
            _flowerContext.SaveChanges();
        }

        public void UpdatePlantationFlower(PlantationFlower plantationFlower)
        {
            _flowerContext.Entry(plantationFlower).State = EntityState.Modified;
        }

        public void UpdateSupplyFlower(SupplyFlower supplyFlower)
        {
            _flowerContext.Entry(supplyFlower).State = EntityState.Modified;
        }

        public void UpdateWarehouseFlower(WarehouseFlower warehouseFlower)
        {
            _flowerContext.Entry(warehouseFlower).State = EntityState.Modified;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _flowerContext.Dispose();               
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
