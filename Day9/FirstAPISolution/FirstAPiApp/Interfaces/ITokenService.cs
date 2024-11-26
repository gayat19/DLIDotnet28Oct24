using FirstAPiApp.Models;

namespace FirstAPiApp.Interfaces
{
    public interface ITokenService
    {
        public Task<string> GenerateToken(User user);
    }
}
