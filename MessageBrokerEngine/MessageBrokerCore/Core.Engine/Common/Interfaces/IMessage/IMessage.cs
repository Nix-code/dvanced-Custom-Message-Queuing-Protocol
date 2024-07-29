namespace MessageBrokerEngine.MessageBrokerCore.Core.Engine.Common.Interfaces.IMessage
{
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