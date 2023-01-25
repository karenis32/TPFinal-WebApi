using Microsoft.EntityFrameworkCore;
using TP_FINAL_WEB_API.Models;


namespace TP_FINAL_WEB_API.Data
{
    public class DBPaisFinalContext: DbContext
    {
        public DBPaisFinalContext(DbContextOptions<DBPaisFinalContext> options) : base(options) { }

        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
    }
}
