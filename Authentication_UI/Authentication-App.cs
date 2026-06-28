using System.Text;

namespace AuthenticationUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void neuStartenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"Möchten Sie die Anwendung neu starten?", @"Neu starten", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Restart();
        }
    }

    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"Möchten Sie die Anwendung wirklich beenden?", @"Beenden", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void aIToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aiApp = new AiApp();
        aiApp.ShowDialog();
    }

    private void btnVerschluesseln_Click(object sender, EventArgs e)
    {
        tbxVerschluesselung.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(tbxKey.Text));
    }
}
