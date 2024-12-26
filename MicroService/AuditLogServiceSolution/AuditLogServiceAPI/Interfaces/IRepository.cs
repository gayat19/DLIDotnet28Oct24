using AuditLogServiceAPI.Models;

namespace AuditLogServiceAPI.Interfaces
{
    public interface IRepository
    {
        public Task<IEnumerable<AuditLog>> GetAuditLogs();
        public Task<AuditLog> GetAuditLog(int id);
        public Task<AuditLog> CreateAuditLog(AuditLog auditLog);
        public Task<AuditLog> UpdateAuditLog(AuditLog auditLog);
        public Task<AuditLog> DeleteAuditLog(int id);

    }
}
