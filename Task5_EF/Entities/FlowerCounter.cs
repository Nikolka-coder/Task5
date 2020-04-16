using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task5_EF.Entities
{
    public class FlowerCounter
    {
        public int FlowerId { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
