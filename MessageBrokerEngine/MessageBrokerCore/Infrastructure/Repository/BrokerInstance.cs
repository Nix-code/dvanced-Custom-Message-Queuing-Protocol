using MessageBrokerEngine.MessageBrokerCore.Broker;
using MessageBrokerEngine.MessageBrokerCore.Models;
namespace MessageBrokerEngine.MessageBrokerCore.Infrastructure.Repository{

    public class BrokerInstance : IBrokerInstance
    {

        private readonly BrokerModel _brokerModel;
        public BrokerInstance(BrokerModel brokerModel)
        {
            _brokerModel = brokerModel;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public void EnqueueMessage(MessageModel message, int partition)
        {
            var queue = _brokerModel.Queues[partition];
            queue.Enqueue(message);
        }
    }
}