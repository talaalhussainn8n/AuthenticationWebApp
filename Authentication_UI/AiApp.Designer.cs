namespace AuthenticationUI
{
    partial class AiApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxPrompt = new TextBox();
            lblKey = new Label();
            label1 = new Label();
            cmbModels = new ComboBox();
            grpEingabe = new GroupBox();
            lblAusgabe = new Label();
            btnGenerate = new Button();
            lblOutput = new Label();
            tbxOutput = new TextBox();
            grpEingabe.SuspendLayout();
            SuspendLayout();
            // 
            // tbxPrompt
            // 
            tbxPrompt.ForeColor = SystemColors.ActiveCaption;
            tbxPrompt.Location = new Point(121, 39);
            tbxPrompt.Multiline = true;
            tbxPrompt.Name = "tbxPrompt";
            tbxPrompt.Size = new Size(574, 102);
            tbxPrompt.TabIndex = 10;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKey.ForeColor = SystemColors.ActiveCaption;
            lblKey.Location = new Point(50, 41);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(62, 20);
            lblKey.TabIndex = 9;
            lblKey.Text = "Prompt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(27, 169);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 11;
            label1.Text = "AI-Models";
            // 
            // cmbModels
            // 
            cmbModels.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbModels.ForeColor = SystemColors.ActiveCaption;
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(121, 161);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(574, 28);
            cmbModels.TabIndex = 12;
            // 
            // grpEingabe
            // 
            grpEingabe.Controls.Add(tbxPrompt);
            grpEingabe.Controls.Add(cmbModels);
            grpEingabe.Controls.Add(lblKey);
            grpEingabe.Controls.Add(label1);
            grpEingabe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grpEingabe.ForeColor = SystemColors.ActiveCaption;
            grpEingabe.Location = new Point(12, 30);
            grpEingabe.Name = "grpEingabe";
            grpEingabe.Size = new Size(732, 255);
            grpEingabe.TabIndex = 13;
            grpEingabe.TabStop = false;
            grpEingabe.Text = "Eingabe";
            // 
            // lblAusgabe
            // 
            lblAusgabe.Location = new Point(0, 0);
            lblAusgabe.Name = "lblAusgabe";
            lblAusgabe.Size = new Size(100, 23);
            lblAusgabe.TabIndex = 18;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnGenerate.ForeColor = SystemColors.ActiveCaption;
            btnGenerate.Location = new Point(613, 574);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 16;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOutput.ForeColor = SystemColors.ActiveCaption;
            lblOutput.Location = new Point(62, 309);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(59, 20);
            lblOutput.TabIndex = 19;
            lblOutput.Text = "Output";
            // 
            // tbxOutput
            // 
            tbxOutput.ForeColor = SystemColors.ActiveCaption;
            tbxOutput.Location = new Point(133, 306);
            tbxOutput.Multiline = true;
            tbxOutput.Name = "tbxOutput";
            tbxOutput.ScrollBars = ScrollBars.Vertical;
            tbxOutput.Size = new Size(611, 262);
            tbxOutput.TabIndex = 20;
            // 
            // AiApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 615);
            Controls.Add(tbxOutput);
            Controls.Add(lblOutput);
            Controls.Add(btnGenerate);
            Controls.Add(lblAusgabe);
            Controls.Add(grpEingabe);
            Name = "AiApp";
            Text = "AiApp";
            grpEingabe.ResumeLayout(false);
            grpEingabe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPrompt;
        private Label lblKey;
        private Label label1;
        private ComboBox cmbModels;
        private GroupBox grpEingabe;
        private Label lblAusgabe;
        private Button btnGenerate;
        private Label lblOutput;
        private TextBox tbxOutput;
    }
}