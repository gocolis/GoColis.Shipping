namespace GoColis.Shipping.Api.EndPoints.PickupPoint;

public class CreatePickupPointOutputPort : ICreatePickupPoint
{
    public void Success(CreatePickupPointOutputData outputData)
    {
        // Handle success case
    }

    public void Failure(string error)
    {
        // Handle failure case
    }
}