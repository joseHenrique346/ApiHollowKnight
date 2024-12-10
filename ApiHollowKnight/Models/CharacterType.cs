using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("CharactersTypes")]
    public class CharacterType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string? Name { get; set; }

        [Required]
        [StringLength(140)]
        public string? Description { get; set; }

        [JsonIgnore]
        public ICollection<Character>? Characters { get; set; }
    }
}
