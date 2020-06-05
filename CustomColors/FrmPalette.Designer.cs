namespace CustomColors
{
    partial class FrmPalette
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
            this.components = new System.ComponentModel.Container();
            this.picGraySample = new System.Windows.Forms.PictureBox();
            this.picRainbow = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.lblColor = new System.Windows.Forms.Label();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.picRainbowSample = new System.Windows.Forms.PictureBox();
            this.picAltRainbow = new System.Windows.Forms.PictureBox();
            this.picAltRainbowSample = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraySample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainbowSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltRainbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltRainbowSample)).BeginInit();
            this.SuspendLayout();
            // 
            // picGraySample
            // 
            this.picGraySample.Location = new System.Drawing.Point(274, 68);
            this.picGraySample.Name = "picGraySample";
            this.picGraySample.Size = new System.Drawing.Size(100, 50);
            this.picGraySample.TabIndex = 7;
            this.picGraySample.TabStop = false;
            this.picGraySample.Paint += new System.Windows.Forms.PaintEventHandler(this.picGraySample_Paint);
            // 
            // picRainbow
            // 
            this.picRainbow.Location = new System.Drawing.Point(12, 12);
            this.picRainbow.Name = "picRainbow";
            this.picRainbow.Size = new System.Drawing.Size(256, 50);
            this.picRainbow.TabIndex = 6;
            this.picRainbow.TabStop = false;
            this.picRainbow.Paint += new System.Windows.Forms.PaintEventHandler(this.picRainbow_Paint);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 250;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMoveSample_Tick);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 178);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(35, 13);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "label1";
            // 
            // picGray
            // 
            this.picGray.Location = new System.Drawing.Point(12, 68);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(256, 50);
            this.picGray.TabIndex = 9;
            this.picGray.TabStop = false;
            this.picGray.Paint += new System.Windows.Forms.PaintEventHandler(this.picGray_Paint);
            // 
            // picRainbowSample
            // 
            this.picRainbowSample.Location = new System.Drawing.Point(274, 12);
            this.picRainbowSample.Name = "picRainbowSample";
            this.picRainbowSample.Size = new System.Drawing.Size(100, 50);
            this.picRainbowSample.TabIndex = 10;
            this.picRainbowSample.TabStop = false;
            this.picRainbowSample.Paint += new System.Windows.Forms.PaintEventHandler(this.picRainbowSample_Paint);
            // 
            // picAltRainbow
            // 
            this.picAltRainbow.Location = new System.Drawing.Point(13, 125);
            this.picAltRainbow.Name = "picAltRainbow";
            this.picAltRainbow.Size = new System.Drawing.Size(255, 50);
            this.picAltRainbow.TabIndex = 11;
            this.picAltRainbow.TabStop = false;
            this.picAltRainbow.Paint += new System.Windows.Forms.PaintEventHandler(this.picAltRainbow_Paint);
            // 
            // picAltRainbowSample
            // 
            this.picAltRainbowSample.Location = new System.Drawing.Point(274, 125);
            this.picAltRainbowSample.Name = "picAltRainbowSample";
            this.picAltRainbowSample.Size = new System.Drawing.Size(100, 50);
            this.picAltRainbowSample.TabIndex = 12;
            this.picAltRainbowSample.TabStop = false;
            this.picAltRainbowSample.Paint += new System.Windows.Forms.PaintEventHandler(this.picAltRainbowSample_Paint);
            // 
            // FrmPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 255);
            this.Controls.Add(this.picAltRainbowSample);
            this.Controls.Add(this.picAltRainbow);
            this.Controls.Add(this.picRainbowSample);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.picGraySample);
            this.Controls.Add(this.picRainbow);
            this.Name = "FrmPalette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picGraySample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRainbowSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltRainbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAltRainbowSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGraySample;
        private System.Windows.Forms.PictureBox picRainbow;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.PictureBox picRainbowSample;
        private System.Windows.Forms.PictureBox picAltRainbow;
        private System.Windows.Forms.PictureBox picAltRainbowSample;
    }
}