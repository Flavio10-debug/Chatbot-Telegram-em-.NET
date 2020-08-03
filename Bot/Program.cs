using System;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;

namespace Bot
{
    class Program
    {

        private static readonly TelegramBotClient botClient = new TelegramBotClient("1261300783:AAGMwa7uPwhVWyDIm6GEpHc0nowk6g3aJ4Q");

        static void Main(string[] args)
        {

            botClient.OnMessage += BotClient_OnMessage;
            botClient.OnMessageEdited += BotClient_OnMessage;
        

            botClient.StartReceiving();
            Thread.Sleep(Timeout.Infinite);
            botClient.StopReceiving();

            

        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                if (e.Message.Text.ToUpper() == "OI")

                    botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Ola, Seja Bem-Vindo {e.Message.From.FirstName} \n se quiser sabere o valor da sua fatura? digite fatura ");

                //botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Ola, Seja Bem-Vindo {e.Message.From.FirstName} \n qual é sua duvida? digite fatura ");
                else if (e.Message.Text.ToUpper() == "Fatura")

                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "teste : \n R$230,00 ");

                else
                {

                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "O valor da sua Fatura é : \n R$230,00, estamos trabalhando para novas " +
                        "funcionalidades ");


                }



            }

        }
        



    }
}
