
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.Threading.Tasks;


namespace CircleApp.Hubs
{
    public class ChatHub : Hub
    {
        private static List<string> messages = new List<string>();
        public async Task SendMessage(string user, string message)
        {
            var timestamp = DateTime.UtcNow.ToString("o");
            var formattedMessage = $"[{timestamp}] {user}: {message}";

            messages.Add(formattedMessage);

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
