namespace AudioPhile.Custom_Components
{
    partial class CustomAlertForm
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
            this.btnSongSelect = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.lblCustomAlert = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.customAlertPictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customAlertPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSongSelect
            // 
            this.btnSongSelect.Animated = true;
            this.btnSongSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSongSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSongSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSongSelect.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSongSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSongSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnSongSelect.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSongSelect.Font = new System.Drawing.Font("0xProto Nerd Font", 14.25F);
            this.btnSongSelect.ForeColor = System.Drawing.Color.White;
            this.btnSongSelect.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSongSelect.Location = new System.Drawing.Point(330, 197);
            this.btnSongSelect.Name = "btnSongSelect";
            this.btnSongSelect.Size = new System.Drawing.Size(200, 56);
            this.btnSongSelect.TabIndex = 7;
            this.btnSongSelect.Text = "Song Only";
            this.btnSongSelect.Click += new System.EventHandler(this.btnSongSelect_Click);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.Animated = true;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("0xProto Nerd Font", 14.25F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(78, 197);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(200, 56);
            this.guna2GradientTileButton1.TabIndex = 6;
            this.guna2GradientTileButton1.Text = "Song Directory";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // lblCustomAlert
            // 
            this.lblCustomAlert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomAlert.Font = new System.Drawing.Font("0xProto Nerd Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.lblCustomAlert.Location = new System.Drawing.Point(3, 127);
            this.lblCustomAlert.Name = "lblCustomAlert";
            this.lblCustomAlert.Size = new System.Drawing.Size(607, 42);
            this.lblCustomAlert.TabIndex = 5;
            this.lblCustomAlert.Text = "Are you adding a directory or just a song?";
            this.lblCustomAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // customAlertPictureBox
            // 
            this.customAlertPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customAlertPictureBox.Image = global::AudioPhile.Properties.Resources.question;
            this.customAlertPictureBox.ImageRotate = 0F;
            this.customAlertPictureBox.Location = new System.Drawing.Point(253, 12);
            this.customAlertPictureBox.Name = "customAlertPictureBox";
            this.customAlertPictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.customAlertPictureBox.Size = new System.Drawing.Size(99, 96);
            this.customAlertPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customAlertPictureBox.TabIndex = 4;
            this.customAlertPictureBox.TabStop = false;
            // 
            // CustomAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(613, 310);
            this.Controls.Add(this.btnSongSelect);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.lblCustomAlert);
            this.Controls.Add(this.customAlertPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomAlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomAlertForm";
            ((System.ComponentModel.ISupportInitialize)(this.customAlertPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btnSongSelect;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.Label lblCustomAlert;
        private Guna.UI2.WinForms.Guna2CirclePictureBox customAlertPictureBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}