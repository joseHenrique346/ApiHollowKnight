using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("CharactersTypes")]
    public class CharacterType
    {
        [Key]
        public int CharacterTypeId { get; set; }

        [Required]
        [StringLength(64)]
        public string? NameCharacterType { get; set; }

        [Required]
        [StringLength(512)]
        public string? CharacterTypeDescription { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}
