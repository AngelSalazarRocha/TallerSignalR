using Microsoft.AspNetCore.SignalR;

namespace TallerSignalRProject.Hubs.Messages
{
    public class MessageHub : Hub
    {
        public async void Send(string param1, string param2)
        {
            await Clients.All.SendAsync("Receive", param1, param2);
        }
    }
}
