using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_EF.Entities
{
    public class PlantationFlower : FlowerCounter
    {
        public int PlantationId { get; set; }
        public Plantation Plantation { get; set;}
    }
}
