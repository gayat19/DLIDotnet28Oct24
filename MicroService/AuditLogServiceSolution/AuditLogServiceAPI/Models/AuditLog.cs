namespace AuditLogServiceAPI.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string TableName { get; set; } = string.Empty;
        public string ColumenName { get; set; } = string.Empty;
        public string KeyValue { get; set; } = string.Empty;
        public string OldValue { get; set; } = string.Empty;
        public string NewValue { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

    }
}
