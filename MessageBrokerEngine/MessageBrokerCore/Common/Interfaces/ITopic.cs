namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ITopic : IDisposable
    {
        IEnumerable<IMessage> Messages { get; }
        Guid IdentificationId { get; }
        string TopicName { get; }
        string TopicDescription { get; }
        Guid TopicRoute { get; }
        DateTime TopicCreationDate { get; }
        string TopicOwner { get; }
        int TopicPartitions { get; }
        int TopicReplicationFactor { get; }
        TopicStatus TopicStatus { get; }
        TimeSpan TopicRetentionPeriod { get; }
        long TopicMessageCount { get; }
        int TopicSubscriptionCount { get; }
        int TopicPriority { get; }
        TopicType TopicType { get; }
        bool EnableCompression { get; }
        string? EncryptionKey { get; }
        IEnumerable<string>? Tags { get; }
        IEnumerable<string> GetSubscribers();
        IEnumerable<string> GetPublishers();

    }
    public enum TopicStatus
    {
        Active,
        Inactive,
        Deleted
    }
    public enum TopicType
    {
        Standard,
        Transactional,
        Priority,
        Delayed
    }
}
