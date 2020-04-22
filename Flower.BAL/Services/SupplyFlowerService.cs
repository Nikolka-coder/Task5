using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class SupplyFlowerService : IService
    {
        private DataManager dataManager;

        public SupplyFlowerService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
