using Flower.DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.DTO
{
    public class SupplyDTO
    {
        public int Id { get; set; }
        public int PlantationId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime SheduledDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public Status Status { get; set; }
    }
}
