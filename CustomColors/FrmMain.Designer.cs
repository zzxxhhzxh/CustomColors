namespace CustomColors
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnNikita = new System.Windows.Forms.Button();
            this.btnSystem2 = new System.Windows.Forms.Button();
            this.btnPalette = new System.Windows.Forms.Button();
            this.btnFlatUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustom
            // 
            this.btnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustom.Location = new System.Drawing.Point(880, 449);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(75, 23);
            this.btnCustom.TabIndex = 0;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.BtnCustom_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystem.Location = new System.Drawing.Point(1042, 449);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(75, 23);
            this.btnSystem.TabIndex = 1;
            this.btnSystem.Text = "System";
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // btnNikita
            // 
            this.btnNikita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNikita.Location = new System.Drawing.Point(718, 449);
            this.btnNikita.Name = "btnNikita";
            this.btnNikita.Size = new System.Drawing.Size(75, 23);
            this.btnNikita.TabIndex = 2;
            this.btnNikita.Text = "NikitaGolubev";
            this.btnNikita.UseVisualStyleBackColor = true;
            this.btnNikita.Click += new System.EventHandler(this.BtnNikita_Click);
            // 
            // btnSystem2
            // 
            this.btnSystem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSystem2.Location = new System.Drawing.Point(961, 449);
            this.btnSystem2.Name = "btnSystem2";
            this.btnSystem2.Size = new System.Drawing.Size(75, 23);
            this.btnSystem2.TabIndex = 3;
            this.btnSystem2.Text = "System 2";
            this.btnSystem2.UseVisualStyleBackColor = true;
            this.btnSystem2.Click += new System.EventHandler(this.BtnSystem2_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.Location = new System.Drawing.Point(637, 449);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(75, 23);
            this.btnPalette.TabIndex = 4;
            this.btnPalette.Text = "Palette";
            this.btnPalette.UseVisualStyleBackColor = true;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnFlatUI
            // 
            this.btnFlatUI.Location = new System.Drawing.Point(799, 449);
            this.btnFlatUI.Name = "btnFlatUI";
            this.btnFlatUI.Size = new System.Drawing.Size(75, 23);
            this.btnFlatUI.TabIndex = 5;
            this.btnFlatUI.Text = "Flat UI";
            this.btnFlatUI.UseVisualStyleBackColor = true;
            this.btnFlatUI.Click += new System.EventHandler(this.btnFlatUI_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 484);
            this.Controls.Add(this.btnFlatUI);
            this.Controls.Add(this.btnPalette);
            this.Controls.Add(this.btnSystem2);
            this.Controls.Add(this.btnNikita);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnCustom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Colors";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnNikita;
        private System.Windows.Forms.Button btnSystem2;
        private System.Windows.Forms.Button btnPalette;
        private System.Windows.Forms.Button btnFlatUI;
    }
}

