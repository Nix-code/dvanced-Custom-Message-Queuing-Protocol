using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics {

    public class TopicConfiguration{

        public IEnumerable<MessageModel> Messages { get; set; }
        public string? TopicDescription { get; set; }
        public string? TopicRoute { get; set; }
        public string? TopicOwner { get; set; }
        public int TopicPartitions { get; set; }
        public int TopicReplicationFactor { get; set; }
        public TimeSpan TopicRetentionPeriod { get; set; }
        public int TopicPriority { get; set; }
        public TopicType TopicType { get; set; }
        public IEnumerable<string>? Tags { get; set; }
    }

    public enum TopicType
    {
        Standard,
        Transactional,
        Priority,
        Delayed
    }

}