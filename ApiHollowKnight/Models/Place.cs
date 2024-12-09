using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHollowKnight.Models
{
    [Table("Places")]
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }

        [Required]
        [StringLength(40)]
        public string Location { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}