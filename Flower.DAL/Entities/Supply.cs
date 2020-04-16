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
        public DateTime SheduledDate { get; set; }
        [Required]
        public DateTime ClosedDate { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
