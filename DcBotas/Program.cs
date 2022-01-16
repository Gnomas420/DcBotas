using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity;
using DSharpPlus.Entities;
using HSNXT.DSharpPlus.Extended.Emoji;

namespace DcBotas
{
    internal class Program
    {
        static DiscordClient discord;
        static CommandsNextModule commands;
        static InteractivityModule interactivity;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        { 
           discord = new DiscordClient(new DiscordConfiguration()
           { 
           Token = "OTMyMzA3OTIwMTE1MzUxNjMz.YeRFaQ.CaNYO91Hz-pwLDo38ZRoxC62FRo",
           TokenType = TokenType.Bot,
           
           });

            commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
              StringPrefix = "/",
              CaseSensitive = false,


            });
            commands.RegisterCommands<MyCommands>();
          
            await discord.ConnectAsync();

            await Task.Delay(-1);



        }
 
   }
    public class MyCommands
    { 
    }












































}
