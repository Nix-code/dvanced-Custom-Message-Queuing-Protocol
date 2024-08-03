// Producers send messages to Topics.
// Topics hold messages and route them to appropriate Queues.
// LoadBalancer balances the load between Producers and Subscribers interacting with the Topics.
// Queues store the messages until they are processed by Subscribers.
// Broker Instances manage Queues and ensure efficient message delivery.
// Communication between all components is handled using TCP, with routing algorithms ensuring efficient message delivery.

using System.Collections;
using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Broker
{
    public interface IBrokerInstance : IDisposable
    {
        Task CreateTopicAsync(string topicName, TopicModel topic);
        IEnumerable<TopicModel> ListTopics();
        IEnumerable<Queue> ListQueues(string topicName);

        void PublishMessageInternal(string topicName, MessageModel message);
        void AddSubscriberInternal(string topicName, string subscriberId);
        void RemoveSubscriberInternal(string topicName, string subscriberId);
        IDictionary<string, IList<Queue>> Queues { get; }
        void Dispose();

    }
}