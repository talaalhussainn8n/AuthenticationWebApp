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
        
        var createClassTool = ChatTool.CreateFunctionTool(
            functionName: "CreateClass",
            functionDescription: Prompt,
            functionParameters: BinaryData.FromString("""
                                                      {
                                                          "type": "object",
                                                          "properties": {
                                                              "className": {
                                                                  "type": "string",
                                                                  "description": "Name der Klasse"
                                                              },
                                                              "namespace": {
                                                                  "type": "string",
                                                                  "description": "Namespace der Klasse (z.B. AuthenticationData)"
                                                              },
                                                              "path": {
                                                                  "type": "string",
                                                                  "description": "Absoluter Pfad wo die Datei erstellt werden soll"
                                                              },
                                                              "properties": {
                                                                  "type": "array",
                                                                  "description": "Liste von Properties die zur Klasse hinzugefügt werden sollen",
                                                                  "items": {
                                                                      "type": "object",
                                                                      "properties": {
                                                                          "name": { 
                                                                              "type": "string",
                                                                              "description": "Name des Property"
                                                                          },
                                                                          "type": { 
                                                                              "type": "string",
                                                                              "description": "C# Datentyp des Property (z.B. string, int, bool)"
                                                                          }
                                                                      },
                                                                      "required": ["name", "type"]
                                                                  }
                                                              }
                                                          },
                                                          "required": ["className", "namespace", "path"]
                                                      }
                                                      """));

        var options = new ChatCompletionOptions();
        options.Tools.Add(createClassTool);

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
            if (toolCall.FunctionName == "CreateClass")
            {
                using var json = JsonDocument.Parse(toolCall.FunctionArguments);
                var className = json.RootElement.GetProperty("className").GetString()!;
                var namespaceName = json.RootElement.GetProperty("namespace").GetString()!;
                var path = json.RootElement.GetProperty("path").GetString()!;

                // Properties parsen (optional)
                var properties = new List<(string Name, string Type)>();
                if (json.RootElement.TryGetProperty("properties", out var propsElement))
                {
                    foreach (var prop in propsElement.EnumerateArray())
                    {
                        var propName = prop.GetProperty("name").GetString()!;
                        var propType = prop.GetProperty("type").GetString()!;
                        properties.Add((propName, propType));
                    }
                }

                var result = projectTools.CreateClass(className, namespaceName, path, properties);
                messages.Add(new ToolChatMessage(toolCall.Id, result));
            }
        }

        // Zweite Anfrage mit Tool-Ergebnissen
        var finalResponse = await client.CompleteChatAsync(messages, options);
        return finalResponse.Value.Content[0].Text;
    }
}
