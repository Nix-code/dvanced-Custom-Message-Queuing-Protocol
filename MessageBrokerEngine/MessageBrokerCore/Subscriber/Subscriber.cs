using MessageBrokerEngine.MessageBrokerCore.Models;

namespace MessageBrokerEngine.MessageBrokerCore.Subscriber{

    public class Subscribers{

        public string SubscriberIdenfication {get; set;}

        public void ReceiveMessage(MessageModel message){

            Console.WriteLine($"{SubscriberIdenfication} received message: {message.Id} with content: {message.Payload}");
        }
    }
}