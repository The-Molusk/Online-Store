
namespace WinForms_Prot1
{
    partial class Profile
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
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_changePfp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_infoTitle = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_phoneNo = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_changeInfo = new System.Windows.Forms.Button();
            this.btn_viewPurchases = new System.Windows.Forms.Button();
            this.btn_delAcc = new System.Windows.Forms.Button();
            this.lbl_access = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_Basket = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_signOut = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_dateDay = new System.Windows.Forms.TextBox();
            this.txt_dateMonth = new System.Windows.Forms.TextBox();
            this.txt_dateYear = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_profile
            // 
            this.pic_profile.Location = new System.Drawing.Point(45, 96);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(160, 160);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_profile.TabIndex = 0;
            this.pic_profile.TabStop = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(219, 96);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(312, 75);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(219, 215);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(132, 41);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail";
            // 
            // btn_changePfp
            // 
            this.btn_changePfp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_changePfp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changePfp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changePfp.ForeColor = System.Drawing.Color.White;
            this.btn_changePfp.Location = new System.Drawing.Point(44, 262);
            this.btn_changePfp.Name = "btn_changePfp";
            this.btn_changePfp.Size = new System.Drawing.Size(161, 25);
            this.btn_changePfp.TabIndex = 4;
            this.btn_changePfp.Text = "Upload Image";
            this.btn_changePfp.UseVisualStyleBackColor = false;
            this.btn_changePfp.Click += new System.EventHandler(this.btn_changePfp_Click);
            // 
            // txt_infoTitle
            // 
            this.txt_infoTitle.AutoSize = true;
            this.txt_infoTitle.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_infoTitle.ForeColor = System.Drawing.Color.White;
            this.txt_infoTitle.Location = new System.Drawing.Point(43, 290);
            this.txt_infoTitle.Name = "txt_infoTitle";
            this.txt_infoTitle.Size = new System.Drawing.Size(265, 41);
            this.txt_infoTitle.TabIndex = 5;
            this.txt_infoTitle.Text = "Personal Info";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DOB.ForeColor = System.Drawing.Color.White;
            this.lbl_DOB.Location = new System.Drawing.Point(43, 387);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(150, 22);
            this.lbl_DOB.TabIndex = 6;
            this.lbl_DOB.Text = "Date of birth:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(43, 348);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(60, 22);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phoneNo.ForeColor = System.Drawing.Color.White;
            this.lbl_phoneNo.Location = new System.Drawing.Point(43, 429);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(140, 22);
            this.lbl_phoneNo.TabIndex = 8;
            this.lbl_phoneNo.Text = "Phone number:";
            // 
            // btn_changeInfo
            // 
            this.btn_changeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_changeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_changeInfo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_changeInfo.ForeColor = System.Drawing.Color.White;
            this.btn_changeInfo.Location = new System.Drawing.Point(42, 556);
            this.btn_changeInfo.Name = "btn_changeInfo";
            this.btn_changeInfo.Size = new System.Drawing.Size(433, 32);
            this.btn_changeInfo.TabIndex = 9;
            this.btn_changeInfo.Text = "Change Information";
            this.btn_changeInfo.UseVisualStyleBackColor = false;
            this.btn_changeInfo.Click += new System.EventHandler(this.btn_changeInfo_Click);
            // 
            // btn_viewPurchases
            // 
            this.btn_viewPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_viewPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewPurchases.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_viewPurchases.ForeColor = System.Drawing.Color.White;
            this.btn_viewPurchases.Location = new System.Drawing.Point(780, 100);
            this.btn_viewPurchases.Name = "btn_viewPurchases";
            this.btn_viewPurchases.Size = new System.Drawing.Size(505, 65);
            this.btn_viewPurchases.TabIndex = 10;
            this.btn_viewPurchases.Text = "Past Purchases / Product Keys";
            this.btn_viewPurchases.UseVisualStyleBackColor = false;
            this.btn_viewPurchases.Click += new System.EventHandler(this.btn_viewPurchases_Click);
            // 
            // btn_delAcc
            // 
            this.btn_delAcc.BackColor = System.Drawing.Color.Maroon;
            this.btn_delAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delAcc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delAcc.ForeColor = System.Drawing.Color.White;
            this.btn_delAcc.Location = new System.Drawing.Point(262, 594);
            this.btn_delAcc.Name = "btn_delAcc";
            this.btn_delAcc.Size = new System.Drawing.Size(213, 32);
            this.btn_delAcc.TabIndex = 14;
            this.btn_delAcc.Text = "Delete Account";
            this.btn_delAcc.UseVisualStyleBackColor = false;
            this.btn_delAcc.Click += new System.EventHandler(this.btn_delAcc_Click);
            // 
            // lbl_access
            // 
            this.lbl_access.AutoSize = true;
            this.lbl_access.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_access.ForeColor = System.Drawing.Color.White;
            this.lbl_access.Location = new System.Drawing.Point(219, 171);
            this.lbl_access.Name = "lbl_access";
            this.lbl_access.Size = new System.Drawing.Size(265, 41);
            this.lbl_access.TabIndex = 15;
            this.lbl_access.Text = "[AccessLevel]";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(127, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(976, 35);
            this.txt_search.TabIndex = 50;
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
            this.btn_search.TabIndex = 49;
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
            this.btn_profile.Size = new System.Drawing.Size(143, 35);
            this.btn_profile.TabIndex = 48;
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
            this.btn_home.TabIndex = 47;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_Basket
            // 
            this.btn_Basket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Basket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Basket.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Basket.ForeColor = System.Drawing.Color.White;
            this.btn_Basket.Location = new System.Drawing.Point(780, 171);
            this.btn_Basket.Name = "btn_Basket";
            this.btn_Basket.Size = new System.Drawing.Size(505, 65);
            this.btn_Basket.TabIndex = 51;
            this.btn_Basket.Text = "Basket";
            this.btn_Basket.UseVisualStyleBackColor = false;
            this.btn_Basket.Click += new System.EventHandler(this.btn_Basket_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_admin.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.ForeColor = System.Drawing.Color.White;
            this.btn_admin.Location = new System.Drawing.Point(780, 557);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(505, 65);
            this.btn_admin.TabIndex = 52;
            this.btn_admin.Text = "Administrator Options";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_signOut
            // 
            this.btn_signOut.BackColor = System.Drawing.Color.Maroon;
            this.btn_signOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_signOut.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_signOut.ForeColor = System.Drawing.Color.White;
            this.btn_signOut.Location = new System.Drawing.Point(43, 594);
            this.btn_signOut.Name = "btn_signOut";
            this.btn_signOut.Size = new System.Drawing.Size(213, 32);
            this.btn_signOut.TabIndex = 53;
            this.btn_signOut.Text = "Sign Out";
            this.btn_signOut.UseVisualStyleBackColor = false;
            this.btn_signOut.Click += new System.EventHandler(this.btn_signOut_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(109, 338);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(422, 35);
            this.txt_name.TabIndex = 54;
            // 
            // txt_dateDay
            // 
            this.txt_dateDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dateDay.Location = new System.Drawing.Point(199, 379);
            this.txt_dateDay.Name = "txt_dateDay";
            this.txt_dateDay.Size = new System.Drawing.Size(57, 35);
            this.txt_dateDay.TabIndex = 55;
            // 
            // txt_dateMonth
            // 
            this.txt_dateMonth.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dateMonth.Location = new System.Drawing.Point(262, 379);
            this.txt_dateMonth.Name = "txt_dateMonth";
            this.txt_dateMonth.Size = new System.Drawing.Size(57, 35);
            this.txt_dateMonth.TabIndex = 56;
            // 
            // txt_dateYear
            // 
            this.txt_dateYear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dateYear.Location = new System.Drawing.Point(325, 379);
            this.txt_dateYear.Name = "txt_dateYear";
            this.txt_dateYear.Size = new System.Drawing.Size(102, 35);
            this.txt_dateYear.TabIndex = 57;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phoneNo.Location = new System.Drawing.Point(189, 420);
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(312, 35);
            this.txt_phoneNo.TabIndex = 59;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirm.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_confirm.Location = new System.Drawing.Point(262, 556);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(213, 32);
            this.btn_confirm.TabIndex = 60;
            this.btn_confirm.Text = "Confirm Changes";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.Location = new System.Drawing.Point(43, 556);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(213, 32);
            this.btn_cancel.TabIndex = 61;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.txt_dateYear);
            this.Controls.Add(this.txt_dateMonth);
            this.Controls.Add(this.txt_dateDay);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_signOut);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_Basket);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_access);
            this.Controls.Add(this.btn_delAcc);
            this.Controls.Add(this.btn_viewPurchases);
            this.Controls.Add(this.btn_changeInfo);
            this.Controls.Add(this.lbl_phoneNo);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.txt_infoTitle);
            this.Controls.Add(this.btn_changePfp);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_profile;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_changePfp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label txt_infoTitle;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_phoneNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_changeInfo;
        private System.Windows.Forms.Button btn_viewPurchases;
        private System.Windows.Forms.Button btn_delAcc;
        private System.Windows.Forms.Label lbl_access;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_Basket;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_signOut;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_dateDay;
        private System.Windows.Forms.TextBox txt_dateMonth;
        private System.Windows.Forms.TextBox txt_dateYear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}