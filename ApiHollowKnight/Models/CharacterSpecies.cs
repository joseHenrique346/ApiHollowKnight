using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("CharacterSpecies")]
    public class CharacterSpecies : BaseEntity
    {
        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}
