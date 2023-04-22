using Microsoft.EntityFrameworkCore;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions options) : base(options)
        {

        }
<<<<<<< HEAD
<<<<<<< HEAD
        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Publicaciones> Publicaciones { get; set; }
=======
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
>>>>>>> 7eaf252f1abfe50c8b5051bf76a095f383774e0d
=======
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
>>>>>>> 7eaf252f1abfe50c8b5051bf76a095f383774e0d
    }
}
