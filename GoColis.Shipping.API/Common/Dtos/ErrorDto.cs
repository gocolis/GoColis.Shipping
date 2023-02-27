using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Api.Common.Dtos
{
    public record ErrorDto(string Message)
    {
        public static ErrorDto ToDto(Error error) => new ErrorDto(error.Description);
    }
}
