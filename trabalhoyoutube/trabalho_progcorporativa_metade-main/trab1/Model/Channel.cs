namespace trab1.Model
{
    public class Channel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public int Inscritos { get; set; }
        public DateOnly Data { get; set; }
    }
}