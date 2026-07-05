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
            tbxEmail = new TextBox();
            lblEmail = new Label();
            dtGeburtstag = new DateTimePicker();
            tbxName = new TextBox();
            tbxOrt = new TextBox();
            tbxPlz = new TextBox();
            tbxVorname = new TextBox();
            lblOrt = new Label();
            lblPosteingang = new Label();
            lblGeburtstag = new Label();
            lblName = new Label();
            lblVorname = new Label();
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
            grpClaims.Controls.Add(tbxEmail);
            grpClaims.Controls.Add(lblEmail);
            grpClaims.Controls.Add(dtGeburtstag);
            grpClaims.Controls.Add(tbxName);
            grpClaims.Controls.Add(tbxOrt);
            grpClaims.Controls.Add(tbxPlz);
            grpClaims.Controls.Add(tbxVorname);
            grpClaims.Controls.Add(lblOrt);
            grpClaims.Controls.Add(lblPosteingang);
            grpClaims.Controls.Add(lblGeburtstag);
            grpClaims.Controls.Add(lblName);
            grpClaims.Controls.Add(lblVorname);
            grpClaims.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpClaims.ForeColor = SystemColors.ActiveCaption;
            grpClaims.Location = new Point(29, 258);
            grpClaims.Name = "grpClaims";
            grpClaims.Size = new Size(654, 285);
            grpClaims.TabIndex = 0;
            grpClaims.TabStop = false;
            grpClaims.Text = "Claims";
            // 
            // tbxEmail
            // 
            tbxEmail.ForeColor = SystemColors.ActiveCaption;
            tbxEmail.Location = new Point(141, 234);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(432, 28);
            tbxEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 21);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email";
            // 
            // dtGeburtstag
            // 
            dtGeburtstag.Location = new Point(141, 118);
            dtGeburtstag.Name = "dtGeburtstag";
            dtGeburtstag.Size = new Size(432, 28);
            dtGeburtstag.TabIndex = 13;
            // 
            // tbxName
            // 
            tbxName.ForeColor = SystemColors.ActiveCaption;
            tbxName.Location = new Point(141, 84);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(432, 28);
            tbxName.TabIndex = 12;
            // 
            // tbxOrt
            // 
            tbxOrt.ForeColor = SystemColors.ActiveCaption;
            tbxOrt.Location = new Point(141, 188);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(432, 28);
            tbxOrt.TabIndex = 9;
            // 
            // tbxPlz
            // 
            tbxPlz.ForeColor = SystemColors.ActiveCaption;
            tbxPlz.Location = new Point(141, 154);
            tbxPlz.Name = "tbxPlz";
            tbxPlz.Size = new Size(432, 28);
            tbxPlz.TabIndex = 8;
            // 
            // tbxVorname
            // 
            tbxVorname.ForeColor = SystemColors.ActiveCaption;
            tbxVorname.Location = new Point(141, 48);
            tbxVorname.Name = "tbxVorname";
            tbxVorname.Size = new Size(432, 28);
            tbxVorname.TabIndex = 6;
            // 
            // lblOrt
            // 
            lblOrt.AutoSize = true;
            lblOrt.Location = new Point(76, 195);
            lblOrt.Name = "lblOrt";
            lblOrt.Size = new Size(37, 21);
            lblOrt.TabIndex = 4;
            lblOrt.Text = "Ort";
            // 
            // lblPosteingang
            // 
            lblPosteingang.AutoSize = true;
            lblPosteingang.Location = new Point(6, 161);
            lblPosteingang.Name = "lblPosteingang";
            lblPosteingang.Size = new Size(111, 21);
            lblPosteingang.TabIndex = 3;
            lblPosteingang.Text = "Postleitzahl";
            // 
            // lblGeburtstag
            // 
            lblGeburtstag.AutoSize = true;
            lblGeburtstag.Location = new Point(6, 125);
            lblGeburtstag.Name = "lblGeburtstag";
            lblGeburtstag.Size = new Size(107, 21);
            lblGeburtstag.TabIndex = 2;
            lblGeburtstag.Text = "Geburtstag";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(103, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Nachname";
            // 
            // lblVorname
            // 
            lblVorname.AutoSize = true;
            lblVorname.Location = new Point(6, 51);
            lblVorname.Name = "lblVorname";
            lblVorname.Size = new Size(89, 21);
            lblVorname.TabIndex = 0;
            lblVorname.Text = "Vorname";
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
            grpAudience.Size = new Size(654, 223);
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
        private Label lblVorname;
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
        private ToolStripMenuItem aIToolStripMenuItem;
        private Button btnGenerate;
        private Button btnCopy;
        private Button btnDelete;
    }
}
