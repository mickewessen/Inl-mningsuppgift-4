using Microsoft.Azure.Devices.Client;
using SharedLibraries.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IotDevice_UWP
{
    class Program
    {
        private static readonly string _conn = "HostName=ec-win-iothub.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=3zsfBvJy2yTIaBEoTQpnnbD1jX4Z1Juz3g8jhLSjX8M=";

        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);


        static void Main(string[] args)
        {

            DeviceServices.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceServices.RecieveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
    }
}
