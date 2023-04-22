using Microsoft.EntityFrameworkCore;

namespace L02_P02_2020VH602_2020VD602.Models
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
