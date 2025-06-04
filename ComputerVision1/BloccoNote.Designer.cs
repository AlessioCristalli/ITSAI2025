namespace ComputerVision1
{
    partial class BloccoNote
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
            BtnNuovo = new Button();
            BtnApri = new Button();
            BtnSalva = new Button();
            BtnPulisci = new Button();
            BtnFont = new Button();
            DlgApri = new OpenFileDialog();
            DlgSalva = new SaveFileDialog();
            DlgFont = new FontDialog();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // BtnNuovo
            // 
            BtnNuovo.Cursor = Cursors.Hand;
            BtnNuovo.Font = new Font("Segoe UI", 9F);
            BtnNuovo.Location = new Point(9, 4);
            BtnNuovo.Name = "BtnNuovo";
            BtnNuovo.Size = new Size(74, 23);
            BtnNuovo.TabIndex = 0;
            BtnNuovo.Text = "Nuovo";
            BtnNuovo.UseVisualStyleBackColor = true;
            BtnNuovo.Click += BtnNuovo_Click;
            // 
            // BtnApri
            // 
            BtnApri.Cursor = Cursors.Hand;
            BtnApri.Font = new Font("Segoe UI", 9F);
            BtnApri.Location = new Point(89, 4);
            BtnApri.Name = "BtnApri";
            BtnApri.Size = new Size(74, 23);
            BtnApri.TabIndex = 1;
            BtnApri.Text = "Apri";
            BtnApri.UseVisualStyleBackColor = true;
            BtnApri.Click += BtnApri_Click;
            // 
            // BtnSalva
            // 
            BtnSalva.Cursor = Cursors.Hand;
            BtnSalva.Font = new Font("Segoe UI", 9F);
            BtnSalva.Location = new Point(169, 4);
            BtnSalva.Name = "BtnSalva";
            BtnSalva.Size = new Size(74, 23);
            BtnSalva.TabIndex = 2;
            BtnSalva.Text = "Salva";
            BtnSalva.UseVisualStyleBackColor = true;
            BtnSalva.Click += BtnSalva_Click;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "";
            // 
            // DlgSalva
            // 
            DlgSalva.FileName = "File.txt";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(9, 33);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(522, 334);
            textBox.TabIndex = 3;
            // 
            // BtnPulisci
            // 
            BtnPulisci.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPulisci.Cursor = Cursors.Hand;
            BtnPulisci.Font = new Font("Segoe UI", 9F);
            BtnPulisci.Location = new Point(454, 4);
            BtnPulisci.Name = "BtnPulisci";
            BtnPulisci.Size = new Size(74, 23);
            BtnPulisci.TabIndex = 4;
            BtnPulisci.Text = "Pulisci";
            BtnPulisci.UseVisualStyleBackColor = true;
            BtnPulisci.Click += BtnPulisci_Click;
            // 
            // BtnFont
            // 
            BtnFont.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnFont.Location = new Point(9, 375);
            BtnFont.Name = "BtnFont";
            BtnFont.Size = new Size(74, 23);
            BtnFont.TabIndex = 5;
            BtnFont.Text = "Stile";
            BtnFont.UseVisualStyleBackColor = true;
            BtnFont.Click += BtnFont_Click;
            // 
            // BloccoNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 408);
            Controls.Add(BtnFont);
            Controls.Add(BtnPulisci);
            Controls.Add(textBox);
            Controls.Add(BtnSalva);
            Controls.Add(BtnApri);
            Controls.Add(BtnNuovo);
            Name = "BloccoNote";
            Text = "BloccoNote";
            FormClosing += BloccoNote_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNuovo;
        private Button BtnApri;
        private Button BtnSalva;
        private Button BtnPulisci;
        private Button BtnFont;
        private OpenFileDialog DlgApri;
        private SaveFileDialog DlgSalva;
        private FontDialog DlgFont;
        private TextBox textBox;
    }
}