using GoColis.Shipping.Api.Common.Dtos;
using Owls.ErrorOr.Core;

namespace GoColis.Shipping.Api.Extensions
{
    public static class ResultExtensions
    {
        internal static IResult ToResult(this Error error, ILogger? logger=null)
        {
            var dto = ErrorDto.ToDto(error!);

            switch (error.Type)
            {
                case ErrorType.NotFound:
                    return Results.NotFound(dto);

                case ErrorType.Validation:
                case ErrorType.Conflict:
                    return Results.BadRequest(dto);

                default:
                case ErrorType.Failure:
                case ErrorType.Unexpected:
                case ErrorType.None:
                    logger?.LogError($"{error.Code}: {error.Description}");
                    return Results.Problem(detail: error.Description, statusCode: 500);
            }
        }
    }
}
