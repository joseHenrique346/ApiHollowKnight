using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("Places")]
    public class Place : BaseEntity
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}