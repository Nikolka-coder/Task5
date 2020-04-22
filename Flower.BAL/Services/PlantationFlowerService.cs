using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class PlantationFlowerService : IService
    {
        private DataManager dataManager;

        public PlantationFlowerService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
