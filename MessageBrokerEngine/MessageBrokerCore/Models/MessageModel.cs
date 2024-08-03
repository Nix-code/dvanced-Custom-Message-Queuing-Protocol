namespace MessageBrokerEngine.MessageBrokerCore.Models{
    public class MessageModel
    {
        Guid Id { get; set; }
        byte[]? Payload { get; set; }
        DateTime TimeStamp { get; set; } = DateTime.UtcNow;
        byte[]? OriginalMessageData { get; set; }
        int? Priority { get; set; }
    }
}