using Microsoft.EntityFrameworkCore;
using AgendaContactos.Models;

namespace AgendaContactos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
