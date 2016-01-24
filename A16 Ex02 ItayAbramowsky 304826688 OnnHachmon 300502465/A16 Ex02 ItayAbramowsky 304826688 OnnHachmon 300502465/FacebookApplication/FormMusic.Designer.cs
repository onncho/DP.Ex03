namespace FacebookApplication
{
    public partial class FormMusic
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
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.ListBoxMusicans = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonYouTubeChannel = new System.Windows.Forms.Button();
            this.profileName = new System.Windows.Forms.Label();
            this.ListBoxMusicianVideos = new System.Windows.Forms.ListBox();
            this.buttonPlayVideoOnYouTube = new System.Windows.Forms.Button();
            this.buttonLinkToPage = new System.Windows.Forms.Button();
            this.pictureBoxYouTube = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebook = new System.Windows.Forms.PictureBox();
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.ShockwaveFlashPlayerBox = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.likesCountLabel1 = new System.Windows.Forms.Label();
            this.youTubeProxyVideoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            likesCountLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShockwaveFlashPlayerBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youTubeProxyVideoListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            likesCountLabel.Location = new System.Drawing.Point(106, 16);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(92, 16);
            likesCountLabel.TabIndex = 2;
            likesCountLabel.Text = "Likes Count:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(106, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // ListBoxMusicans
            // 
            this.ListBoxMusicans.BackColor = System.Drawing.Color.AliceBlue;
            this.ListBoxMusicans.DataSource = this.pageBindingSource;
            this.ListBoxMusicans.DisplayMember = "Name";
            this.ListBoxMusicans.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMusicans.FormattingEnabled = true;
            this.ListBoxMusicans.ItemHeight = 18;
            this.ListBoxMusicans.Location = new System.Drawing.Point(12, 118);
            this.ListBoxMusicans.Name = "ListBoxMusicans";
            this.ListBoxMusicans.Size = new System.Drawing.Size(259, 256);
            this.ListBoxMusicans.TabIndex = 2;
            this.ListBoxMusicans.ValueMember = "FacebookMusicPageList";
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            this.pageBindingSource.CurrentChanged += new System.EventHandler(this.pageBindingSource_CurrentChanged);
            // 
            // buttonYouTubeChannel
            // 
            this.buttonYouTubeChannel.BackColor = System.Drawing.Color.Crimson;
            this.buttonYouTubeChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYouTubeChannel.ForeColor = System.Drawing.Color.White;
            this.buttonYouTubeChannel.Location = new System.Drawing.Point(723, 3);
            this.buttonYouTubeChannel.Name = "buttonYouTubeChannel";
            this.buttonYouTubeChannel.Size = new System.Drawing.Size(135, 58);
            this.buttonYouTubeChannel.TabIndex = 5;
            this.buttonYouTubeChannel.Text = "YouTube Channel";
            this.buttonYouTubeChannel.UseVisualStyleBackColor = false;
            this.buttonYouTubeChannel.Click += new System.EventHandler(this.buttonYouTubeChannel_Click);
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(107, 56);
            this.profileName.Name = "profileName";
            this.profileName.Padding = new System.Windows.Forms.Padding(2);
            this.profileName.Size = new System.Drawing.Size(160, 20);
            this.profileName.TabIndex = 8;
            this.profileName.Text = "Facebook UserName";
            // 
            // ListBoxMusicianVideos
            // 
            this.ListBoxMusicianVideos.BackColor = System.Drawing.Color.AliceBlue;
            this.ListBoxMusicianVideos.DataSource = this.youTubeProxyVideoListBindingSource;
            this.ListBoxMusicianVideos.DisplayMember = "VideoName";
            this.ListBoxMusicianVideos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMusicianVideos.FormattingEnabled = true;
            this.ListBoxMusicianVideos.HorizontalScrollbar = true;
            this.ListBoxMusicianVideos.ItemHeight = 18;
            this.ListBoxMusicianVideos.Location = new System.Drawing.Point(647, 118);
            this.ListBoxMusicianVideos.MaximumSize = new System.Drawing.Size(500, 400);
            this.ListBoxMusicianVideos.MinimumSize = new System.Drawing.Size(383, 238);
            this.ListBoxMusicianVideos.Name = "ListBoxMusicianVideos";
            this.ListBoxMusicianVideos.Size = new System.Drawing.Size(438, 256);
            this.ListBoxMusicianVideos.TabIndex = 10;
            this.ListBoxMusicianVideos.ValueMember = "VideoKey";
            // 
            // buttonPlayVideoOnYouTube
            // 
            this.buttonPlayVideoOnYouTube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.buttonPlayVideoOnYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayVideoOnYouTube.ForeColor = System.Drawing.Color.White;
            this.buttonPlayVideoOnYouTube.Location = new System.Drawing.Point(651, 58);
            this.buttonPlayVideoOnYouTube.Name = "buttonPlayVideoOnYouTube";
            this.buttonPlayVideoOnYouTube.Size = new System.Drawing.Size(135, 58);
            this.buttonPlayVideoOnYouTube.TabIndex = 11;
            this.buttonPlayVideoOnYouTube.Text = "Play In Browser";
            this.buttonPlayVideoOnYouTube.UseVisualStyleBackColor = false;
            this.buttonPlayVideoOnYouTube.Click += new System.EventHandler(this.buttonPlayVideoOnYouTube_Click);
            // 
            // buttonLinkToPage
            // 
            this.buttonLinkToPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonLinkToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkToPage.ForeColor = System.Drawing.Color.White;
            this.buttonLinkToPage.Location = new System.Drawing.Point(792, 58);
            this.buttonLinkToPage.Name = "buttonLinkToPage";
            this.buttonLinkToPage.Size = new System.Drawing.Size(135, 58);
            this.buttonLinkToPage.TabIndex = 13;
            this.buttonLinkToPage.Text = "Facebook Page";
            this.buttonLinkToPage.UseVisualStyleBackColor = false;
            this.buttonLinkToPage.Click += new System.EventHandler(this.buttonLinkToPage_Click);
            // 
            // pictureBoxYouTube
            // 
            this.pictureBoxYouTube.BackgroundImage = global::FacebookApplication.Properties.Resources.youtube_logo;
            this.pictureBoxYouTube.Location = new System.Drawing.Point(955, 12);
            this.pictureBoxYouTube.Name = "pictureBoxYouTube";
            this.pictureBoxYouTube.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxYouTube.TabIndex = 15;
            this.pictureBoxYouTube.TabStop = false;
            // 
            // pictureBoxFacebook
            // 
            this.pictureBoxFacebook.BackgroundImage = global::FacebookApplication.Properties.Resources.facebook_logo;
            this.pictureBoxFacebook.Location = new System.Drawing.Point(1025, 12);
            this.pictureBoxFacebook.Name = "pictureBoxFacebook";
            this.pictureBoxFacebook.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFacebook.TabIndex = 14;
            this.pictureBoxFacebook.TabStop = false;
            // 
            // profileImage
            // 
            this.profileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileImage.Image = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.profileImage.Location = new System.Drawing.Point(12, 12);
            this.profileImage.MinimumSize = new System.Drawing.Size(100, 100);
            this.profileImage.Name = "profileImage";
            this.profileImage.Padding = new System.Windows.Forms.Padding(2);
            this.profileImage.Size = new System.Drawing.Size(100, 100);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // ShockwaveFlashPlayerBox
            // 
            this.ShockwaveFlashPlayerBox.Enabled = true;
            this.ShockwaveFlashPlayerBox.Location = new System.Drawing.Point(273, 117);
            this.ShockwaveFlashPlayerBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShockwaveFlashPlayerBox.Name = "ShockwaveFlashPlayerBox";
            this.ShockwaveFlashPlayerBox.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShockwaveFlashPlayerBox.OcxState")));
            this.ShockwaveFlashPlayerBox.Size = new System.Drawing.Size(371, 255);
            this.ShockwaveFlashPlayerBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(likesCountLabel);
            this.panel1.Controls.Add(this.likesCountLabel1);
            this.panel1.Location = new System.Drawing.Point(273, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 108);
            this.panel1.TabIndex = 17;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(165, 55);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(193, 23);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(0, 4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 1;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // likesCountLabel1
            // 
            this.likesCountLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountLabel1.Location = new System.Drawing.Point(206, 16);
            this.likesCountLabel1.Name = "likesCountLabel1";
            this.likesCountLabel1.Size = new System.Drawing.Size(100, 23);
            this.likesCountLabel1.TabIndex = 3;
            this.likesCountLabel1.Text = "label1";
            // 
            // youTubeProxyVideoListBindingSource
            // 
            this.youTubeProxyVideoListBindingSource.DataSource = typeof(FacebookApplication.YouTubeVideo);
            this.youTubeProxyVideoListBindingSource.CurrentChanged += new System.EventHandler(this.youTubeProxyVideoListBindingSource_CurrentChanged);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShockwaveFlashPlayerBox);
            this.Controls.Add(this.pictureBoxYouTube);
            this.Controls.Add(this.pictureBoxFacebook);
            this.Controls.Add(this.buttonLinkToPage);
            this.Controls.Add(this.buttonPlayVideoOnYouTube);
            this.Controls.Add(this.ListBoxMusicianVideos);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.buttonYouTubeChannel);
            this.Controls.Add(this.ListBoxMusicans);
            this.Controls.Add(this.profileImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusicForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShockwaveFlashPlayerBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youTubeProxyVideoListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.ListBox ListBoxMusicans;
        private System.Windows.Forms.Button buttonYouTubeChannel;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.ListBox ListBoxMusicianVideos;
        private System.Windows.Forms.Button buttonPlayVideoOnYouTube;
        private System.Windows.Forms.Button buttonLinkToPage;
        private System.Windows.Forms.PictureBox pictureBoxFacebook;
        private System.Windows.Forms.PictureBox pictureBoxYouTube;
        private AxShockwaveFlashObjects.AxShockwaveFlash ShockwaveFlashPlayerBox;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label likesCountLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.BindingSource youTubeProxyVideoListBindingSource;
    }
}