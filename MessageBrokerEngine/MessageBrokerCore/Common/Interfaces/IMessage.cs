namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces{
    public interface IMessage
    {
        Guid Id { get; set; }
        byte[] Payload { get; set; }
        DateTime TimeStamp { get; set; }
        byte[] OriginalMessageData { get; set; }
        string? EncryptionKey { get; set; }
        bool IsCompressed { get; set; }
        int Priority { get; set; }
    }
}