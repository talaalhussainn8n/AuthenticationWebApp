namespace Authentication_UI
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
            grpClaims = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            lblOrt = new Label();
            lblPosteingang = new Label();
            lblGeburtstag = new Label();
            lblName = new Label();
            lblVorname = new Label();
            grpAudience = new GroupBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            lblKey = new Label();
            tbxVerschluesselung = new TextBox();
            label2 = new Label();
            grpEingabe = new GroupBox();
            btnVerschluesseln = new Button();
            lblExpiers = new Label();
            dateTimePicker2 = new DateTimePicker();
            lblBearerToken = new Label();
            richTextBox2 = new RichTextBox();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            menuStrip1.SuspendLayout();
            grpClaims.SuspendLayout();
            grpAudience.SuspendLayout();
            grpEingabe.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(912, 28);
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
            // 
            // beendenToolStripMenuItem
            // 
            beendenToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beendenToolStripMenuItem.ForeColor = SystemColors.ActiveCaption;
            beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            beendenToolStripMenuItem.Size = new Size(175, 26);
            beendenToolStripMenuItem.Text = "Beenden";
            // 
            // grpClaims
            // 
            grpClaims.Controls.Add(tbxEmail);
            grpClaims.Controls.Add(lblEmail);
            grpClaims.Controls.Add(dateTimePicker1);
            grpClaims.Controls.Add(textBox7);
            grpClaims.Controls.Add(textBox4);
            grpClaims.Controls.Add(textBox3);
            grpClaims.Controls.Add(textBox1);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(432, 28);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(141, 84);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(432, 28);
            textBox7.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 28);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(432, 28);
            textBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 28);
            textBox1.TabIndex = 6;
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
            grpAudience.Controls.Add(dateTimePicker2);
            grpAudience.Controls.Add(lblExpiers);
            grpAudience.Controls.Add(richTextBox1);
            grpAudience.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAudience.ForeColor = SystemColors.ActiveCaption;
            grpAudience.Location = new Point(29, 549);
            grpAudience.Name = "grpAudience";
            grpAudience.Size = new Size(654, 223);
            grpAudience.TabIndex = 1;
            grpAudience.TabStop = false;
            grpAudience.Text = "Audience";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(530, 141);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 28);
            textBox2.TabIndex = 8;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(27, 42);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(45, 21);
            lblKey.TabIndex = 7;
            lblKey.Text = "Key";
            // 
            // tbxVerschluesselung
            // 
            tbxVerschluesselung.Location = new Point(189, 83);
            tbxVerschluesselung.Name = "tbxVerschluesselung";
            tbxVerschluesselung.ReadOnly = true;
            tbxVerschluesselung.Size = new Size(432, 28);
            tbxVerschluesselung.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 86);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 9;
            label2.Text = "Verschlüsselung";
            // 
            // grpEingabe
            // 
            grpEingabe.Controls.Add(btnVerschluesseln);
            grpEingabe.Controls.Add(textBox2);
            grpEingabe.Controls.Add(tbxVerschluesselung);
            grpEingabe.Controls.Add(lblKey);
            grpEingabe.Controls.Add(label2);
            grpEingabe.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            grpEingabe.ForeColor = SystemColors.ActiveCaption;
            grpEingabe.Location = new Point(29, 49);
            grpEingabe.Name = "grpEingabe";
            grpEingabe.Size = new Size(654, 177);
            grpEingabe.TabIndex = 11;
            grpEingabe.TabStop = false;
            grpEingabe.Text = "Eingabe";
            // 
            // btnVerschluesseln
            // 
            btnVerschluesseln.Location = new Point(474, 130);
            btnVerschluesseln.Name = "btnVerschluesseln";
            btnVerschluesseln.Size = new Size(147, 29);
            btnVerschluesseln.TabIndex = 11;
            btnVerschluesseln.Text = "Verschlüsseln";
            btnVerschluesseln.UseVisualStyleBackColor = true;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(123, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(437, 28);
            dateTimePicker2.TabIndex = 8;
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
            // richTextBox2
            // 
            richTextBox2.Location = new Point(189, 807);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(494, 120);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // tbxEmail
            // 
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(912, 973);
            Controls.Add(richTextBox2);
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
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label lblOrt;
        private Label lblPosteingang;
        private Label lblGeburtstag;
        private Label lblName;
        private Label lblVorname;
        private DateTimePicker dateTimePicker1;
        private GroupBox grpAudience;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Label lblKey;
        private TextBox tbxVerschluesselung;
        private Label label2;
        private GroupBox grpEingabe;
        private Button btnVerschluesseln;
        private Label lblExpiers;
        private DateTimePicker dateTimePicker2;
        private Label lblBearerToken;
        private RichTextBox richTextBox2;
        private TextBox tbxEmail;
        private Label lblEmail;
    }
}
