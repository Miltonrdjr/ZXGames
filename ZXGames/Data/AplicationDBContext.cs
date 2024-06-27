using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ZXGames.Models;

namespace ZXGames.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions<AplicationDBContext>options) : base(options)
        {
            
        }

        public DbSet<VendaModel> Venda { get; set; }
    }
}
