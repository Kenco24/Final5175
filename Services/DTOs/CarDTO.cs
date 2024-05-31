using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final5175.Services.DTOs
{
    public class CarDTO
    {

            public int Id { get; set; }

            public string LicensePlate { get; set; }


            public string Model { get; set; }

            public string Manufactuere { get; set; }

            public int Year { get; set; }
        
    }

}

