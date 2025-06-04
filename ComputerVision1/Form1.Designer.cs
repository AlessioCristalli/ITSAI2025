namespace ComputerVision1
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
            BtnCalcola = new Button();
            PctPreview = new PictureBox();
            DlgApri = new OpenFileDialog();
            trkBar = new TrackBar();
            label1 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PctPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcola
            // 
            BtnCalcola.BackColor = Color.Transparent;
            BtnCalcola.Location = new Point(12, 392);
            BtnCalcola.Name = "BtnCalcola";
            BtnCalcola.Size = new Size(110, 45);
            BtnCalcola.TabIndex = 0;
            BtnCalcola.Text = "Apri immagine";
            BtnCalcola.UseVisualStyleBackColor = false;
            BtnCalcola.Click += BtnCalcola_Click;
            // 
            // PctPreview
            // 
            PctPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PctPreview.Location = new Point(-4, 1);
            PctPreview.Name = "PctPreview";
            PctPreview.Size = new Size(625, 385);
            PctPreview.TabIndex = 1;
            PctPreview.TabStop = false;
            // 
            // DlgApri
            // 
            DlgApri.FileName = "openFileDialog";
            // 
            // trkBar
            // 
            trkBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trkBar.Cursor = Cursors.Hand;
            trkBar.Location = new Point(322, 392);
            trkBar.Maximum = 255;
            trkBar.Name = "trkBar";
            trkBar.Size = new Size(289, 45);
            trkBar.TabIndex = 3;
            trkBar.Scroll += trkBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 464);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Soglia colori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 589);
            Controls.Add(button1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(PctPreview);
            Controls.Add(label1);
            Controls.Add(trkBar);
            Controls.Add(BtnCalcola);
            Name = "Form1";
            Text = "Computer Vision 1";
            ((System.ComponentModel.ISupportInitialize)PctPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcola;
        private PictureBox PctPreview;
        private OpenFileDialog DlgApri;
        private TextBox txtRisultato;
        private TrackBar trkBar;
        private Label label1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Button button1;
    }
}
