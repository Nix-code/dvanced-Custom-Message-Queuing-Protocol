namespace MessageBrokerEngine.MessageBrokerCore.Core.Engine.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MessageBrokerEngine.MessageBrokerCore.Core.Engine.Common.Events;

    public interface ITopic : IDisposable
    {
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
        bool IsAuthorizedProducer(Guid producerId);
        bool IsAuthorizedConsumer(Guid consumerId);
        Task Subscribe(Guid subscriberId);
        Task Unsubscribe(Guid subscriberId);
        IEnumerable<string> GetSubscribers();
        void Configure(string name, string description, string tRoute, int partitions, int replicationFactor, TimeSpan retentionPeriod, string owner);
        Task StartAsync();
        Task StopAsync();
        event EventHandler<EventArgs> OnStart;
        event EventHandler<EventArgs> OnStop;
        event EventHandler<ErrorEventArgs> OnError;
    }
    public enum TopicStatus
    {
        Active,
        Inactive,
        Deleted
    }
}
