using ProductServiceAPI.Models;

namespace ProductServiceAPI.Interfaces
{
    public interface ILogService
    {
        public Task<bool> AddLog(AuditLog auditLog);
    }
}
