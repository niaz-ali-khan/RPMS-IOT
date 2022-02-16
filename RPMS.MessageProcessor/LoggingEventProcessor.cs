using Microsoft.Azure.EventHubs;
using Microsoft.Azure.EventHubs.Processor;
using Newtonsoft.Json;
using RPMS.Common;
using System.Text;


namespace RPMS.MessageProcessor
{
    public class LoggingEventProcessor : IEventProcessor
    {
        public Task CloseAsync(PartitionContext context, CloseReason reason)
        {
            Console.WriteLine("LogginEventProcessor closed, closing partition: "+$"'{context.PartitionId}', reason'{reason}'.");
            return Task.CompletedTask;
        }

        public Task OpenAsync(PartitionContext context)
        {
            Console.WriteLine("LogginEventProcessor Opened, processing partition: "+ $"'{context.PartitionId}'");
            return Task.CompletedTask;
        }

        public Task ProcessErrorAsync(PartitionContext context, Exception error)
        {
            Console.WriteLine("LoginEventProcessor error. partition: "+$"'{context.PartitionId}', error: '{error}'.");
            return Task.CompletedTask;
        }

        public Task ProcessEventsAsync(PartitionContext context, IEnumerable<EventData> messages)
        {
            Console.WriteLine($"Batch of event recieved on partition '{context.PartitionId}'.");
            foreach (var message in messages)
            {
                var payload = Encoding.ASCII.GetString(message.Body.Array, message.Body.Offset, message.Body.Count);
                var deviceId = message.SystemProperties["iothub-connection-device-id"];
                Console.WriteLine($"Message received on partition '{context.PartitionId}'," 
                    +$"Device ID: '{deviceId}'" +$"Payload: '{payload}'");

                var telemetry = JsonConvert.DeserializeObject<Telemetry>(payload);
                if (telemetry.HealthLevel == Level.High)
                {
                    Console.WriteLine("Glucose Level is high, user should be informed about the situation");
                    SendResponseForHighGlucoseLevel(telemetry);
                   
                    
                }
                else if (telemetry.HealthLevel == Level.Emergency)
                {
                    Console.WriteLine("Glucose Level is in emergency state, user should be informed about the situation");
                    SendResponseForEmergency(telemetry);
                }
            }
            return context.CheckpointAsync();
        }

        private void SendResponseForEmergency(Telemetry telemetry)
        {
            //In a real world application senario, we would have sent a notification to the users, 
            Console.WriteLine("Apropriate Response is initiated for !"+ $"Patient:'{telemetry.Patient}'" +$"DeviceId: ''{telemetry.Device}");
        }

        private void SendResponseForHighGlucoseLevel(Telemetry telemetry)
        {
            //In a real world application senario, we would have sent a notification to the users, 
            Console.WriteLine("Apropriate Response is initiated for !" + $"Patient:'{telemetry.Patient}'" + $"DeviceId: ''{telemetry.Device}");
        }
    }
}