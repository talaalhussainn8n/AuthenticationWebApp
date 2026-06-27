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
            textBox2 = new TextBox();
            lblKey = new Label();
            label1 = new Label();
            cmbModels = new ComboBox();
            grpEingabe = new GroupBox();
            textBox1 = new TextBox();
            lblAusgabe = new Label();
            btnGenerate = new Button();
            grpEingabe.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 39);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(574, 102);
            textBox2.TabIndex = 10;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKey.ForeColor = SystemColors.ActiveCaption;
            lblKey.Location = new Point(50, 41);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(39, 20);
            lblKey.TabIndex = 9;
            lblKey.Text = "Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(7, 169);
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
            cmbModels.Location = new Point(104, 161);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(574, 28);
            cmbModels.TabIndex = 12;
            // 
            // grpEingabe
            // 
            grpEingabe.Controls.Add(textBox2);
            grpEingabe.Controls.Add(cmbModels);
            grpEingabe.Controls.Add(lblKey);
            grpEingabe.Controls.Add(label1);
            grpEingabe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            grpEingabe.ForeColor = SystemColors.ActiveCaption;
            grpEingabe.Location = new Point(12, 30);
            grpEingabe.Name = "grpEingabe";
            grpEingabe.Size = new Size(695, 255);
            grpEingabe.TabIndex = 13;
            grpEingabe.TabStop = false;
            grpEingabe.Text = "Eingabe";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 17;
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
            btnGenerate.Location = new Point(613, 420);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(94, 29);
            btnGenerate.TabIndex = 16;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // AiApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 460);
            Controls.Add(btnGenerate);
            Controls.Add(textBox1);
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

        private TextBox textBox2;
        private Label lblKey;
        private Label label1;
        private ComboBox cmbModels;
        private GroupBox grpEingabe;
        private TextBox textBox1;
        private Label lblAusgabe;
        private Button btnGenerate;
    }
}