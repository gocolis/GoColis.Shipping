using Microsoft.EntityFrameworkCore;

namespace GoColis.Shipping.Infrastructure.Common;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}