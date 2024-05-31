using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final5175.Data.Entities
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [MaxLength(400)]
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB {get; set; }

        [MaxLength(500)]
        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime RSD { get; set; }

        [Required]
        public DateTime RED { get; set; }

        [ForeignKey("Car")]
        public int carID { get; set; }

        public Car Car {  get; set; }
    }
}
