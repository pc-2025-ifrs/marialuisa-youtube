namespace trab1.Model
{
    public class Music
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Title { get; set; }
        public Guid ChannelId { get; set; }
        
    }
}