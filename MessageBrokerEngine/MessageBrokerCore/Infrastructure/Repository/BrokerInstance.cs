using System.Collections.Concurrent;
using MessageBrokerEngine.MessageBrokerCore.Broker;
using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Infrastructure.Repository{

    public class BrokerInstance : IBrokerInstance
    {
        private readonly ConcurrentDictionary<string, TopicModel> _topics = new(); 
       
        private readonly ConcurrentDictionary<string, Queue<TopicModel>> _queues = new();
        
        public IDictionary<string, Queue<TopicModel>> Queues => _queues;

        public Task AddSubscriberInternal(string topicName, string subscriberId)
        {
            throw new NotImplementedException();
        }

        public async Task CreateTopicAsync(string topicName, TopicModel topic)
        {

            if(_topics.TryAdd(topicName, topic)){
                
               _queues.TryAdd(topicName, new Queue<TopicModel>());
               _queues[topicName].Enqueue(topic);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<TopicModel> ListTopics()
        {
            return _topics.Values;
        }

        public Task PublishMessageInternal(string topicName, MessageModel message)
        {
            throw new NotImplementedException();
        }

        public Task RemoveSubscriberInternal(string topicName, string subscriberId)
        {
            throw new NotImplementedException();
        }
    }
}