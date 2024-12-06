using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHollowKnight.Models
{
    [Table("Characters")]
    public class Characters
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
        [ForeignKey(nameof(CharactersTypes))]
        public int CharactersTypeId { get; set; }

        [Required]
        [ForeignKey(nameof(CharactersSpecies))]
        public int CharactersSpeciesId { get; set; }

        [Required]
        [ForeignKey(nameof(Places))]
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
