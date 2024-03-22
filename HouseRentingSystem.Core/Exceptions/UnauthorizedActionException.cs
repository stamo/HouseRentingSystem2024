namespace HouseRentingSystem.Core.Exceptions
{
    public class UnauthorizedActionException : Exception
    {
        public UnauthorizedActionException() { }

        public UnauthorizedActionException(string message)
            : base(message) { }
    }
}
