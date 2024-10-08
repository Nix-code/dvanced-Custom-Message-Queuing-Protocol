namespace MessageBrokerEngine.MessageBrokerCore.Models {
    using System;
    using MessageBrokerEngine.MessageBrokerCore.Common;
    using MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics;
    using MessageBrokerEngine.MessageBrokerCore.Subscriber;

    public class TopicModel : ITopic
    {
        public Guid IdentificationId { get; private set; } = Guid.NewGuid();
        public DateTime TopicCreationDate { get; private set; } = DateTime.UtcNow;
        public TopicStatus TopicStatus { get; private set; } = TopicStatus.Active;
        public long TopicMessageCount { get; private set; }
        public TopicConfiguration Configuration { get; private set; }
        public string TopicName {get;}

        private readonly List<Subscribers> _subscribers = new List<Subscribers>();
        private readonly List<MessageModel> _messages = new List<MessageModel>();
        public void Subscribe(Subscribers subscribe){
            _subscribers.Add(subscribe);
        }

        public void PublishMessage(MessageModel message){

            _messages.Add(message);
            NotifySubscribers(message);
            TopicMessageCount++;
        }

        private void NotifySubscribers(MessageModel message){

            foreach(var subscriber in _subscribers){
                subscriber.ReceiveMessage(message);
            }
        }

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