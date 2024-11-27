using FirstAPiApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstAPiApp.Misc
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new BadRequestObjectResult(
                new ErrorObject
                {
                    Message =context.Exception.Message,
                    ErrorCode = 500
                });
        }
    }
}
