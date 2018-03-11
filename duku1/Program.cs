using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.Net;
using Discord.Webhook;




namespace duku1
{
    public class Program
    {
        private DiscordSocketClient _client;
      
       

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();
         

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            
            _client.Log += Log;
            _client.MessageReceived += MessageReceived;

            string token = ""; // Remember to keep this private!
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            

            // Block this task until the program is closed.
            await Task.Delay(-1);
            
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "!papaj")
            {
                await message.Channel.SendMessageAsync("co");
            }
            if (message.Content == "!duku")
            {
                await message.Channel.SendMessageAsync("Władca Dukowizny, to ja");
            }
            if (message.Content == "!yt")
            {
                await message.Channel.SendMessageAsync("https://www.youtube.com/channel/UCZoEcEyvYDvoR7LRvl81ALg");
            }
            if (message.Content == "!steam")
            {
                await message.Channel.SendMessageAsync("http://steamcommunity.com/profiles/76561198056314375");
            }
            if (message.Content == "!twitch")
            {
                await message.Channel.SendMessageAsync("https://www.twitch.tv/hoojston");
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
            
        }
      
        



    }
}
