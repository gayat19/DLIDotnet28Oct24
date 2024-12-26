using AuditLogServiceAPI.Interfaces;
using AuditLogServiceAPI.Models;

namespace AuditLogServiceAPI.Services
{
    public class LogService : IAuditService
    {
        private readonly IRepository _repository;

        public LogService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<AuditLog> AddLog(AuditLog auditLog)
        {
            return await _repository.CreateAuditLog(auditLog);
        }

        public async Task<bool> DeleteLogs(DateTime dateafterDelete)
        {
            var logs = _repository.GetAuditLogs().Result.Where(x => x.ModifiedDate <= dateafterDelete).ToList();
            foreach (var log in logs)
            {
               await _repository.DeleteAuditLog(log.Id);
            }
            return true;
        }

        public async Task<ICollection<AuditLog>> GetAuditLogs()
        {
            return (await _repository.GetAuditLogs()).ToList();
        }
    }
}
