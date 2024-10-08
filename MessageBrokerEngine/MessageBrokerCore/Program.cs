using MessageBrokerEngine.MessageBrokerCore.Common;
using MessageBrokerEngine.MessageBrokerCore.Common.Interfaces.Topics;
using MessageBrokerEngine.MessageBrokerCore.Infrastructure.Repository;
using MessageBrokerEngine.MessageBrokerCore.Models;
using MessageBrokerEngine.MessageBrokerCore.Subscriber;


namespace MessageBrokerEngine.MessageBrokerCore{

    class Program {

        static async Task Main(string[] args)
        {
            var TopicManager = new TopicManager();
            var topicName = "testTopic";
            var config = new TopicConfiguration
            {
                TopicDescription = "Test Description",
                TopicRoute = "/testRoute",
                TopicOwner = "Owner",
                TopicPartitions = 1,
                TopicReplicationFactor = 1,
                TopicRetentionPeriod = TimeSpan.FromDays(1),
                TopicPriority = 1,
                TopicType = TopicType.Standard,
                Tags = new[] { "tag1", "tag2" }
            };
            var topic = new TopicModel(topicName, config);
            
            await TopicManager.CreateTopicAsync(topicName, topic);

            var subscriber1 = new Subscribers{
                SubscriberIdenfication = "1234"
            };

            var subscriber2 = new Subscribers{
                SubscriberIdenfication = "5678"
            };
            

          var message1 = new MessageModel
            {
                Id = Guid.NewGuid(),
                Payload = new byte[] { 0x01, 0x02, 0x03 }, 
                TimeStamp = DateTime.UtcNow,
                OriginalMessageData = new byte[] { 0x0A, 0x0B, 0x0C },  
                Priority = 1  
            };

            var message2 = new MessageModel
            {
                Id = Guid.NewGuid(),
                Payload = new byte[] { 0x01, 0x02, 0x03 },  
                TimeStamp = DateTime.UtcNow,
                OriginalMessageData = new byte[] { 0x0A, 0x0B, 0x0C },  
                Priority = 1  
            };

            subscriber1.ReceiveMessage(message1);
            subscriber2.ReceiveMessage(message2);

            var topics = TopicManager.ListTopics();
                Console.WriteLine("Topics:");
                foreach (var t in topics)
                {
                    Console.WriteLine($"- {t.TopicName}");
                }

        }
    }
}