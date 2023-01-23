using FiapMarketPlace.Models;
using Microsoft.EntityFrameworkCore;

namespace FiapMarketPlace.Data
{
    public class ClienteContexto : DbContext
    {
        public ClienteContexto(DbContextOptions<ClienteContexto>options): base(options)
        {
            
        }
        public DbSet <Cliente> Clientes { get; set; }
    }
}
