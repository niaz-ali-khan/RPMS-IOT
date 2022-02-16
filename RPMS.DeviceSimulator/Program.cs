using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
 
namespace RPMS.DeviceSimulator
{
    class Program
    {

        const string GlucoseDeviceConnectionString = "HostName=RPM-Hub.azure-devices.net;DeviceId=GlucoseDevice;SharedAccessKey=5VQTCPyzoe7POsEoY+OofNOxKBRmG2pajy/Av0MycOM=";
        static async Task Main(string[] args)
        {
            Console.WriteLine("Initializing Device Simulator");

            var device = DeviceClient.CreateFromConnectionString(GlucoseDeviceConnectionString);
            await device.OpenAsync();
            Console.WriteLine("Device is Connected!");            
            while (true)
            {
                var message = new Message(Encoding.ASCII.GetBytes("Hello from Device Simulator"));
                await device.SendEventAsync(message);
                Console.WriteLine("Message Sent to the cloud!");
                Thread.Sleep(2000);
                Console.ReadKey();
            }
            
        }
    }
}

