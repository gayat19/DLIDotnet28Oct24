using AuditLogServiceAPI.Interfaces;
using AuditLogServiceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuditLogServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditController : ControllerBase
    {
        private readonly IAuditService _auditService;

        public AuditController(IAuditService auditService)
        {
            _auditService = auditService;
        }

        [HttpGet]
        public async Task<ICollection<AuditLog>> GetAuditLogs()
        {
            return await _auditService.GetAuditLogs();
        }

        [HttpPost]
        public async Task<AuditLog> AddLog(AuditLog auditLog)
        {
            return await _auditService.AddLog(auditLog);
        }

        [HttpDelete]
        public async Task<bool> DeleteLogs(DateTime dateafterDelete)
        {
            return await _auditService.DeleteLogs(dateafterDelete);
        }
    }
}
