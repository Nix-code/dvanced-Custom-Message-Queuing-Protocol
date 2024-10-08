## Distributed Message Queuing Protocol for Message Broker System from Scratch

This project involves the design and implementation of a custom message broker system from scratch, based on a distributed message queuing protocol. The system aims to facilitate efficient, reliable, and scalable communication between services in a distributed environment. Key features include topic-based publish/subscribe messaging, robust message routing, durable message storage, and high availability through clustering. This project will also incorporate security measures such as authentication, authorization, and encryption, along with comprehensive monitoring and management tools to ensure optimal performance and reliability.

## Initial Design 
![Message Broker Design](docs/high-level-design.png)

### Key Features

Key Features:

Message Queuing: Support for reliable message enqueueing and dequeueing.

Topic-Based Pub/Sub: Enable publish/subscribe messaging using topics for flexible communication patterns.

Routing: Intelligent message routing to appropriate queues or topics.

Durable Storage: Options for persistent message storage to ensure message reliability.

Scalability: Clustering and load balancing for handling high traffic and ensuring fault tolerance.

Security: Implement authentication, authorization, and encryption to secure message exchanges.

### Outcome

Deep understanding of distributed systems, networking, and messaging protocols along with load balancing, Authentication, Authorization, Encryption.

### Theory 

- Producers:
        Send messages to Topics. Producers are responsible for generating and publishing messages.

- Topics:
        Hold and route messages. In some messaging systems, a Topic is used for publish-subscribe messaging, where multiple subscribers can receive messages sent to a single topic.
        Typically, a topic does not store messages for a long time but immediately routes them to appropriate queues or subscribers, depending on the subscription model.
        
- Persistence/Queueing: In certain configurations, topics can temporarily store or queue messages for durability until they are routed to subscribers or consumers.

- Load Balancer:
        Balances the traffic between producers and subscribers.
        Helps distribute messages efficiently among Broker Instances or subscribers, especially under high load, ensuring that no single component becomes overwhelmed.

- Queues:
        Store messages until they are consumed by subscribers. Queues ensure that messages are durable and can be processed at the right time, particularly in a point-to-point communication model.
        Subscribers can pull or receive messages from the queue based on their availability.

- Broker Instances:
        Manage the queues and other resources.
        Ensure that messages are delivered efficiently between producers and subscribers. They are responsible for routing, storing, and forwarding messages.
        Multiple broker instances are usually deployed in clusters to provide high availability and fault tolerance.

- TCP Communication:
        Handles reliable communication between the components (producers, brokers, subscribers). TCP ensures that messages are transmitted accurately and in order, even over unreliable networks.

- Routing Algorithms:
        Ensure efficient message delivery by determining how messages are routed between brokers, queues, and subscribers. Common routing algorithms include round-robin, least connections, or more sophisticated strategies like hash-based routing to ensure load balancing and proper message distribution.

This design is common in systems like RabbitMQ, Kafka, and ActiveMQ, which support robust, scalable, and reliable messaging across distributed systems. Your system could adopt these concepts, with customizations based on your specific needs.