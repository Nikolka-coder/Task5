using System;
using System.Collections.Generic;
using System.Text;

namespace Task5_EF.Entities
{
    public class Warehouse : Place
    {
        public List<WarehouseFlower> WarehouseFlowers { get; set; }
        public Warehouse()
        {
            WarehouseFlowers = new List<WarehouseFlower>();
        }
    }
}
