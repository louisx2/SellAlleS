using Microsoft.EntityFrameworkCore;
using SellAlleS.API.Modelos;

namespace SellAlleS.API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
