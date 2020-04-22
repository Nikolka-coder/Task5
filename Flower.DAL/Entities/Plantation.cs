using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_EF.Entities
{
    public class Plantation : Place
    {
        public List<PlantationFlower> PlantationFlowers { get; set; }
        public Plantation()
        {
            PlantationFlowers = new List<PlantationFlower>();
        }
    }
}
