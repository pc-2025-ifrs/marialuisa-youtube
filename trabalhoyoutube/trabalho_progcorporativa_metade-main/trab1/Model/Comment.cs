namespace trab1.Model
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Text { get; set; }
        public bool Liked { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Guid MusicId { get; set; }
        
    }
}