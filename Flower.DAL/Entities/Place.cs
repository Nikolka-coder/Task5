using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task5_EF.Entities
{
    public class Place
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required field")]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required field")]
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

    }
}
