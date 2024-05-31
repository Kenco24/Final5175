using Microsoft.EntityFrameworkCore;
using Final5175.Data.Entities;

namespace Final5175.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) : base(options)

        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients {get; set; }
    }
}
