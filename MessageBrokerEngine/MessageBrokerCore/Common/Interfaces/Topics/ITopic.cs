namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics
{
    using System;
    using System.Collections.Generic;

    public interface ITopic : IDisposable
    {
        Guid IdentificationId { get; }
        string TopicName { get; }
        DateTime TopicCreationDate { get; }
        TopicStatus TopicStatus { get; }
        long TopicMessageCount { get; }
        TopicConfiguration Configuration { get; }
        IEnumerable<string> GetSubscribers();
        IEnumerable<string> GetPublishers();

    }
    public enum TopicStatus
    {
        Active,
        Inactive,
        Deleted
    }

}
