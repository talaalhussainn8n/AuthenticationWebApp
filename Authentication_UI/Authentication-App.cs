using System.Security.Cryptography;
using System.Text;
using AuthenticationData;
using AuthenticationUI.Tools;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        FillComboBox();
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
        var login = new Login(
            tbxUsername.Text,
            tbxEmail.Text,
            tbxTelefonnummer.Text,
            tbxPasswort.Text,
            cmbBenutzer.SelectedText);

        var identity = new IdentityUser
        {
            UserName = login.Username,
            Email = login.EmailAdresse,
            PhoneNumber = login.Phonenummer,
            PasswordHash = Login.GenerateHashedPassword(login.Password),
            NormalizedUserName = login.Username.ToUpperInvariant(),
        };

        tbxBearerToken.Text = JwtTokenTool.GenerateJwtToken(Encoding.UTF8.GetBytes(tbxVerschluesselung.Text), identity,
            DateTime.Parse(dtExpires.Text), tbxAudience.Text);

        btnGenerate.Enabled = false;
        btnDelete.Enabled = true;
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

    private void cbShow_CheckedChanged(object sender, EventArgs e)
    {
        if (cbShow.Checked)
        {
            tbxPasswort.UseSystemPasswordChar = true;
        }
        else
        {
            tbxPasswort.UseSystemPasswordChar = false;
        }
    }

    private void FillComboBox()
    {
        var user = new List<string>
        {
            "Benutzer",
            "Admin"
        };

        foreach (var item in user)
        {
            cmbBenutzer.Items.Add(item);
        }
    }
}
