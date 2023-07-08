namespace LoginRegisterApp.Models
{
    public class Showcases
    {
        public int Id { get; set; }
        public string? ShowcaseUrl { get; set; }
        public string? ShowcasePhotoUrl { get; set; }
        public string? ShowcaseHeader { get; set; }
        public string? ShowcaseText { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public DateTime EndDate => PublishDate.AddDays(7);
        public bool IsItMını { get; set; }
    }
}