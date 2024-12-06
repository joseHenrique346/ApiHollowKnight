using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHollowKnight.Models
{
    [Table("CharactersTypes")]
    public class CharactersTypes
    {
        [Key]
        public int CharacterTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public string? NameCharacterType { get; set; }

        [Required]
        [StringLength(140)]
        public string? NameCharacterTypeDescription { get; set; }
    }
}
