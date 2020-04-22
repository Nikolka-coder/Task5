using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Task5_EF.Entities
{
    public class TheFlower
    {
        public int Id { set; get; }
        [Required(ErrorMessage = "Required field")]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        public List<PlantationFlower> PlantationFlowers { get; set; }
        public List<WarehouseFlower> WarehouseFlowers { get; set; }
        public List<SupplyFlower> SupplyFlowers { get; set; }
        public TheFlower()
        {
            PlantationFlowers = new List<PlantationFlower>();
            WarehouseFlowers = new List<WarehouseFlower>();
            SupplyFlowers = new List<SupplyFlower>();
        }
    }
}
