namespace AudioPhile.Custom_Components
{
    partial class MusicListTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblSinger = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.songImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.lblSinger);
            this.guna2GradientPanel1.Controls.Add(this.lblSongTitle);
            this.guna2GradientPanel1.Controls.Add(this.songImage);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(747, 75);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblSinger
            // 
            this.lblSinger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSinger.BackColor = System.Drawing.Color.Transparent;
            this.lblSinger.Font = new System.Drawing.Font("3270 Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.lblSinger.Location = new System.Drawing.Point(84, 39);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(660, 31);
            this.lblSinger.TabIndex = 2;
            this.lblSinger.Text = "BINI";
            this.lblSinger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSongTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSongTitle.Font = new System.Drawing.Font("0xProto Nerd Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.lblSongTitle.Location = new System.Drawing.Point(79, 8);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(665, 31);
            this.lblSongTitle.TabIndex = 1;
            this.lblSongTitle.Text = "KARERA";
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongTitle.Click += new System.EventHandler(this.lblSongTitle_Click);
            this.lblSongTitle.MouseHover += new System.EventHandler(this.lblSongTitle_MouseHover);
            // 
            // songImage
            // 
            this.songImage.BackColor = System.Drawing.Color.Transparent;
            this.songImage.ImageRotate = 0F;
            this.songImage.Location = new System.Drawing.Point(3, 3);
            this.songImage.Name = "songImage";
            this.songImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.songImage.Size = new System.Drawing.Size(70, 69);
            this.songImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.songImage.TabIndex = 0;
            this.songImage.TabStop = false;
            // 
            // MusicListTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "MusicListTile";
            this.Size = new System.Drawing.Size(747, 75);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox songImage;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblSinger;
    }
}
