namespace BackToBasicsApp.Exceptions
{

    public class CollectionEmptyException : Exception
    {
        readonly string _message;
        public CollectionEmptyException()
        {
            _message = "There are no entries";
        }
        public CollectionEmptyException(string entity)
        {
            _message = $"There are no  {entity} ";
        }
        public override string Message => _message;
    }
}