 using System.Text.Json;
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

    public async Task<string> GetResponseWithInformationAsync()
    {
        var client = new ChatClient(Model, ApiKey);

        var projectTools = new ProjectTools(@"C:\privates projekt\Backend\AuthenticationWebApp\Authentication_Data");

        var readFileTool = ChatTool.CreateFunctionTool(
            functionName: "ReadFile",
            functionDescription: "Liest eine Datei aus dem Projekt.",
            functionParameters: BinaryData.FromString("""
                                                      {
                                                          "type":"object",
                                                          "properties":
                                                          {
                                                              "path":
                                                              {
                                                                  "type":"string",
                                                                  "description":"Relativer Pfad"
                                                              }
                                                          },
                                                          "required":["path"]
                                                      }
                                                      """));

        var options = new ChatCompletionOptions();
        options.Tools.Add(readFileTool);

        List<ChatMessage> messages =
        [
            new UserChatMessage(Prompt)
        ];

        var response = await client.CompleteChatAsync(messages, options);

        var message = response.Value;

        // Keine Tool-Aufrufe mehr → Antwort zurückgeben
        if (message.ToolCalls.Count == 0)
        {
            return message.Content[0].Text;
        }

        // Assistant-Antwort speichern
        messages.Add(new AssistantChatMessage(message));

        foreach (var toolCall in message.ToolCalls)
        {
            if (toolCall.FunctionName == "ReadFile")
            {
                using var json =
                    JsonDocument.Parse(toolCall.FunctionArguments);

                var path =
                    json.RootElement.GetProperty("path").GetString()!;

                var fileContent =
                    projectTools.ReadFile(path);

                messages.Add(
                    new ToolChatMessage(
                        toolCall.Id,
                        fileContent));
            }
        }
    }
}
