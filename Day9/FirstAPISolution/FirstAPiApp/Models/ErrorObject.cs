namespace FirstAPiApp.Models
{
    public enum ErrorResponses
    {
       ObjectNotFound,
       ObjectInvalid,
       ValidtionsMissing

    }
    public class ErrorObject
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; } =string.Empty;
    }
}
