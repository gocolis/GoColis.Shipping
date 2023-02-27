using AutoMapper;

namespace GoColis.Shipping.Infrastructure.Common;

// TODO: Review
public abstract class Repository
{
    internal readonly DatabaseContext DbContext;
    internal readonly IMapper Mapper;

    public Repository(DatabaseContext dbContext, IMapper mapper)
    {
        DbContext = dbContext;
        Mapper = mapper;
    }
}