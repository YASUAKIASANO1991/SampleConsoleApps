using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    public class ChatGPT
    {
        public string? apiKey { get; set; }
        public string? resmessage { get; set; }

        public ChatGPT()
        {
            this.apiKey = Environment.GetEnvironmentVariable("ChatGPT_APIKey");
        }

        public async Task getChatGPTResponse(string reqmessage)
        {
            var api = new OpenAI_API.OpenAIAPI(this.apiKey);
            var chat = api.Chat.CreateConversation();

            chat.AppendUserInput(reqmessage);
            resmessage = await chat.GetResponseFromChatbotAsync();
        }
    }
}
