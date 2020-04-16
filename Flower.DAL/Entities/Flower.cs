using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task5_EF.Entities
{
    public class Flower
    {
        public int Id { set; get; }
        [Required]
        public string Name { get; set; }
    }
}
