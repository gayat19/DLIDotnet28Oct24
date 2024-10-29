namespace BackToBasicsApp.Exceptions
{

    public class ProductAlreadyExistsException : Exception
    {
        readonly string _message;
        public ProductAlreadyExistsException()
        {
            _message = "Product with the same Id already is present";
        }
        public override string Message => _message;
    }
}