namespace MessageBrokerEngine.MessageBrokerCore.Topic {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using MessageBrokerEngine.MessageBrokerCore.Common.Interfaces;

    public class Topic : ITopic
    {
        public IEnumerable<IMessage> Messages => throw new NotImplementedException();

        public Guid IdentificationId => throw new NotImplementedException();

        public string TopicName => throw new NotImplementedException();

        public string TopicDescription => throw new NotImplementedException();

        public Guid TopicRoute => throw new NotImplementedException();

        public DateTime TopicCreationDate => throw new NotImplementedException();

        public string TopicOwner => throw new NotImplementedException();

        public int TopicPartitions => throw new NotImplementedException();

        public int TopicReplicationFactor => throw new NotImplementedException();

        public TopicStatus TopicStatus => throw new NotImplementedException();

        public TimeSpan TopicRetentionPeriod => throw new NotImplementedException();

        public long TopicMessageCount => throw new NotImplementedException();

        public int TopicSubscriptionCount => throw new NotImplementedException();

        public int TopicPriority => throw new NotImplementedException();

        public TopicType TopicType => throw new NotImplementedException();

        public bool EnableCompression => throw new NotImplementedException();

        public string? EncryptionKey => throw new NotImplementedException();

        public IEnumerable<string>? Tags => throw new NotImplementedException();

        public event EventHandler<EventArgs> OnStart;
        public event EventHandler<EventArgs> OnStop;
        public event EventHandler<ErrorEventArgs> OnError;

        public void Configure(string topicName, string topicDescription, string topicRoute, int topicPartitions, int topicReplicationFactor, TimeSpan topicRetentionPeriod, string topicOwner, int topicPriority = 0, bool enableCompression = false, string encryptionKey = null, TopicType topicType = TopicType.Standard, string[] tags = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSubscribers()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthorizedConsumer(Guid consumerId)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthorizedProducer(Guid producerId)
        {
            throw new NotImplementedException();
        }

        public Task Publish(IMessage message)
        {
            throw new NotImplementedException();
        }

        public Task StartAsync()
        {
            throw new NotImplementedException();
        }

        public Task StopAsync()
        {
            throw new NotImplementedException();
        }

        public Task Subscribe(Guid subscriberId)
        {
            throw new NotImplementedException();
        }

        public Task Unsubscribe(Guid subscriberId)
        {
            throw new NotImplementedException();
        }
    }
}