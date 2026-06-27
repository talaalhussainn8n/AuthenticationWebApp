 using OpenAI.Chat;

namespace AuthenticationUI.Tools;

public class ChatBot(string model, string prompt)
{
    public string Model { get; set; } = model;

    public string Prompt { get; set; } = prompt;

    public string ApiKey { get; } = ConfigurationHelper.GetOpenAiApiKey();

    public async Task<string> GetResponseAsync()
    {
        var openAiClient = new ChatClient(Model, ApiKey);
       
        var response = await openAiClient.CompleteChatAsync(Prompt);
        return response.Value.Content[0].Text;
    }
}
