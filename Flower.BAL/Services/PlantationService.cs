using Flower.BAL.Interface;
using Flower.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.Services
{
    public class PlantationService : IService
    {
        private DataManager dataManager;

        public PlantationService(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
    }
}
