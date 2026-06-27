using Authentication_Data;

namespace Authentication_UI
{
    public partial class AiApp : Form
    {
        public AiApp()
        {
            InitializeComponent();

            FillModels();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

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

            cmbModels.Items.AddRange(models);
        }
    }
}
