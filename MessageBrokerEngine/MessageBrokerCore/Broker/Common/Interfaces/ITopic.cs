namespace MessageBrokerEngine.MessageBrokerCore.Engine.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MessageBrokerEngine.MessageBrokerCore.Broker.Common.Interfaces;
    public interface ITopic : IDisposable
    {
        IEnumerable<IMessage> Messages { get; }
        Task Publish(IMessage message);
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
        int TopicPriority {get;}
        TopicType TopicType {get;}
        bool EnableCompression {get;}
        string? EncryptionKey{get;}
        IEnumerable<string>? Tags { get; }
        IEnumerable<string> GetSubscribers();
        bool IsAuthorizedProducer(Guid producerId);
        bool IsAuthorizedConsumer(Guid consumerId);
        Task Subscribe(Guid subscriberId);
        Task Unsubscribe(Guid subscriberId);
        Task StartAsync();
        Task StopAsync();
        event EventHandler<EventArgs> OnStart;
        event EventHandler<EventArgs> OnStop;
        event EventHandler<ErrorEventArgs> OnError;

        void Configure(
            string topicName,
            string topicDescription,
            string topicRoute,
            int topicPartitions,
            int topicReplicationFactor,
            TimeSpan topicRetentionPeriod,
            string topicOwner,
            int topicPriority = 0, 
            bool enableCompression = false, 
            string encryptionKey = null, 
            TopicType topicType = TopicType.Standard,
            string[] tags = null 
        );
       
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
