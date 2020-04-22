using System.ComponentModel.DataAnnotations;

namespace Task5_EF.Entities
{
    public class FlowerCounter
    {
        public int FlowerId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Enter valid number")]
        public int Amount { get; set; }
        [MinLength(11, ErrorMessage = "Please write a little bit more...")]
        [MaxLength(21, ErrorMessage = "Please give short information. Don't overload description")]
        public string Description { get; set; }
        public TheFlower TheFlower { get; set; }

    }
}
