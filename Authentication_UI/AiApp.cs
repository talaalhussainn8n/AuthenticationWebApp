using AuthenticationData;
using AuthenticationUI.Tools;

namespace AuthenticationUI
{
    public partial class AiApp : Form
    {
        public AiApp()
        {
            InitializeComponent();

            FillModels();
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

            cmbModels.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var prompt = tbxPrompt.Text;
            var model = $"{cmbModels.SelectedItem}";

            if(string.IsNullOrEmpty(prompt) || string.IsNullOrEmpty(model))
            {
                MessageBox.Show(@"Please enter a prompt and select a model.", @"Textboxen leer", MessageBoxButtons.OKCancel);
                return;
            }

            var chatBot = new ChatBot(model, prompt);
            tbxOutput.Text = Task.Run(chatBot.GetResponseWithInformationAsync).Result;

            tbxPrompt.Clear();
        }
    }
}
