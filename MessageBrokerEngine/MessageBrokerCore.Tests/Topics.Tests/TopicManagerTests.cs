using MessageBrokerEngine.MessageBrokerCore.Common;
using MessageBrokerEngine.MessageBrokerCore.Infrastructure.Repository;
using MessageBrokerEngine.MessageBrokerCore.Models;
namespace MessageBrokerEngine.MessageBrokerCore.Tests.Topics
{
    [TestFixture]
    public class TopicManagerTests
    {
        private TopicManager _topicManager;

        [SetUp]
        public void SetUp(){
            _topicManager = new TopicManager();
        }

        [Test]
        public async Task CreateTopicAsync_ShouldCreatTopic(){
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

            await _topicManager.CreateTopicAsync(topicName, topic);
            var topics = _topicManager.ListTopics();

            Assert.IsTrue(topics.Any(t => t.TopicName == topicName));
           
        }
         
    }
}
