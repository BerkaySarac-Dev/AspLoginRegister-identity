namespace LoginRegisterApp.Models
{
    public class Scripts
    {
        public int Id { get; set; }
        public string? ScriptName { get; set; }
        public string? ScriptText { get; set; }
        public byte[]? ScriptImage { get; set; }
        public int? ScriptPrice { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool IsWaiting { get; set; } = true;
        public string? MalwareResult { get; set; }
        public string? ScriptSource { get; set; }
        public string? ScriptUrl { get; set; }
        public string? OwnerId { get; set; }
        public string? OwnerEmail { get; set; }
    }
}