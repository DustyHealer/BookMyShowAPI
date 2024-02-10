namespace BookMyShow.Exceptions
{
    public class MovieAlreadyExistsException : Exception
    {
        public MovieAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
