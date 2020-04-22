using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class SupplyService : IService
    {
        private DataManager dataManager;

        public SupplyService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
