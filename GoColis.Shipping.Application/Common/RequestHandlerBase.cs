using AutoMapper;

namespace GoColis.Shipping.Application.Common;

public abstract class RequestHandlerBase
{
    internal readonly IMapper Mapper;

    public RequestHandlerBase(IMapper mapper)
    {
        Mapper = mapper;
    }
}

