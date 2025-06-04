namespace ComputerVision1
{
    partial class Form2
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
            BtnApri = new Button();
            BtnAnalizza = new Button();
            pctPreview = new PictureBox();
            DlgApri = new OpenFileDialog();
            trkluminosita = new TrackBar();
            trkHueMin = new TrackBar();
            trkHueMax = new TrackBar();
            labelLuminosita = new Label();
            labelHueMin = new Label();
            labelHueMax = new Label();
            BtnResetta = new Button();
            ((System.ComponentModel.ISupportInitialize)pctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkluminosita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkHueMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkHueMax).BeginInit();
            SuspendLayout();
            // 
            // BtnApri
            // 
            BtnApri.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnApri.Cursor = Cursors.Hand;
            BtnApri.Location = new Point(8, 262);
            BtnApri.Name = "BtnApri";
            BtnApri.Size = new Size(597, 23);
            BtnApri.TabIndex = 0;
            BtnApri.Text = "Apri";
            BtnApri.UseVisualStyleBackColor = true;
            BtnApri.Click += BtnApri_Click;
            // 
            // BtnAnalizza
            // 
            BtnAnalizza.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAnalizza.Cursor = Cursors.Hand;
            BtnAnalizza.Location = new Point(8, 471);
            BtnAnalizza.Name = "BtnAnalizza";
            BtnAnalizza.Size = new Size(285, 23);
            BtnAnalizza.TabIndex = 1;
            BtnAnalizza.Text = "Analizza\r\n";
            BtnAnalizza.UseVisualStyleBackColor = true;
            BtnAnalizza.Click += BtnAnalizza_Click;
            // 
            // pctPreview
            // 
            pctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pctPreview.Location = new Point(8, 10);
            pctPreview.Name = "pctPreview";
            pctPreview.Size = new Size(597, 246);
            pctPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pctPreview.TabIndex = 2;
            pctPreview.TabStop = false;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog1";
            // 
            // trkluminosita
            // 
            trkluminosita.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trkluminosita.Cursor = Cursors.Hand;
            trkluminosita.Location = new Point(104, 287);
            trkluminosita.Maximum = 100;
            trkluminosita.Name = "trkluminosita";
            trkluminosita.Size = new Size(501, 45);
            trkluminosita.TabIndex = 3;
            trkluminosita.Scroll += trkluminosita_Scroll;
            // 
            // trkHueMin
            // 
            trkHueMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trkHueMin.Cursor = Cursors.Hand;
            trkHueMin.Location = new Point(104, 356);
            trkHueMin.Maximum = 360;
            trkHueMin.Name = "trkHueMin";
            trkHueMin.Size = new Size(501, 45);
            trkHueMin.TabIndex = 4;
            trkHueMin.Scroll += trkHueMin_Scroll;
            // 
            // trkHueMax
            // 
            trkHueMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trkHueMax.Cursor = Cursors.Hand;
            trkHueMax.Location = new Point(104, 422);
            trkHueMax.Maximum = 360;
            trkHueMax.Name = "trkHueMax";
            trkHueMax.Size = new Size(501, 45);
            trkHueMax.TabIndex = 5;
            trkHueMax.Scroll += trkHueMax_Scroll;
            // 
            // labelLuminosita
            // 
            labelLuminosita.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLuminosita.AutoSize = true;
            labelLuminosita.Location = new Point(12, 289);
            labelLuminosita.Name = "labelLuminosita";
            labelLuminosita.Size = new Size(66, 15);
            labelLuminosita.TabIndex = 6;
            labelLuminosita.Text = "Luminosità";
            // 
            // labelHueMin
            // 
            labelHueMin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelHueMin.AutoSize = true;
            labelHueMin.Location = new Point(12, 356);
            labelHueMin.Name = "labelHueMin";
            labelHueMin.Size = new Size(53, 15);
            labelHueMin.TabIndex = 7;
            labelHueMin.Text = "Hue Min";
            // 
            // labelHueMax
            // 
            labelHueMax.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelHueMax.AutoSize = true;
            labelHueMax.Location = new Point(12, 422);
            labelHueMax.Name = "labelHueMax";
            labelHueMax.Size = new Size(54, 15);
            labelHueMax.TabIndex = 8;
            labelHueMax.Text = "Hue Max\r\n";
            // 
            // BtnResetta
            // 
            BtnResetta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnResetta.Cursor = Cursors.Hand;
            BtnResetta.Location = new Point(305, 471);
            BtnResetta.Name = "BtnResetta";
            BtnResetta.Size = new Size(307, 23);
            BtnResetta.TabIndex = 9;
            BtnResetta.Text = "Reset";
            BtnResetta.UseVisualStyleBackColor = true;
            BtnResetta.Click += BtnResetta_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 507);
            Controls.Add(BtnResetta);
            Controls.Add(pctPreview);
            Controls.Add(labelHueMax);
            Controls.Add(labelHueMin);
            Controls.Add(labelLuminosita);
            Controls.Add(trkHueMax);
            Controls.Add(trkHueMin);
            Controls.Add(trkluminosita);
            Controls.Add(BtnAnalizza);
            Controls.Add(BtnApri);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkluminosita).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkHueMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkHueMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnApri;
        private Button BtnAnalizza;
        private PictureBox pctPreview;
        private OpenFileDialog DlgApri;
        private TrackBar trkluminosita;
        private TrackBar trkHueMin;
        private TrackBar trkHueMax;
        private Label labelLuminosita;
        private Label labelHueMin;
        private Label labelHueMax;
        private Button BtnResetta;
    }
}