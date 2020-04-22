using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class WarehouseService : IService
    {
        private DataManager dataManager;

        public WarehouseService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
