using Microsoft.Extensions.Configuration;

namespace Authentication_UI.Tools;

public static class ConfigurationHelper
{
    private static IConfiguration? _configuration;

    public static IConfiguration Configuration
    {
        get
        {
            if (_configuration == null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                _configuration = builder.Build();
            }

            return _configuration;
        }
    }

    public static string GetOpenAiApiKey()
    {
        var apiKey = Configuration["OpenAI:ApiKey"];

        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException(
                "OpenAI API Key nicht konfiguriert. Bitte in appsettings.json eintragen.");
        }

        return apiKey;
    }
}
