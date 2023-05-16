namespace Lab_02
{
    partial class Home
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lblContRed = new System.Windows.Forms.Label();
            this.lblContBlue = new System.Windows.Forms.Label();
            this.lblContGreen = new System.Windows.Forms.Label();
            this.lbl_paleta = new System.Windows.Forms.Label();
            this.RedScrollBar = new System.Windows.Forms.HScrollBar();
            this.BlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo.Location = new System.Drawing.Point(179, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(200, 20);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Laboratório de Cores";
            // 
            // lbl_red
            // 
            this.lbl_red.BackColor = System.Drawing.Color.Red;
            this.lbl_red.Location = new System.Drawing.Point(18, 69);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(26, 25);
            this.lbl_red.TabIndex = 1;
            // 
            // lbl_blue
            // 
            this.lbl_blue.BackColor = System.Drawing.Color.Blue;
            this.lbl_blue.Location = new System.Drawing.Point(18, 104);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(26, 25);
            this.lbl_blue.TabIndex = 2;
            // 
            // lbl_green
            // 
            this.lbl_green.BackColor = System.Drawing.Color.Lime;
            this.lbl_green.Location = new System.Drawing.Point(18, 139);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(26, 27);
            this.lbl_green.TabIndex = 3;
            // 
            // lblContRed
            // 
            this.lblContRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContRed.Location = new System.Drawing.Point(66, 69);
            this.lblContRed.Name = "lblContRed";
            this.lblContRed.Size = new System.Drawing.Size(28, 23);
            this.lblContRed.TabIndex = 4;
            this.lblContRed.Text = "255";
            this.lblContRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContBlue
            // 
            this.lblContBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContBlue.Location = new System.Drawing.Point(66, 106);
            this.lblContBlue.Name = "lblContBlue";
            this.lblContBlue.Size = new System.Drawing.Size(28, 23);
            this.lblContBlue.TabIndex = 5;
            this.lblContBlue.Text = "255";
            this.lblContBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContGreen
            // 
            this.lblContGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContGreen.Location = new System.Drawing.Point(66, 143);
            this.lblContGreen.Name = "lblContGreen";
            this.lblContGreen.Size = new System.Drawing.Size(28, 23);
            this.lblContGreen.TabIndex = 6;
            this.lblContGreen.Text = "255";
            this.lblContGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_paleta
            // 
            this.lbl_paleta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_paleta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_paleta.Location = new System.Drawing.Point(12, 188);
            this.lbl_paleta.Name = "lbl_paleta";
            this.lbl_paleta.Size = new System.Drawing.Size(472, 98);
            this.lbl_paleta.TabIndex = 7;
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.LargeChange = 1;
            this.RedScrollBar.Location = new System.Drawing.Point(110, 75);
            this.RedScrollBar.Maximum = 255;
            this.RedScrollBar.Minimum = 1;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(374, 17);
            this.RedScrollBar.TabIndex = 8;
            this.RedScrollBar.Value = 1;
            this.RedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScrollBar_Scroll);
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.LargeChange = 1;
            this.BlueScrollBar.Location = new System.Drawing.Point(110, 112);
            this.BlueScrollBar.Maximum = 255;
            this.BlueScrollBar.Minimum = 1;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(377, 17);
            this.BlueScrollBar.TabIndex = 9;
            this.BlueScrollBar.Value = 1;
            this.BlueScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueScrollBar_Scroll);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.LargeChange = 1;
            this.GreenScrollBar.Location = new System.Drawing.Point(110, 149);
            this.GreenScrollBar.Maximum = 255;
            this.GreenScrollBar.Minimum = 1;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(374, 17);
            this.GreenScrollBar.TabIndex = 10;
            this.GreenScrollBar.Value = 1;
            this.GreenScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenScrollBar_Scroll);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 295);
            this.Controls.Add(this.GreenScrollBar);
            this.Controls.Add(this.BlueScrollBar);
            this.Controls.Add(this.RedScrollBar);
            this.Controls.Add(this.lbl_paleta);
            this.Controls.Add(this.lblContGreen);
            this.Controls.Add(this.lblContBlue);
            this.Controls.Add(this.lblContRed);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.lbl_titulo);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório 02 >>>>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_red;
        private Label lbl_blue;
        private Label lbl_green;
        private Label lblContRed;
        private Label lblContBlue;
        private Label lblContGreen;
        private Label lbl_paleta;
        private HScrollBar RedScrollBar;
        private HScrollBar BlueScrollBar;
        private HScrollBar GreenScrollBar;
    }
}