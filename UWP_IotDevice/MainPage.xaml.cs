using Microsoft.Azure.Devices.Client;
using SharedLibraries.Services;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_IotDevice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=ec-win-iothub.azure-devices.net;DeviceId=Inlamningsuppgift4;SharedAccessKey=0k6iJcjd4FQlOuRkD+TxI9m6CrTmaOUEflu1cRVM1l0=", TransportType.Mqtt);


        private void btnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeviceServices.SendMessageAsync(deviceClient).GetAwaiter();
            }
            catch { }



        }
    }
}
