﻿using System;
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
                Token = "OTMyMzA3OTIwMTE1MzUxNjMz.YeRFaQ.atrn1wj1_VfTMguzh1od9_RSerY",
                TokenType = TokenType.Bot,

            });

            commands = discord.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefix = "/",
                CaseSensitive = false,


            });
            commands.RegisterCommands<MyCommands>();

            interactivity = discord.UseInteractivity(new InteractivityConfiguration());

            await discord.ConnectAsync();

            await Task.Delay(-1);



        }

    }
    public class MyCommands
    {
        [Command("nkkmhelp")]
        public async Task nkkmhelp(CommandContext commandInfo)
        {
            //surasau gifus
            string[] pasisveikinimogifai;
            pasisveikinimogifai = new string[]
                {
                "https://tenor.com/view/hello-there-private-from-penguins-of-madagascar-hi-wave-hey-there-gif-16043627",
                "https://tenor.com/view/quby-chan-hi-wave-hello-hi-there-gif-17010845",
                "https://tenor.com/view/hello-there-baby-yoda-mandolorian-hello-gif-20136589",
                "https://tenor.com/view/hello-gif-19947459",
                "https://tenor.com/view/hello-hi-minion-gif-16235329",
                "https://tenor.com/view/hi-hello-smile-happy-doggie-gif-14181971"
                };
            //naudoju komanda kuri sumeto bet kaip juos
            var pasisveikinimogifukai = new Random().Next(pasisveikinimogifai.Length);

            string randomgifas = pasisveikinimogifai[pasisveikinimogifukai];

            await commandInfo.RespondAsync(randomgifas);
            await commandInfo.RespondAsync($" Labas {commandInfo.User.Mention}, jei nori sužinoti daugiau apie mane rašyk /kasas\a Beto galime sužaisti klausimyna, jei  nori rašyk /klausimynas\n,jei nori galim sužaisti coin flipa /flip");

        }
        [Command("kasas")]
        public async Task kasas(CommandContext commandInfo)
        {
            await commandInfo.RespondAsync($" Labas {commandInfo.User.Mention}, aš esu  Dominyko pirmas botas kuris moka atsakinėti į komandas ir žaisti paprastus žaidimus ");
        }

        [Command("flip")]

        public async Task flip(CommandContext commandInfo)
        {
            await commandInfo.RespondAsync($" {commandInfo.User.Mention}, rinkis herbas ar skaicius ");
            var interactivity = commandInfo.Client.GetInteractivityModule();
            string[] coinas;
            coinas = new string[] { "herbas", "skaicius" };
            var coinpuse = new Random().Next(coinas.Length);
            string randomcoinasbot = coinas[coinpuse];
            var zinute = await interactivity.WaitForMessageAsync(response => response.Content == "herbas" || response.Content == "skaicius", TimeSpan.FromMinutes(1));
            string zmogauspuse = zinute.Message.Content.ToString();
            if (zinute != null)
            {
                switch (zmogauspuse)
                {
                    case "herbas":
                        switch (randomcoinasbot)
                        {
                            case "skaicius":
                                await commandInfo.RespondAsync(randomcoinasbot + "\n\n As laimejau!");
                                break;
                            case "herbas":
                                await commandInfo.RespondAsync(randomcoinasbot + "\n\n Tu laimejai!");
                                break;
                        }
                        break;
                    case "skaicius":
                        switch (randomcoinasbot)
                        {
                            case "skaicius":
                                await commandInfo.RespondAsync(randomcoinasbot + "\n\n  Tu laimejai!");
                                break;
                            case "herbas":
                                await commandInfo.RespondAsync(randomcoinasbot + "\n\n As laimejau!");
                                break;

                        }
                        break;



























                }












            }


































        }












































    }
}
