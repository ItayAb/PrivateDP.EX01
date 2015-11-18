namespace FacebookApplication
{
    public partial class LikeAnalyzerForm
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
            this.listBoxDescendingLikeFriends = new System.Windows.Forms.ListBox();
            this.PictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxRecentPost = new System.Windows.Forms.ListBox();
            this.buttonLikeBack = new System.Windows.Forms.Button();
            this.buttonRunAnalysis = new System.Windows.Forms.Button();
            this.textBoxAmountPostsToParse = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfLikeForUser = new System.Windows.Forms.TextBox();
            this.labelAmountOfLikesHeader = new System.Windows.Forms.Label();
            this.textBoxAmountOfPosts = new System.Windows.Forms.TextBox();
            this.label_ChooseAmountOfPosts = new System.Windows.Forms.Label();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.labelOverallPostHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDescendingLikeFriends
            // 
            this.listBoxDescendingLikeFriends.FormattingEnabled = true;
            this.listBoxDescendingLikeFriends.ItemHeight = 16;
            this.listBoxDescendingLikeFriends.Location = new System.Drawing.Point(18, 443);
            this.listBoxDescendingLikeFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDescendingLikeFriends.Name = "listBoxDescendingLikeFriends";
            this.listBoxDescendingLikeFriends.Size = new System.Drawing.Size(159, 260);
            this.listBoxDescendingLikeFriends.TabIndex = 0;
            this.listBoxDescendingLikeFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxDescendingLikeFriends_SelectedIndexChanged);
            // 
            // PictureBoxSelectedFriend
            // 
            this.PictureBoxSelectedFriend.Location = new System.Drawing.Point(238, 443);
            this.PictureBoxSelectedFriend.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxSelectedFriend.Name = "PictureBoxSelectedFriend";
            this.PictureBoxSelectedFriend.Size = new System.Drawing.Size(133, 106);
            this.PictureBoxSelectedFriend.TabIndex = 1;
            this.PictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxRecentPost
            // 
            this.listBoxRecentPost.FormattingEnabled = true;
            this.listBoxRecentPost.ItemHeight = 16;
            this.listBoxRecentPost.Location = new System.Drawing.Point(233, 587);
            this.listBoxRecentPost.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRecentPost.Name = "listBoxRecentPost";
            this.listBoxRecentPost.Size = new System.Drawing.Size(265, 116);
            this.listBoxRecentPost.TabIndex = 2;
            // 
            // buttonLikeBack
            // 
            this.buttonLikeBack.Location = new System.Drawing.Point(398, 521);
            this.buttonLikeBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikeBack.Name = "buttonLikeBack";
            this.buttonLikeBack.Size = new System.Drawing.Size(100, 28);
            this.buttonLikeBack.TabIndex = 3;
            this.buttonLikeBack.Text = "Like Back";
            this.buttonLikeBack.UseVisualStyleBackColor = true;
            this.buttonLikeBack.Click += new System.EventHandler(this.buttonLikeBack_Click);
            // 
            // buttonRunAnalysis
            // 
            this.buttonRunAnalysis.BackColor = System.Drawing.Color.Lime;
            this.buttonRunAnalysis.Font = new System.Drawing.Font("Aharoni", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunAnalysis.Location = new System.Drawing.Point(18, 384);
            this.buttonRunAnalysis.Name = "buttonRunAnalysis";
            this.buttonRunAnalysis.Size = new System.Drawing.Size(159, 42);
            this.buttonRunAnalysis.TabIndex = 4;
            this.buttonRunAnalysis.Text = "Run Analysis";
            this.buttonRunAnalysis.UseVisualStyleBackColor = false;
            this.buttonRunAnalysis.Click += new System.EventHandler(this.button_RunAnalysis_Click);
            // 
            // textBoxAmountPostsToParse
            // 
            this.textBoxAmountPostsToParse.Location = new System.Drawing.Point(233, 394);
            this.textBoxAmountPostsToParse.Name = "textBoxAmountPostsToParse";
            this.textBoxAmountPostsToParse.Size = new System.Drawing.Size(220, 22);
            this.textBoxAmountPostsToParse.TabIndex = 5;
            // 
            // textBoxAmountOfLikeForUser
            // 
            this.textBoxAmountOfLikeForUser.Location = new System.Drawing.Point(398, 474);
            this.textBoxAmountOfLikeForUser.Name = "textBoxAmountOfLikeForUser";
            this.textBoxAmountOfLikeForUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmountOfLikeForUser.TabIndex = 6;
            // 
            // labelAmountOfLikesHeader
            // 
            this.labelAmountOfLikesHeader.AutoSize = true;
            this.labelAmountOfLikesHeader.Location = new System.Drawing.Point(395, 443);
            this.labelAmountOfLikesHeader.Name = "labelAmountOfLikesHeader";
            this.labelAmountOfLikesHeader.Size = new System.Drawing.Size(112, 17);
            this.labelAmountOfLikesHeader.TabIndex = 7;
            this.labelAmountOfLikesHeader.Text = "Amount Of Likes";
            // 
            // textBoxAmountOfPosts
            // 
            this.textBoxAmountOfPosts.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxAmountOfPosts.Location = new System.Drawing.Point(195, 276);
            this.textBoxAmountOfPosts.Name = "textBoxAmountOfPosts";
            this.textBoxAmountOfPosts.ReadOnly = true;
            this.textBoxAmountOfPosts.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmountOfPosts.TabIndex = 9;
            // 
            // label_ChooseAmountOfPosts
            // 
            this.label_ChooseAmountOfPosts.AutoSize = true;
            this.label_ChooseAmountOfPosts.Location = new System.Drawing.Point(235, 364);
            this.label_ChooseAmountOfPosts.Name = "label_ChooseAmountOfPosts";
            this.label_ChooseAmountOfPosts.Size = new System.Drawing.Size(218, 17);
            this.label_ChooseAmountOfPosts.TabIndex = 10;
            this.label_ChooseAmountOfPosts.Text = "Choose how many posts to check";
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(658, 246);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 11;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // labelOverallPostHeader
            // 
            this.labelOverallPostHeader.AutoSize = true;
            this.labelOverallPostHeader.Location = new System.Drawing.Point(29, 279);
            this.labelOverallPostHeader.Name = "labelOverallPostHeader";
            this.labelOverallPostHeader.Size = new System.Drawing.Size(160, 17);
            this.labelOverallPostHeader.TabIndex = 8;
            this.labelOverallPostHeader.Text = "Overall number of Posts";
            // 
            // LikeAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 716);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.label_ChooseAmountOfPosts);
            this.Controls.Add(this.textBoxAmountOfPosts);
            this.Controls.Add(this.labelOverallPostHeader);
            this.Controls.Add(this.labelAmountOfLikesHeader);
            this.Controls.Add(this.textBoxAmountOfLikeForUser);
            this.Controls.Add(this.textBoxAmountPostsToParse);
            this.Controls.Add(this.buttonRunAnalysis);
            this.Controls.Add(this.buttonLikeBack);
            this.Controls.Add(this.listBoxRecentPost);
            this.Controls.Add(this.PictureBoxSelectedFriend);
            this.Controls.Add(this.listBoxDescendingLikeFriends);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LikeAnalyzerForm";
            this.Text = "Like Analyzer ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDescendingLikeFriends;
        private System.Windows.Forms.PictureBox PictureBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxRecentPost;
        private System.Windows.Forms.Button buttonLikeBack;
        private System.Windows.Forms.Button buttonRunAnalysis;
        private System.Windows.Forms.TextBox textBoxAmountPostsToParse;
        private System.Windows.Forms.TextBox textBoxAmountOfLikeForUser;
        private System.Windows.Forms.Label labelAmountOfLikesHeader;
        private System.Windows.Forms.TextBox textBoxAmountOfPosts;
        private System.Windows.Forms.Label label_ChooseAmountOfPosts;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.Label labelOverallPostHeader;
    }
}