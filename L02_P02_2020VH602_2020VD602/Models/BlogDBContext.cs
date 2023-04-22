using Microsoft.EntityFrameworkCore;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Publicaciones> Publicaciones { get; set; }
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }

    }
}
