using Flower.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.DAL
{
    public class DataManager
    {
        public IFlowerRepository TheFlowers { private set; get; }
        public IPlantationRepository Plantations { private set; get; }
        public ISupplyRepository Supplies { private set; get; }
        public IWarehouseRepository Warehouses { private set; get; }
        public IPlantationFlowerRepository PlantationFlowers { private set; get; }
        public IWarehouseFlowerRepository WarehouseFlowers { private set; get; }
        public ISupplyFlowerRepository SupplyFlowers { private set; get; }

        public DataManager(IFlowerRepository repositoryFlower, IPlantationRepository repositoryPlantation,
                IWarehouseRepository repositoryWarehouse, ISupplyRepository repositorySupply,
                IPlantationFlowerRepository repositoryPlantationFlower, ISupplyFlowerRepository repositorySupplyFlower,
                IWarehouseFlowerRepository repositoryWarehouseFlower)
        {
            TheFlowers = repositoryFlower;
            Plantations = repositoryPlantation;
            Supplies = repositorySupply;
            Warehouses = repositoryWarehouse;
            PlantationFlowers = repositoryPlantationFlower;
            WarehouseFlowers = repositoryWarehouseFlower;
            SupplyFlowers = repositorySupplyFlower;
        }
    }
}
