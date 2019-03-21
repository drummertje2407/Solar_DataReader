using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


using Discord.Commands;
using Discord.WebSocket;
using Discord;
using System.Reflection;

namespace Solar_DataReader
{
    class DiscordBot
    {
        private DiscordSocketClient client;
        private CommandService commands;
        private IServiceProvider services;

        public async Task Run(string token)
        {
            client = new DiscordSocketClient();
            commands = new CommandService();

            services = new ServiceCollection()
                .AddSingleton(client)
                .AddSingleton(commands)
                .BuildServiceProvider();

            client.Log += Log;
            await RegisterCommands();
            await client.LoginAsync(TokenType.Bot,token);
            await client.StartAsync();
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Form1.instance.Log(msg.Message);
            return Task.CompletedTask;
        }

        private async Task HandleCommands(SocketMessage msg)
        {
            SocketUserMessage message = msg as SocketUserMessage;
            if (message == null || message.Author.IsBot) return;

            int argPos = 0;
            if(message.HasStringPrefix(".", ref argPos) || message.HasMentionPrefix(client.CurrentUser, ref argPos))
            {
                SocketCommandContext context = new SocketCommandContext(client, message);
                IResult result = await commands.ExecuteAsync(context, argPos, services);

                if (!result.IsSuccess) Form1.instance.Log(result.ErrorReason);

            }
        }

        public async Task RegisterCommands()
        {
            client.MessageReceived += HandleCommands;
            await commands.AddModuleAsync(Assembly.GetEntryAssembly(), services);
        }
    }
}
