using Microsoft.EntityFrameworkCore;

namespace AuditLogServiceAPI.Contexts
{
    public class LogContext :DbContext
    {
        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {
        }

        public DbSet<AuditLogServiceAPI.Models.AuditLog> AuditLogs { get; set; }
    }
}
