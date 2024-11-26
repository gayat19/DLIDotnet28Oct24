using FirstAPiApp.Models.DTOs;


namespace FirstAPiApp.Interfaces
{
    public interface ILoginService
    {
        public Task<LoginResponseDTO> LoginAsync(LoginRequestDTO loginRequestDTO);
        public Task<LoginResponseDTO> RegisterAsync(LoginRequestDTO loginRequestDTO);
    }
}
