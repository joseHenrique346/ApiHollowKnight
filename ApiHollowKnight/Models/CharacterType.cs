using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHollowKnight.Models
{
    [Table("CharactersTypes")]
    public class CharacterType
    {
        [Key]
        public int CharacterTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public string? NameCharacterType { get; set; }

        [Required]
        [StringLength(140)]
        public string? CharacterTypeDescription { get; set; }

        public ICollection<Character> Characters { get; set; }
    }
}
