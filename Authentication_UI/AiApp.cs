using Authentication_Data;
using Authentication_UI.Tools;

namespace Authentication_UI
{
    public partial class AiApp : Form
    {
        public AiApp()
        {
            InitializeComponent();

            FillModels();
        }

        private void btnGenerate_Click()
        {
            var prompt = tbxPrompt.Text;
            var model = $"{cmbModels.SelectedItem}";

            var chatBotClient = new ChatBot(model, prompt);

            tbxAusgabe.Text = Task.Run(chatBotClient.GetResponseAsync).Result;
        }

        private void FillModels()
        {
            var models = new List<string>
            {
                OpenAiModels.Gpt5,
                OpenAiModels.Gpt5Mini,
                OpenAiModels.Gpt5Nano,
                OpenAiModels.O3,
                OpenAiModels.O4Mini
            };

            foreach (var model in models)
            {
                cmbModels.Items.Add(model);
            }
        }
    }
}
