using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace FirstAPiApp.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<int, User> _userRepository;
        private readonly IRepository<int, Employee> _employeeRepository;
        private readonly ITokenService _tokenService;

        public LoginService(IRepository<int,User> userRepository,
            IRepository<int,Employee> employeeRepository,
            ITokenService tokenService)
        {
            _userRepository = userRepository;
            _employeeRepository = employeeRepository;
            _tokenService = tokenService;
        }
        public async Task<LoginResponseDTO> LoginAsync(LoginRequestDTO loginRequestDTO)
        {
            var id = await GetIdFromEmail(loginRequestDTO.Username);
            if(id==0)
                throw new Exception("Not a valid user");
            var user = await _userRepository.GetAsync(id);
            if(user==null)
                throw new Exception("Not a valid user");
            HMACSHA256 hMACSHA256 = new HMACSHA256(user.HashKey);
            var password = hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(loginRequestDTO.Password));
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] != user.Password[i])
                    throw new Exception("Not a valid user");
            }
            LoginResponseDTO responseDTO = new LoginResponseDTO()
            {
                Username = loginRequestDTO.Username,
                Token = await _tokenService.GenerateToken(user)
            };
            return responseDTO;
        }

        public async Task<LoginResponseDTO> RegisterAsync(LoginRequestDTO loginRequestDTO)
        {
            HMACSHA256 hMACSHA256 = new HMACSHA256();
            var id = await GetIdFromEmail(loginRequestDTO.Username);
            var password = hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(loginRequestDTO.Password));
            User user = new User
            {
                Username = loginRequestDTO.Username,
                Id = id,
                Password = password,
                HashKey = hMACSHA256.Key
            };
            var result = _userRepository.AddAsync(user);
            if(result != null)
            {
                LoginResponseDTO responseDTO = new LoginResponseDTO()
                {
                    Username = loginRequestDTO.Username,
                    Token = await _tokenService.GenerateToken(user)
                };
                return responseDTO;
            }
            throw new Exception("Unable to register user at this moment");
        }

        private async Task<int> GetIdFromEmail(string username)
        {
            var user = (await _employeeRepository.GetAllAsync()).FirstOrDefault(e=>e.Email== username);
            if (user != null) 
                return user.Id;
            throw new Exception("No such employee");
        }
    }
}
