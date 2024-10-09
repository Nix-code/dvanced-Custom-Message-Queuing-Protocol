namespace MessageBrokerEngine.MessageBrokerCore.Models{
    using System.Collections;
    public class BrokerModel
    {
        public Guid Id { get; set; }
        public List<Queue> Queues { get; set; }

    }
}