using Flower.DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task5_EF.Entities
{
    public class Supply
    {
        public int Id { get; set; }
        public int PlantationId { get; set; }
        public int WarehouseId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Sheduled date")]
        public DateTime SheduledDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Closed date")]
        public DateTime ClosedDate { get; set; }
        [Required]
        [Display(Name = "Supply status")]
        public Status Status { get; set; }
        public List<SupplyFlower> SupplyFlowers { get; set; }
        public Supply()
        {
            SupplyFlowers = new List<SupplyFlower>();
        }
    }
}
