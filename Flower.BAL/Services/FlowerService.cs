using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class FlowerService : IService
    {
        private DataManager dataManager;

        public FlowerService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
