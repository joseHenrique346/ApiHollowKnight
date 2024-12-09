using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("CharacterSpecies")]
    public class CharacterSpecies
    {
        [Key]
        public int CharactersSpeciesId { get; set; }

        [Required]
        [StringLength(64)]
        public string CharactersSpeciesName { get; set; }

        [Required]
        [StringLength(512)]
        public string CharactersSpeciesDescription { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}
