namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces{

    public interface ITopicMethods {
        bool IsAuthorizedProducer(Guid producerId);
        bool IsAuthorizedConsumer(Guid consumerId);
        Task Subscribe(string subscriberId);
        Task Unsubscribe(string subscriberId);
        Task Publish (string subscriberId);
        Task StartAsync();
        Task StopAsync();
   
    }
}