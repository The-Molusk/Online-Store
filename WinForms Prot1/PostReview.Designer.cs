namespace WinForms_Prot1
{
    partial class PostReview
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.btn_post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(127, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(976, 35);
            this.txt_search.TabIndex = 54;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Location = new System.Drawing.Point(1109, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(39, 35);
            this.btn_search.TabIndex = 53;
            this.btn_search.Text = ">";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_profile.Location = new System.Drawing.Point(1154, 12);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(130, 35);
            this.btn_profile.TabIndex = 52;
            this.btn_profile.Text = "Profile/Login";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_home.Location = new System.Drawing.Point(12, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(109, 35);
            this.btn_home.TabIndex = 51;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(15, 93);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(213, 47);
            this.lbl_title.TabIndex = 55;
            this.lbl_title.Text = "New Review:";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_rating
            // 
            this.txt_rating.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_rating.Location = new System.Drawing.Point(25, 176);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(71, 50);
            this.txt_rating.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "/10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_review
            // 
            this.txt_review.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_review.Location = new System.Drawing.Point(25, 232);
            this.txt_review.Multiline = true;
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(851, 294);
            this.txt_review.TabIndex = 58;
            // 
            // btn_post
            // 
            this.btn_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_post.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_post.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_post.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_post.Location = new System.Drawing.Point(25, 532);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(203, 45);
            this.btn_post.TabIndex = 59;
            this.btn_post.Text = "Post Review";
            this.btn_post.UseVisualStyleBackColor = false;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // PostReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.txt_review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_home);
            this.Name = "PostReview";
            this.Text = "PostReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.Button btn_post;
    }
}