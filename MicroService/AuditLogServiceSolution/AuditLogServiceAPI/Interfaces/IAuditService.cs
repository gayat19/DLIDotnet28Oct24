using AuditLogServiceAPI.Models;

namespace AuditLogServiceAPI.Interfaces
{
    public interface IAuditService
    {
        public Task<ICollection<AuditLog>> GetAuditLogs();
        public Task<AuditLog> AddLog(AuditLog auditLog);
        public Task<bool> DeleteLogs(DateTime dateafterDelete);
    }
}
