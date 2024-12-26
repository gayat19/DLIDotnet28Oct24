using ProductServiceAPI.Interfaces;
using ProductServiceAPI.Models;

namespace ProductServiceAPI.Services
{
    public class LogService : ILogService
    {
        HttpClient _client;

        public async Task<bool> AddLog(AuditLog auditLog)
        {
         using(_client = new HttpClient())
        {
            _client.BaseAddress = new Uri("http://localhost:5133/");
            var response = await _client.PostAsJsonAsync("api/AuditLog", auditLog);
                return response.IsSuccessStatusCode;
        }
        }
    }
}
