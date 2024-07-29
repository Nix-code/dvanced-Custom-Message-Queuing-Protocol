namespace MessageBrokerEngine.MessageBrokerCore.Broker.Common.Interfaces{
    public interface IMessage
    {
        Guid Id { get; set; }
        byte[] Payload { get; set; }
        Guid Route { get; set; }
        Guid ProducerId { get; set; }
        DateTime TimeStamp { get; set; }
        byte[] OriginalMessageData { get; set; }
        string? EncryptionKey { get; set; }
        bool IsCompressed { get; set; }
        int Priority { get; set; }
    }
}