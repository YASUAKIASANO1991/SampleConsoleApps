using SampleConsoleApp;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var chatgpt = new ChatGPT();
            var input = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(input))
            {
                await chatgpt.getChatGPTResponse(input);
                Console.WriteLine(chatgpt.resmessage);
            }     
        }

        catch(Exception e)
        {
            Console.WriteLine($"Error:{e.Message}");
        }        
    }
}