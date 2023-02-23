using Microsoft.EntityFrameworkCore;
namespace GoColis.Shpping.Infrastructure;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }


    }


