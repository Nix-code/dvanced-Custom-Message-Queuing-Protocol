// Producers send messages to Topics.
// Topics hold messages in a persistsnce/queue and route them to appropriate subscribers
// LoadBalancer balances the load between Producers and Subscribers observing the traffic
// Queues store the messages until they are processed by Subscribers.
// Broker Instances manage Queues and ensure efficient message delivery.
// Communication between all components is handled using TCP, with routing algorithms ensuring efficient message delivery.


using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Broker
{
    public interface IBrokerInstance : IDisposable
    {
            
        public void EnqueueMessage(MessageModel message, int  partition);
    }
}