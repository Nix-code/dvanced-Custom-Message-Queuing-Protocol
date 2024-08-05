namespace MessageBrokerEngine.MessageBrokerCore.Models {
    using System;
    using System.Collections.Generic;
    using MessageBrokerEngine.MessageBrokerCore.Common;
    using MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics;

    public class TopicModel : ITopic
    {
        public Guid IdentificationId { get; private set; } = Guid.NewGuid();
        public DateTime TopicCreationDate { get; private set; } = DateTime.UtcNow;
        public TopicStatus TopicStatus { get; private set; } = TopicStatus.Active;
        public long TopicMessageCount { get; private set; }
        public TopicConfiguration Configuration { get; private set; }
        public string TopicName {get;}

        public TopicModel(string topicName, TopicConfiguration config){
            TopicName = topicName;
            Configuration = config;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}