namespace MessageBrokerEngine.MessageBrokerCore.Core.Engine.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MessageBrokerEngine.MessageBrokerCore.Core.Engine.Common.Events;

    public interface ITopic : IDisposable
    {
        Guid Id { get; }
        string Name { get; }
        string Description { get; }
        string TRoute { get; }
        DateTime CreationDate { get; }
        string Owner { get; }
        int Partitions { get; }
        int ReplicationFactor { get; }
        TopicStatus Status { get; }
        TimeSpan RetentionPeriod { get; }
        long MessageCount { get; }
        int SubscriptionCount { get; }

        bool IsAuthorizedProducer(string producerId);
        bool IsAuthorizedConsumer(string consumerId);

        void Subscribe(string subscriberId);
        void Unsubscribe(string subscriberId);
        IEnumerable<string> GetSubscribers();

        IDictionary<string, string> Metadata { get; }
        void AddMetadata(string key, string value);
        string GetMetadata(string key);

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
