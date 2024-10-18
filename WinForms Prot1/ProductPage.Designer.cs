namespace WinForms_Prot1
{
    partial class ProductPage
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_basketAdd = new System.Windows.Forms.Button();
            this.btn_buyNow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_ratings = new System.Windows.Forms.Button();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(454, 79);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(484, 86);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "[Product Name]";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_category.Location = new System.Drawing.Point(467, 208);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(186, 30);
            this.lbl_category.TabIndex = 14;
            this.lbl_category.Text = "[Product Category]";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.ForeColor = System.Drawing.Color.Gray;
            this.lbl_ID.Location = new System.Drawing.Point(467, 79);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(67, 13);
            this.lbl_ID.TabIndex = 15;
            this.lbl_ID.Text = "[Product ID]";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_basketAdd
            // 
            this.btn_basketAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_basketAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_basketAdd.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_basketAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_basketAdd.Location = new System.Drawing.Point(1046, 104);
            this.btn_basketAdd.Name = "btn_basketAdd";
            this.btn_basketAdd.Size = new System.Drawing.Size(251, 61);
            this.btn_basketAdd.TabIndex = 16;
            this.btn_basketAdd.Text = "Add to basket";
            this.btn_basketAdd.UseVisualStyleBackColor = false;
            this.btn_basketAdd.Click += new System.EventHandler(this.btn_basketAdd_Click);
            // 
            // btn_buyNow
            // 
            this.btn_buyNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_buyNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buyNow.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buyNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buyNow.Location = new System.Drawing.Point(1046, 171);
            this.btn_buyNow.Name = "btn_buyNow";
            this.btn_buyNow.Size = new System.Drawing.Size(251, 61);
            this.btn_buyNow.TabIndex = 17;
            this.btn_buyNow.Text = "Buy Now";
            this.btn_buyNow.UseVisualStyleBackColor = false;
            this.btn_buyNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(467, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_desc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_desc.ForeColor = System.Drawing.Color.White;
            this.txt_desc.Location = new System.Drawing.Point(467, 322);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(546, 244);
            this.txt_desc.TabIndex = 19;
            this.txt_desc.Text = "[Product Description]";
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_previous.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(297, 515);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(67, 51);
            this.btn_previous.TabIndex = 23;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(370, 515);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(72, 51);
            this.btn_next.TabIndex = 22;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(463, 161);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(248, 47);
            this.lbl_price.TabIndex = 27;
            this.lbl_price.Text = "[Product Price]";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(127, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(976, 35);
            this.txt_search.TabIndex = 46;
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
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = ">";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_profile.Location = new System.Drawing.Point(1154, 12);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(150, 35);
            this.btn_profile.TabIndex = 44;
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
            this.btn_home.TabIndex = 43;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_ratings
            // 
            this.btn_ratings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ratings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ratings.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ratings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ratings.Location = new System.Drawing.Point(1046, 322);
            this.btn_ratings.Name = "btn_ratings";
            this.btn_ratings.Size = new System.Drawing.Size(251, 61);
            this.btn_ratings.TabIndex = 47;
            this.btn_ratings.Text = "Reviews";
            this.btn_ratings.UseVisualStyleBackColor = false;
            this.btn_ratings.Click += new System.EventHandler(this.btn_ratings_Click);
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rating.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_rating.Location = new System.Drawing.Point(467, 238);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(278, 47);
            this.lbl_rating.TabIndex = 48;
            this.lbl_rating.Text = "[Average Rating]";
            this.lbl_rating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.btn_ratings);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buyNow);
            this.Controls.Add(this.btn_basketAdd);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_Title);
            this.Name = "ProductPage";
            this.Text = "ProductPage";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_basketAdd;
        private System.Windows.Forms.Button btn_buyNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_ratings;
        private System.Windows.Forms.Label lbl_rating;
    }
}