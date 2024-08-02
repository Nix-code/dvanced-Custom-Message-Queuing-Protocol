namespace MessageBrokerEngine.MessageBrokerCore.Topic {
    using System;
    using System.Collections.Generic;
    using MessageBrokerEngine.MessageBrokerCore.Common.Interfaces;

    public class MessageTopic : ITopic
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetPublishers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSubscribers()
        {
            throw new NotImplementedException();
        }
    }
}