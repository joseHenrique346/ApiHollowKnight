using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [JsonIgnore]
        public CharacterType? CharacterType { get; set; }

        [Required]
        [ForeignKey(nameof(CharacterSpecies))]
        public int CharactersSpeciesId { get; set; }

        [JsonIgnore]
        public CharacterSpecies? CharacterSpecies { get; set; }

        [Required]
        [ForeignKey(nameof(Place))]
        public int PlacesId { get; set; }

        [JsonIgnore]
        public Place? Place { get; set; }

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
