using Final5175.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final5175.Services.DTOs
{
    public class ClientDTO
    {

        
        public int Id { get; set; }

      
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

       
        public DateTime DOB { get; set; }

       
        public string Address { get; set; }

        public DateTime RSD { get; set; }

        public DateTime RED { get; set; }

    }
}
