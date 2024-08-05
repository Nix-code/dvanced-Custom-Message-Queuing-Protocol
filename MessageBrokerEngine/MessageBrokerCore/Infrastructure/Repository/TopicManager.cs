
using System.Collections.Concurrent;
using MessageBrokerEngine.MessageBrokerCore.Common;
using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Infrastructure.Repository
{

    public class TopicManager : ITopicManager
    {
        private readonly ConcurrentDictionary<string, TopicModel> _topics = new();

        public async Task CreateTopicAsync(string topicName, TopicModel topic)
        {
            _topics.TryAdd(topicName, topic);
            await Task.CompletedTask;
        }

        public Task DeleteTopicAsync(string topicName)
        {
            _topics.TryRemove(topicName, out _);
            return Task.CompletedTask;
        }

        // Get the number of created Topics with the subscribers and message Traffic


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TopicModel> ListTopics()
        {
            return _topics.Values;
        }
    }
}