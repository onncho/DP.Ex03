namespace FacebookApplication
{
    public partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePhoto = new System.Windows.Forms.PictureBox();
            this.buttonMusicView = new System.Windows.Forms.Button();
            this.buttonLikeAnaylzer = new System.Windows.Forms.Button();
            this.textBoxStatusFromUser = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.newsFeedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_FullName = new System.Windows.Forms.Label();
            this.checkBoxRemeberMe = new System.Windows.Forms.CheckBox();
            this.listBoxSportsTeams = new System.Windows.Forms.ListBox();
            this.pageSportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosts = new System.Windows.Forms.Label();
            this.label_coomnts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsFeedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.pictureCoverPhoto.Location = new System.Drawing.Point(-2, -1);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(651, 260);
            this.pictureCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCoverPhoto.TabIndex = 0;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePhoto
            // 
            this.pictureProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProfilePhoto.Image = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.pictureProfilePhoto.InitialImage = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.pictureProfilePhoto.Location = new System.Drawing.Point(20, 153);
            this.pictureProfilePhoto.Name = "pictureProfilePhoto";
            this.pictureProfilePhoto.Size = new System.Drawing.Size(124, 132);
            this.pictureProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfilePhoto.TabIndex = 1;
            this.pictureProfilePhoto.TabStop = false;
            // 
            // buttonMusicView
            // 
            this.buttonMusicView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.buttonMusicView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusicView.ForeColor = System.Drawing.Color.White;
            this.buttonMusicView.Location = new System.Drawing.Point(174, 205);
            this.buttonMusicView.Name = "buttonMusicView";
            this.buttonMusicView.Size = new System.Drawing.Size(132, 80);
            this.buttonMusicView.TabIndex = 2;
            this.buttonMusicView.Text = "Music";
            this.buttonMusicView.UseVisualStyleBackColor = false;
            this.buttonMusicView.Click += new System.EventHandler(this.buttonMusicView_Click);
            // 
            // buttonLikeAnaylzer
            // 
            this.buttonLikeAnaylzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(37)))));
            this.buttonLikeAnaylzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikeAnaylzer.ForeColor = System.Drawing.Color.White;
            this.buttonLikeAnaylzer.Location = new System.Drawing.Point(312, 205);
            this.buttonLikeAnaylzer.Name = "buttonLikeAnaylzer";
            this.buttonLikeAnaylzer.Size = new System.Drawing.Size(132, 80);
            this.buttonLikeAnaylzer.TabIndex = 3;
            this.buttonLikeAnaylzer.Text = "Like Analyzer";
            this.buttonLikeAnaylzer.UseVisualStyleBackColor = false;
            this.buttonLikeAnaylzer.Click += new System.EventHandler(this.buttonLikeAnalyzer_Click);
            // 
            // textBoxStatusFromUser
            // 
            this.textBoxStatusFromUser.Location = new System.Drawing.Point(174, 299);
            this.textBoxStatusFromUser.Multiline = true;
            this.textBoxStatusFromUser.Name = "textBoxStatusFromUser";
            this.textBoxStatusFromUser.Size = new System.Drawing.Size(327, 66);
            this.textBoxStatusFromUser.TabIndex = 5;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.ForeColor = System.Drawing.Color.White;
            this.buttonPostStatus.Location = new System.Drawing.Point(507, 297);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 66);
            this.buttonPostStatus.TabIndex = 6;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(223)))), ((int)(((byte)(234)))));
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonLogin.Location = new System.Drawing.Point(18, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(153, 45);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.DataSource = this.newsFeedBindingSource;
            this.listBoxNewsFeed.DisplayMember = "Message";
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(18, 398);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(327, 225);
            this.listBoxNewsFeed.TabIndex = 9;
            this.listBoxNewsFeed.ValueMember = "Albums";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(70, 198);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(0, 13);
            this.label_FullName.TabIndex = 10;
            // 
            // checkBoxRemeberMe
            // 
            this.checkBoxRemeberMe.AutoSize = true;
            this.checkBoxRemeberMe.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRemeberMe.Location = new System.Drawing.Point(176, 31);
            this.checkBoxRemeberMe.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxRemeberMe.Name = "checkBoxRemeberMe";
            this.checkBoxRemeberMe.Size = new System.Drawing.Size(94, 17);
            this.checkBoxRemeberMe.TabIndex = 11;
            this.checkBoxRemeberMe.Text = "Remember me";
            this.checkBoxRemeberMe.UseVisualStyleBackColor = false;
            this.checkBoxRemeberMe.CheckedChanged += new System.EventHandler(this.checkBoxRemeberMe_CheckedChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxSportsTeams.DataSource = this.pageSportBindingSource;
            this.listBoxSportsTeams.DisplayMember = "Name";
            this.listBoxSportsTeams.FormattingEnabled = true;
            this.listBoxSportsTeams.Location = new System.Drawing.Point(361, 398);
            this.listBoxSportsTeams.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSportsTeams.Name = "listBoxEvents";
            this.listBoxSportsTeams.Size = new System.Drawing.Size(248, 225);
            this.listBoxSportsTeams.TabIndex = 12;
            this.listBoxSportsTeams.ValueMember = "Albums";
            // 
            // pageSportBindingSource
            // 
            this.pageSportBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosts.Location = new System.Drawing.Point(16, 374);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(117, 24);
            this.labelPosts.TabIndex = 13;
            this.labelPosts.Text = "NewsFeed:";
            // 
            // label_coomnts
            // 
            this.label_coomnts.AutoSize = true;
            this.label_coomnts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coomnts.Location = new System.Drawing.Point(357, 374);
            this.label_coomnts.Name = "label_coomnts";
            this.label_coomnts.Size = new System.Drawing.Size(144, 24);
            this.label_coomnts.TabIndex = 14;
            this.label_coomnts.Text = "Sports Teams:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 625);
            this.Controls.Add(this.label_coomnts);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxSportsTeams);
            this.Controls.Add(this.checkBoxRemeberMe);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxStatusFromUser);
            this.Controls.Add(this.buttonLikeAnaylzer);
            this.Controls.Add(this.buttonMusicView);
            this.Controls.Add(this.pictureProfilePhoto);
            this.Controls.Add(this.pictureCoverPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsFeedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePhoto;
        private System.Windows.Forms.Button buttonMusicView;
        private System.Windows.Forms.Button buttonLikeAnaylzer;
        private System.Windows.Forms.TextBox textBoxStatusFromUser;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.CheckBox checkBoxRemeberMe;
        private System.Windows.Forms.ListBox listBoxSportsTeams;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label label_coomnts;
        private System.Windows.Forms.BindingSource newsFeedBindingSource;
        private System.Windows.Forms.BindingSource pageSportBindingSource;
    }
}