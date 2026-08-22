namespace AuthenticationUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dateiToolStripMenuItem = new ToolStripMenuItem();
            neuStartenToolStripMenuItem = new ToolStripMenuItem();
            beendenToolStripMenuItem = new ToolStripMenuItem();
            aIToolStripMenuItem = new ToolStripMenuItem();
            grpClaims = new GroupBox();
            cmbBenutzer = new ComboBox();
            lblBenutzer = new Label();
            cbShow = new CheckBox();
            tbxTelefonnummer = new TextBox();
            lablblTelefonnummer = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxPasswort = new TextBox();
            tbxUsername = new TextBox();
            lblPasswort = new Label();
            lblUsername = new Label();
            grpAudience = new GroupBox();
            dtExpires = new DateTimePicker();
            lblExpiers = new Label();
            tbxAudience = new RichTextBox();
            tbxVerschluesselung = new TextBox();
            label2 = new Label();
            grpEingabe = new GroupBox();
            btnErstellen = new Button();
            lblBearerToken = new Label();
            tbxBearerToken = new RichTextBox();
            btnGenerate = new Button();
            btnCopy = new Button();
            btnDelete = new Button();
            menuStrip1.SuspendLayout();
            grpClaims.SuspendLayout();
            grpAudience.SuspendLayout();
            grpEingabe.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, aIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(726, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuStartenToolStripMenuItem, beendenToolStripMenuItem });
            dateiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateiToolStripMenuItem.ForeColor = SystemColors.ActiveCaption;
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new Size(60, 24);
            dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuStartenToolStripMenuItem
            // 
            neuStartenToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            neuStartenToolStripMenuItem.ForeColor = SystemColors.ActiveCaption;
            neuStartenToolStripMenuItem.Name = "neuStartenToolStripMenuItem";
            neuStartenToolStripMenuItem.Size = new Size(175, 26);
            neuStartenToolStripMenuItem.Text = "Neu starten";
            neuStartenToolStripMenuItem.Click += neuStartenToolStripMenuItem_Click;
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beendenToolStripMenuItem.ForeColor = SystemColors.ActiveCaption;
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(175, 26);
            beendenToolStripMenuItem.Text = "Beenden";
            beendenToolStripMenuItem.Click += beendenToolStripMenuItem_Click;
            // 
            // aIToolStripMenuItem
            // 
            aIToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            aIToolStripMenuItem.ForeColor = SystemColors.ActiveCaption;
            aIToolStripMenuItem.Name = "aIToolStripMenuItem";
            aIToolStripMenuItem.Size = new Size(39, 24);
            aIToolStripMenuItem.Text = "AI";
            aIToolStripMenuItem.Click += aIToolStripMenuItem_Click;
            // 
            // grpClaims
            // 
            grpClaims.Controls.Add(cmbBenutzer);
            grpClaims.Controls.Add(lblBenutzer);
            grpClaims.Controls.Add(cbShow);
            grpClaims.Controls.Add(tbxTelefonnummer);
            grpClaims.Controls.Add(lablblTelefonnummer);
            grpClaims.Controls.Add(tbxEmail);
            grpClaims.Controls.Add(lblEmail);
            grpClaims.Controls.Add(tbxPasswort);
            grpClaims.Controls.Add(tbxUsername);
            grpClaims.Controls.Add(lblPasswort);
            grpClaims.Controls.Add(lblUsername);
            grpClaims.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpClaims.ForeColor = SystemColors.ActiveCaption;
            grpClaims.Location = new Point(29, 258);
            grpClaims.Name = "grpClaims";
            grpClaims.Size = new Size(685, 273);
            grpClaims.TabIndex = 0;
            grpClaims.TabStop = false;
            grpClaims.Text = "Claims";
            // 
            // cmbBenutzer
            // 
            cmbBenutzer.ForeColor = SystemColors.ActiveCaption;
            cmbBenutzer.FormattingEnabled = true;
            cmbBenutzer.Location = new Point(152, 219);
            cmbBenutzer.Name = "cmbBenutzer";
            cmbBenutzer.Size = new Size(432, 29);
            cmbBenutzer.TabIndex = 20;
            // 
            // lblBenutzer
            // 
            lblBenutzer.AutoSize = true;
            lblBenutzer.Location = new Point(24, 222);
            lblBenutzer.Name = "lblBenutzer";
            lblBenutzer.Size = new Size(89, 21);
            lblBenutzer.TabIndex = 19;
            lblBenutzer.Text = "Benutzer";
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.Location = new Point(600, 122);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(18, 17);
            cbShow.TabIndex = 18;
            cbShow.UseVisualStyleBackColor = true;
            cbShow.CheckedChanged += cbShow_CheckedChanged;
            // 
            // tbxTelefonnummer
            // 
            tbxTelefonnummer.ForeColor = SystemColors.ActiveCaption;
            tbxTelefonnummer.Location = new Point(152, 164);
            tbxTelefonnummer.Name = "tbxTelefonnummer";
            tbxTelefonnummer.Size = new Size(432, 28);
            tbxTelefonnummer.TabIndex = 17;
            // 
            // lablblTelefonnummer
            // 
            lablblTelefonnummer.AutoSize = true;
            lablblTelefonnummer.Location = new Point(24, 171);
            lablblTelefonnummer.Name = "lablblTelefonnummer";
            lablblTelefonnummer.Size = new Size(122, 21);
            lablblTelefonnummer.TabIndex = 16;
            lablblTelefonnummer.Text = "Tel. Nummer";
            // 
            // tbxEmail
            // 
            tbxEmail.ForeColor = SystemColors.ActiveCaption;
            tbxEmail.Location = new Point(152, 71);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(432, 28);
            tbxEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(87, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 21);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // tbxPasswort
            // 
            tbxPasswort.ForeColor = SystemColors.ActiveCaption;
            tbxPasswort.Location = new Point(152, 115);
            tbxPasswort.Name = "tbxPasswort";
            tbxPasswort.Size = new Size(432, 28);
            tbxPasswort.TabIndex = 12;
            // 
            // tbxUsername
            // 
            tbxUsername.ForeColor = SystemColors.ActiveCaption;
            tbxUsername.Location = new Point(152, 27);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(432, 28);
            tbxUsername.TabIndex = 6;
            // 
            // lblPasswort
            // 
            lblPasswort.AutoSize = true;
            lblPasswort.Location = new Point(43, 122);
            lblPasswort.Name = "lblPasswort";
            lblPasswort.Size = new Size(91, 21);
            lblPasswort.TabIndex = 1;
            lblPasswort.Text = "Passwort";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(46, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 21);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // grpAudience
            // 
            grpAudience.Controls.Add(dtExpires);
            grpAudience.Controls.Add(lblExpiers);
            grpAudience.Controls.Add(tbxAudience);
            grpAudience.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAudience.ForeColor = SystemColors.ActiveCaption;
            grpAudience.Location = new Point(29, 549);
            grpAudience.Name = "grpAudience";
            grpAudience.Size = new Size(654, 234);
            grpAudience.TabIndex = 1;
            grpAudience.TabStop = false;
            grpAudience.Text = "Audience";
            // 
            // dtExpires
            // 
            dtExpires.Location = new Point(123, 178);
            dtExpires.Name = "dtExpires";
            dtExpires.Size = new Size(437, 28);
            dtExpires.TabIndex = 8;
            // 
            // lblExpiers
            // 
            lblExpiers.AutoSize = true;
            lblExpiers.Location = new Point(27, 177);
            lblExpiers.Name = "lblExpiers";
            lblExpiers.Size = new Size(77, 21);
            lblExpiers.TabIndex = 7;
            lblExpiers.Text = "Expires";
            // 
            // tbxAudience
            // 
            tbxAudience.ForeColor = SystemColors.ActiveCaption;
            tbxAudience.Location = new Point(30, 27);
            tbxAudience.Name = "tbxAudience";
            tbxAudience.Size = new Size(530, 141);
            tbxAudience.TabIndex = 0;
            tbxAudience.Text = "";
            // 
            // tbxVerschluesselung
            // 
            tbxVerschluesselung.ForeColor = SystemColors.ActiveCaption;
            tbxVerschluesselung.Location = new Point(160, 43);
            tbxVerschluesselung.Name = "tbxVerschluesselung";
            tbxVerschluesselung.ReadOnly = true;
            tbxVerschluesselung.Size = new Size(432, 28);
            tbxVerschluesselung.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 9;
            label2.Text = "Schlüssel";
            // 
            // grpEingabe
            // 
            grpEingabe.Controls.Add(btnErstellen);
            grpEingabe.Controls.Add(tbxVerschluesselung);
            grpEingabe.Controls.Add(label2);
            grpEingabe.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            grpEingabe.ForeColor = SystemColors.ActiveCaption;
            grpEingabe.Location = new Point(29, 49);
            grpEingabe.Name = "grpEingabe";
            grpEingabe.Size = new Size(639, 143);
            grpEingabe.TabIndex = 11;
            grpEingabe.TabStop = false;
            grpEingabe.Text = "Eingabe";
            // 
            // btnErstellen
            // 
            btnErstellen.Location = new Point(445, 94);
            btnErstellen.Name = "btnErstellen";
            btnErstellen.Size = new Size(147, 29);
            btnErstellen.TabIndex = 11;
            btnErstellen.Text = "Erstellen";
            btnErstellen.UseVisualStyleBackColor = true;
            btnErstellen.Click += btnVerschluesseln_Click;
            // 
            // lblBearerToken
            // 
            lblBearerToken.AutoSize = true;
            lblBearerToken.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblBearerToken.ForeColor = SystemColors.ActiveCaption;
            lblBearerToken.Location = new Point(56, 807);
            lblBearerToken.Name = "lblBearerToken";
            lblBearerToken.Size = new Size(127, 21);
            lblBearerToken.TabIndex = 12;
            lblBearerToken.Text = "Bearer Token";
            // 
            // tbxBearerToken
            // 
            tbxBearerToken.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            tbxBearerToken.ForeColor = SystemColors.ActiveCaption;
            tbxBearerToken.Location = new Point(189, 807);
            tbxBearerToken.Name = "tbxBearerToken";
            tbxBearerToken.Size = new Size(494, 120);
            tbxBearerToken.TabIndex = 13;
            tbxBearerToken.Text = "";
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnGenerate.ForeColor = SystemColors.ActiveCaption;
            btnGenerate.Location = new Point(536, 933);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(147, 29);
            btnGenerate.TabIndex = 14;
            btnGenerate.Text = "Generieren";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnCopy.ForeColor = SystemColors.ActiveCaption;
            btnCopy.Location = new Point(189, 933);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(147, 29);
            btnCopy.TabIndex = 15;
            btnCopy.Text = "Kopieren";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(366, 933);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Löschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(726, 1028);
            Controls.Add(btnDelete);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerate);
            Controls.Add(tbxBearerToken);
            Controls.Add(lblBearerToken);
            Controls.Add(grpEingabe);
            Controls.Add(grpAudience);
            Controls.Add(grpClaims);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bearer Token Generierung";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpClaims.ResumeLayout(false);
            grpClaims.PerformLayout();
            grpAudience.ResumeLayout(false);
            grpAudience.PerformLayout();
            grpEingabe.ResumeLayout(false);
            grpEingabe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuStartenToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
        private GroupBox grpClaims;
        private TextBox tbxName;
        private TextBox tbxOrt;
        private TextBox tbxPlz;
        private TextBox tbxVorname;
        private Label lblOrt;
        private Label lblPosteingang;
        private Label lblGeburtstag;
        private Label lblName;
        private Label lblUsername;
        private DateTimePicker dtGeburtstag;
        private GroupBox grpAudience;
        private RichTextBox tbxAudience;
        private TextBox tbxVerschluesselung;
        private Label label2;
        private GroupBox grpEingabe;
        private Button btnErstellen;
        private Label lblExpiers;
        private DateTimePicker dtExpires;
        private Label lblBearerToken;
        private RichTextBox tbxBearerToken;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox tbxPasswort;
        private TextBox tbxUsername;
        private Label lblPasswort;
        private ToolStripMenuItem aIToolStripMenuItem;
        private Button btnGenerate;
        private Button btnCopy;
        private Button btnDelete;
        private TextBox tbxTelefonnummer;
        private Label lablblTelefonnummer;
        private CheckBox cbShow;
        private Label lblBenutzer;
        private ComboBox cmbBenutzer;
    }
}
