using System.Net;

namespace GoColis.Shipping.Api.Extensions
{
    public static class ResultExtensions
    {
        public static IResult OkOrError(this object obj, HttpStatusCode httpStatusCode)
        {
            if (obj == null)
                return Results.StatusCode((int)httpStatusCode);

            return Results.Ok(obj);
        }

        public static IResult CreatedOrError(this object obj, string location, HttpStatusCode httpStatusCode)
        {
            if (obj == null)
                return Results.StatusCode((int)httpStatusCode);

            return Results.Created(location, obj);
        }
    }
}
