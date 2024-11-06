using System;
using System.Threading.Tasks;
using Microsoft.Extensions.AI;

namespace ChatApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("odpoveď na výzvu What is AI?");
            await Chat();
        }

        public static async Task Chat()
        {
            var endpoint = new Uri("http://localhost:11434/");
            var modelId = "llama3.2";

            IChatClient client = new OllamaChatClient(endpoint, modelId: modelId);

            var response = await client.CompleteAsync("What is AI?");

            Console.WriteLine(response.Message);
        }
    }
}

