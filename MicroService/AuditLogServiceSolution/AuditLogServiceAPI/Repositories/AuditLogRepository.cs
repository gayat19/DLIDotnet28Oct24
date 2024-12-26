using AuditLogServiceAPI.Contexts;
using AuditLogServiceAPI.Interfaces;
using AuditLogServiceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuditLogServiceAPI.Repositories
{
    public class AuditLogRepository : IRepository
    {
        private readonly LogContext _context;

        public AuditLogRepository(LogContext context) 
        {
            _context = context;
        }
        public async Task<AuditLog> CreateAuditLog(AuditLog auditLog)
        {
           _context.AuditLogs.Add(auditLog);
            await _context.SaveChangesAsync();
            return auditLog;
        }

        public async Task<AuditLog> DeleteAuditLog(int id)
        {
            var log   = await GetAuditLog(id);
            _context.AuditLogs.Remove(log);
            await _context.SaveChangesAsync();
            return log;
        }

        public async Task<AuditLog> GetAuditLog(int id)
        {
            var log = _context.AuditLogs.FirstOrDefault(x => x.Id == id);
            return log;
        }

        public async Task<IEnumerable<AuditLog>> GetAuditLogs()
        {
            return await _context.AuditLogs.ToListAsync();
        }

        public async Task<AuditLog> UpdateAuditLog(AuditLog auditLog)
        {
            var log = await GetAuditLog(auditLog.Id);
            _context.Entry(log).CurrentValues.SetValues(auditLog);
            await _context.SaveChangesAsync();
            return log;
        }
    }
}
