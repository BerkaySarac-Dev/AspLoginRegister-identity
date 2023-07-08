namespace LoginRegisterApp.Models
{
    public class Tools
    {
        public int Id { get; set; }
        public string? ToolName { get; set; }
        public string? ToolText { get; set; }
        public byte[]? ToolImage { get; set; }
        public int? ToolPrice { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool IsWaiting { get; set; } = true;
        public string? MalwareResult { get; set; }
        public string? ToolSource { get; set; }
        public string? ToolUrl { get; set; }
        public string? OwnerId { get; set; }
        public string? OwnerEmail { get; set; }
    }
}