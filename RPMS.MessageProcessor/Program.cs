
using Microsoft.Azure.EventHubs;
using Microsoft.Azure.EventHubs.Processor;

namespace RPMS.MessageProcessor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var hubName = "rpm-hub";
            var IOTHubConnectionString= "Endpoint=sb://iothub-ns-rpm-hub-17004195-40f201342d.servicebus.windows.net/;SharedAccessKeyName=iothubowner;SharedAccessKey=2ok4PSWscXu2SCCx70L56c6L6Q48lM1f97Gr37HWhEs=;EntityPath=rpm-hub";
            var storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=storageaccountforrhms;AccountKey=/E3FvS7HsvXik3tVWPT7rSRax7lyP3t9se4Ia+SK3qJzJERbR6ru5Twj8mTEbOGvpJ7QYeBXUkqBvMe3zObPlg==;EndpointSuffix=core.windows.net";
            var storageContainerName = "message-processor-host";
            var consumerGroupName = PartitionReceiver.DefaultConsumerGroupName;
            var processor = new EventProcessorHost(hubName, consumerGroupName, IOTHubConnectionString, 
                storageConnectionString, storageContainerName);
            await processor.RegisterEventProcessorAsync<LoggingEventProcessor>();
            Console.WriteLine("Event Processor Started, press enter to exit...");
            Console.ReadLine();
            await processor.UnregisterEventProcessorAsync();

            
        }
    }
}