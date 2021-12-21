using Microsoft.EntityFrameworkCore;

namespace Dev.UI.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) 
        : base(options)
        {

        }
    }
}
