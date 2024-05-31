using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final5175.Data.Entities
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string LicensePlate { get; set; }


        [Required]
        public string Model { get; set; }

        [Required]
        public string Manufactuere { get; set; }
        
        [Required]
        public int Year { get; set; }
    }
}
