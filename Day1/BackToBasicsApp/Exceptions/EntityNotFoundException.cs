namespace BackToBasicsApp.Exceptions
{

    public class EntityNotFoundException : Exception
    {
        readonly string _message;
        public EntityNotFoundException()
        {
            _message = "No such entity";
        }
        public EntityNotFoundException(string entity)
        {
            _message = $"The {entity} is not found";
        }
        public override string Message => _message;
    }
}