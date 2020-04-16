using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task5_EF.Entities
{
    public class Place
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Address { get; set; }

    }
}
