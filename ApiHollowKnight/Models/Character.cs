using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHollowKnight.Models
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public int CharactersId { get; set; }

        [Required]
        [StringLength(80)]
        public string CharactersName { get; set; }

        [Required]
        [StringLength(512)]
        public string CharactersDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string CharactersGender { get; set; }

        [Required]
        [ForeignKey(nameof(CharacterType))]
        public int CharactersTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(CharacterSpecies))]
        public int CharactersSpeciesId { get; set; }

        [Required]
        [ForeignKey(nameof(Place))]
        public int PlacesId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Health { get; set; }

        [Required]
        [StringLength(64)]
        public string Color { get; set; }

        [Required]
        public string ImagemUrl { get; set; }
    }
}
