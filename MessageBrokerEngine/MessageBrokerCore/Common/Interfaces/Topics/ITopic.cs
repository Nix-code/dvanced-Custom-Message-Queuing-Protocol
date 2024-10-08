namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics
{
    using System;

    public interface ITopic : IDisposable
    {
        Guid IdentificationId { get; }
        string TopicName { get; }
        DateTime TopicCreationDate { get; }
        TopicStatus TopicStatus { get; }
        long TopicMessageCount { get; }
        TopicConfiguration Configuration { get; }
    
    }
    public enum TopicStatus
    {
        Active,
        Inactive,
        Deleted
    }

}
