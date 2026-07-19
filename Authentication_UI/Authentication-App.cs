using System.Security.Cryptography;
using System.Text;
using AuthenticationData;
using AuthenticationUI.Tools;

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
            Application.Restart();
    }

    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"Möchten Sie die Anwendung wirklich beenden?", @"Beenden", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            Application.Exit();
    }

    private void aIToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var aiApp = new AiApp();
        aiApp.ShowDialog();
    }

    private void btnVerschluesseln_Click(object sender, EventArgs e)
    {
        tbxVerschluesselung.Text = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));

        btnErstellen.Enabled = false;
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(tbxPlz.Text, out var plz) && DateTime.TryParse(dtGeburtstag.Text, out var geburtsdatum))
        {
            var login = new Login(tbxVorname.Text, tbxName.Text, tbxEmail.Text,
                geburtsdatum, plz, tbxOrt.Text);

            tbxBearerToken.Text = JwtTokenTool.GenerateJwtToken(Encoding.UTF8.GetBytes(tbxVerschluesselung.Text), login,
                DateTime.Parse(dtExpires.Text), tbxAudience.Text);

            btnGenerate.Enabled = false;
            btnDelete.Enabled = true;
        }
        else
        {
            MessageBox.Show(@"Bitte geben Sie eine gültige Postleitzahl und Geburtsdatum ein.", @"Fehler", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        tbxBearerToken.Clear();

        btnGenerate.Enabled = true;
        btnDelete.Enabled = false;
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbxBearerToken.Text))
        {
            MessageBox.Show(@"Es gibt keinen Bearer Token zum Kopieren.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Clipboard.SetText(tbxBearerToken.Text, TextDataFormat.Text);
        MessageBox.Show(@"Der Bearer Token wurde in die Zwischenablage kopiert.", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
