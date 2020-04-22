using System;
using System.Collections.Generic;
using System.Text;

namespace Flower.BAL.DTO
{
    public class SupplyFlowerDTO
    {
        public int SupplyId { get; set; }
        public int FlowerId { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

    }
}
