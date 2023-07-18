namespace LoginRegisterApp.Models
{
    public class Comments
    {
        public int CommentId { get; set; }
        public string? Type { get; set; }
        public int TypeId { get; set; }
        public DateTime? CommentDate { get; set; } = DateTime.UtcNow;
        public string? CommentText { get; set; }
        public bool CommentVerified { get; set; } = false;
    }
}