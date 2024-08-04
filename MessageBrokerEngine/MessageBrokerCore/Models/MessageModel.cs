namespace MessageBrokerEngine.MessageBrokerCore.Models{
    public class MessageModel
    {
        public Guid Id { get; set; }
        public byte[]? Payload { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.UtcNow;
        public byte[]? OriginalMessageData { get; set; }
        public int? Priority { get; set; }
    }
}