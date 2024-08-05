// Producers send messages to Topics.
// Topics hold messages and route them to appropriate Queues.
// LoadBalancer balances the load between Producers and Subscribers interacting with the Topics.
// Queues store the messages until they are processed by Subscribers.
// Broker Instances manage Queues and ensure efficient message delivery.
// Communication between all components is handled using TCP, with routing algorithms ensuring efficient message delivery.

using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Common
{
    public interface ITopicManager : IDisposable
    {
        Task CreateTopicAsync(string topicName, TopicModel topic);

        Task DeleteTopicAsync(string topicName);


        IEnumerable<TopicModel> ListTopics();
        void Dispose();

    }
}