using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("Character")]
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        [StringLength(12)]
        public string Gender { get; set; }

        [Required]
        [ForeignKey(nameof(CharacterType))]
        public int TypeId { get; set; }

        [JsonIgnore]
        public CharacterType? CharacterType { get; set; }

        [Required]
        [ForeignKey(nameof(CharacterSpecies))]
        public int SpeciesId { get; set; }

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
        public string ImageUrl { get; set; }
    }
}
