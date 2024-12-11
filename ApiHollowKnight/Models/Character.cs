using ApiHollowKnight.Arguments.Character;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiHollowKnight.Models
{
    [Table("Character")]
    public class Character : BaseEntity
    {
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
        public string ImageURL { get; set; }

        public Character(string name, string description, string gender, 
                         int typeId, CharacterType? characterType, int speciesId, 
                         CharacterSpecies? characterSpecies, int placesId, Place? place, 
                         decimal health, string color, string imageURL)
        {
            Name = name;
            Description = description;
            Gender = gender;
            TypeId = typeId;
            CharacterType = characterType;
            SpeciesId = speciesId;
            CharacterSpecies = characterSpecies;
            PlacesId = placesId;
            Place = place;
            Health = health;
            Color = color;
            ImageURL = imageURL;
        }

        public Character()
        {
             
        }

        public static implicit operator OutputCharacters(Character entity)
        {
            return new OutputCharacters(
                entity.Id,
                entity.Name,
                entity.Description,
                entity.Gender,
                entity.TypeId,
                entity.SpeciesId,
                entity.PlacesId,
                entity.Health,
                entity.Color,
                entity.ImageURL);
        }
    }
}
