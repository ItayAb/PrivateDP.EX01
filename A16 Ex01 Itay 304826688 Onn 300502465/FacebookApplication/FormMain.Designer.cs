namespace FacebookApplication
{
    partial class FormMain
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
            this.pictureCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureProfilePhoto = new System.Windows.Forms.PictureBox();
            this.buttonGroupView = new System.Windows.Forms.Button();
            this.buttonLikeAnaylzer = new System.Windows.Forms.Button();
            this.textBoxStatusFromUser = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.checkBoxRemeberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCoverPhoto
            // 
            this.pictureCoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.pictureCoverPhoto.Location = new System.Drawing.Point(-3, -1);
            this.pictureCoverPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureCoverPhoto.Name = "pictureCoverPhoto";
            this.pictureCoverPhoto.Size = new System.Drawing.Size(868, 320);
            this.pictureCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCoverPhoto.TabIndex = 0;
            this.pictureCoverPhoto.TabStop = false;
            // 
            // pictureProfilePhoto
            // 
            this.pictureProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureProfilePhoto.Image = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.pictureProfilePhoto.Location = new System.Drawing.Point(344, 98);
            this.pictureProfilePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureProfilePhoto.Name = "pictureProfilePhoto";
            this.pictureProfilePhoto.Size = new System.Drawing.Size(166, 163);
            this.pictureProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfilePhoto.TabIndex = 1;
            this.pictureProfilePhoto.TabStop = false;
            // 
            // buttonGroupView
            // 
            this.buttonGroupView.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGroupView.Location = new System.Drawing.Point(344, 9);
            this.buttonGroupView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupView.Name = "buttonGroupView";
            this.buttonGroupView.Size = new System.Drawing.Size(125, 32);
            this.buttonGroupView.TabIndex = 2;
            this.buttonGroupView.Text = "Group View";
            this.buttonGroupView.UseVisualStyleBackColor = false;
            // 
            // buttonLikeAnaylzer
            // 
            this.buttonLikeAnaylzer.Location = new System.Drawing.Point(612, 9);
            this.buttonLikeAnaylzer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikeAnaylzer.Name = "buttonLikeAnaylzer";
            this.buttonLikeAnaylzer.Size = new System.Drawing.Size(140, 32);
            this.buttonLikeAnaylzer.TabIndex = 3;
            this.buttonLikeAnaylzer.Text = "Like Analyzer";
            this.buttonLikeAnaylzer.UseVisualStyleBackColor = true;
            this.buttonLikeAnaylzer.Click += new System.EventHandler(this.buttonLikeAnalyzer_Click);
            // 
            // textBoxStatusFromUser
            // 
            this.textBoxStatusFromUser.Location = new System.Drawing.Point(211, 394);
            this.textBoxStatusFromUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatusFromUser.Name = "textBoxStatusFromUser";
            this.textBoxStatusFromUser.Size = new System.Drawing.Size(435, 22);
            this.textBoxStatusFromUser.TabIndex = 5;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(48, 388);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(100, 28);
            this.buttonPostStatus.TabIndex = 6;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 562);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Button 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(27, 9);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 32);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(211, 445);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(435, 324);
            this.listBoxPosts.TabIndex = 9;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(93, 244);
            this.label_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(0, 17);
            this.label_FullName.TabIndex = 10;
            // 
            // checkBoxRemeberMe
            // 
            this.checkBoxRemeberMe.AutoSize = true;
            this.checkBoxRemeberMe.Location = new System.Drawing.Point(164, 16);
            this.checkBoxRemeberMe.Name = "checkBoxRemeberMe";
            this.checkBoxRemeberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRemeberMe.TabIndex = 11;
            this.checkBoxRemeberMe.Text = "Remember me";
            this.checkBoxRemeberMe.UseVisualStyleBackColor = true;
            this.checkBoxRemeberMe.CheckedChanged += new System.EventHandler(this.checkBoxRemeberMe_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 805);
            this.Controls.Add(this.checkBoxRemeberMe);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxStatusFromUser);
            this.Controls.Add(this.buttonLikeAnaylzer);
            this.Controls.Add(this.buttonGroupView);
            this.Controls.Add(this.pictureProfilePhoto);
            this.Controls.Add(this.pictureCoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Facebook Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCoverPhoto;
        private System.Windows.Forms.PictureBox pictureProfilePhoto;
        private System.Windows.Forms.Button buttonGroupView;
        private System.Windows.Forms.Button buttonLikeAnaylzer;
        private System.Windows.Forms.TextBox textBoxStatusFromUser;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.CheckBox checkBoxRemeberMe;
    }
}

