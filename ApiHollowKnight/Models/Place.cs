using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [Required]
        [StringLength(512)]
        public string? PlaceDescription { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}