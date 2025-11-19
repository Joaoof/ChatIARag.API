    namespace ChatIARag.API.Models;

    public class Conversation
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<Document>? Documents { get; set; }
    }
