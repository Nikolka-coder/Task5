using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class WarehouseFlowerService : IService
    {
        private DataManager dataManager;

        public WarehouseFlowerService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
