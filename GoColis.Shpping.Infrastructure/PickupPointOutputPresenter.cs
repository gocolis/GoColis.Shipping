namespace GoColis.Shpping.Infrastructure;

    public class PickupOutputPresenter : ICreatePickupPoint
    {
        private readonly IActionResultFactory _actionResultFactory;

        public Presenter(IActionResultFactory actionResultFactory)
        {
            _actionResultFactory = actionResultFactory;
        }

        public void Success(Response response)
        {
            var result = _actionResultFactory.CreateSuccess(response);
            // return the result to the client
        }

        public void Error(string errorMessage)
        {
            var result = _actionResultFactory.CreateError(errorMessage);
            // return the result to the client
        }
    }


