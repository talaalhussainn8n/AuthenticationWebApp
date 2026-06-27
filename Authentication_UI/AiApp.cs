using Authentication_Data;
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
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
