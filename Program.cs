using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenAI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        string model = config["ModelName"] 
        string key = config["OpenAIKey"]

        IChatClient chatClient = 
            new OpenAIClient(key).GetChatClient(model).AsIChatClient();

        var chatHistory = new List<ChatMessage>
        {
            new ChatMessage(ChatRole.System, """
                You are a friendly book enthusiast who helps people discover books they will enjoy.
                You introduce yourself when first saying hello.
                When helping people out, you always ask them for this information
                to inform the book recommendation you provide:

                1. The genre or topic they are interested in
                2. The reading depth or intensity they are looking for

                You will then provide three book suggestions that vary in length or complexity
                after you get that information. You will also share an interesting fact about
                the author or book when making a recommendation. At the end of your
                response, ask if there is anything else you can help with. """)
        };

        while (true)
        {
            Console.WriteLine("Your prompt:");
            string? userPrompt = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userPrompt))
            {
                chatHistory.Add(new ChatMessage(ChatRole.User, userPrompt));

                Console.WriteLine("AI Response:");
                string response = "";

                await foreach (ChatResponseUpdate item in 
                    chatClient.GetStreamingResponseAsync(chatHistory))
                {
                    Console.Write(item.Text);
                    response += item.Text;
                }
                chatHistory.Add(new ChatMessage(ChatRole.Assistant, response));
                Console.WriteLine();
            }
        }
    }
}
