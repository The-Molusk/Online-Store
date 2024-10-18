namespace WinForms_Prot1
{
    partial class Checkout
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
            this.txt_cardNo = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.txt_ad1 = new System.Windows.Forms.TextBox();
            this.txt_ad2 = new System.Windows.Forms.TextBox();
            this.txt_ad3 = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.cmb_cardType = new System.Windows.Forms.ComboBox();
            this.txt_carName = new System.Windows.Forms.TextBox();
            this.txt_date_month = new System.Windows.Forms.TextBox();
            this.txt_date_year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_Title0 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.txt_date_day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cardNo
            // 
            this.txt_cardNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cardNo.Location = new System.Drawing.Point(349, 163);
            this.txt_cardNo.Name = "txt_cardNo";
            this.txt_cardNo.PlaceholderText = "Card No.";
            this.txt_cardNo.Size = new System.Drawing.Size(251, 33);
            this.txt_cardNo.TabIndex = 18;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cvv.Location = new System.Drawing.Point(634, 163);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.PlaceholderText = "CVV";
            this.txt_cvv.Size = new System.Drawing.Size(49, 33);
            this.txt_cvv.TabIndex = 19;
            // 
            // txt_ad1
            // 
            this.txt_ad1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad1.Location = new System.Drawing.Point(29, 290);
            this.txt_ad1.Name = "txt_ad1";
            this.txt_ad1.PlaceholderText = "Address line 1";
            this.txt_ad1.Size = new System.Drawing.Size(654, 33);
            this.txt_ad1.TabIndex = 20;
            // 
            // txt_ad2
            // 
            this.txt_ad2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad2.Location = new System.Drawing.Point(29, 329);
            this.txt_ad2.Name = "txt_ad2";
            this.txt_ad2.PlaceholderText = "Adress Line 2 (Not required)";
            this.txt_ad2.Size = new System.Drawing.Size(654, 33);
            this.txt_ad2.TabIndex = 21;
            // 
            // txt_ad3
            // 
            this.txt_ad3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad3.Location = new System.Drawing.Point(29, 368);
            this.txt_ad3.Name = "txt_ad3";
            this.txt_ad3.PlaceholderText = "Adress Line 3 (Not required)";
            this.txt_ad3.Size = new System.Drawing.Size(654, 33);
            this.txt_ad3.TabIndex = 22;
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_city.Location = new System.Drawing.Point(29, 407);
            this.txt_city.Name = "txt_city";
            this.txt_city.PlaceholderText = "City";
            this.txt_city.Size = new System.Drawing.Size(654, 33);
            this.txt_city.TabIndex = 23;
            // 
            // txt_zip
            // 
            this.txt_zip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_zip.Location = new System.Drawing.Point(29, 447);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.PlaceholderText = "Post/Zip code";
            this.txt_zip.Size = new System.Drawing.Size(654, 33);
            this.txt_zip.TabIndex = 24;
            // 
            // cmb_cardType
            // 
            this.cmb_cardType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_cardType.FormattingEnabled = true;
            this.cmb_cardType.Items.AddRange(new object[] {
            "Mastercard",
            "Visa",
            "Maestro",
            "EMV",
            "Platinum"});
            this.cmb_cardType.Location = new System.Drawing.Point(143, 163);
            this.cmb_cardType.Name = "cmb_cardType";
            this.cmb_cardType.Size = new System.Drawing.Size(170, 33);
            this.cmb_cardType.TabIndex = 26;
            // 
            // txt_carName
            // 
            this.txt_carName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_carName.Location = new System.Drawing.Point(349, 202);
            this.txt_carName.Name = "txt_carName";
            this.txt_carName.PlaceholderText = "Full Name on card";
            this.txt_carName.Size = new System.Drawing.Size(334, 33);
            this.txt_carName.TabIndex = 27;
            // 
            // txt_date_month
            // 
            this.txt_date_month.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_date_month.Location = new System.Drawing.Point(142, 202);
            this.txt_date_month.Name = "txt_date_month";
            this.txt_date_month.PlaceholderText = "MM";
            this.txt_date_month.Size = new System.Drawing.Size(69, 33);
            this.txt_date_month.TabIndex = 29;
            // 
            // txt_date_year
            // 
            this.txt_date_year.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_date_year.Location = new System.Drawing.Point(218, 202);
            this.txt_date_year.Name = "txt_date_year";
            this.txt_date_year.PlaceholderText = "YYYY";
            this.txt_date_year.Size = new System.Drawing.Size(95, 33);
            this.txt_date_year.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Expiry Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Card Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address";
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_country.Location = new System.Drawing.Point(29, 486);
            this.txt_country.Name = "txt_country";
            this.txt_country.PlaceholderText = "Country";
            this.txt_country.Size = new System.Drawing.Size(654, 33);
            this.txt_country.TabIndex = 34;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(93, 73);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(368, 50);
            this.lbl_Title.TabIndex = 35;
            this.lbl_Title.Text = "Payment Information";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_next.Location = new System.Drawing.Point(594, 525);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(89, 61);
            this.btn_next.TabIndex = 36;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Title0
            // 
            this.lbl_Title0.AutoSize = true;
            this.lbl_Title0.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title0.ForeColor = System.Drawing.Color.White;
            this.lbl_Title0.Location = new System.Drawing.Point(848, 97);
            this.lbl_Title0.Name = "lbl_Title0";
            this.lbl_Title0.Size = new System.Drawing.Size(223, 50);
            this.lbl_Title0.TabIndex = 38;
            this.lbl_Title0.Text = "Saved Cards";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.Location = new System.Drawing.Point(127, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(976, 35);
            this.txt_search.TabIndex = 42;
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
            this.btn_search.TabIndex = 41;
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
            this.btn_profile.Size = new System.Drawing.Size(150, 35);
            this.btn_profile.TabIndex = 40;
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
            this.btn_home.TabIndex = 39;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // txt_date_day
            // 
            this.txt_date_day.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_date_day.Location = new System.Drawing.Point(8, 53);
            this.txt_date_day.Name = "txt_date_day";
            this.txt_date_day.PlaceholderText = "DD";
            this.txt_date_day.Size = new System.Drawing.Size(41, 33);
            this.txt_date_day.TabIndex = 28;
            this.txt_date_day.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 43;
            this.label4.Text = "* Required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(-1, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(-1, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 32);
            this.label6.TabIndex = 45;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(-1, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(-1, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 32);
            this.label8.TabIndex = 47;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(319, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(606, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 32);
            this.label10.TabIndex = 49;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(319, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 32);
            this.label11.TabIndex = 50;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(112, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 32);
            this.label12.TabIndex = 51;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(113, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 32);
            this.label13.TabIndex = 52;
            this.label13.Text = "*";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lbl_Title0);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_date_year);
            this.Controls.Add(this.txt_date_month);
            this.Controls.Add(this.txt_date_day);
            this.Controls.Add(this.txt_carName);
            this.Controls.Add(this.cmb_cardType);
            this.Controls.Add(this.txt_zip);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_ad3);
            this.Controls.Add(this.txt_ad2);
            this.Controls.Add(this.txt_ad1);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_cardNo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_cardNo;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.TextBox txt_ad1;
        private System.Windows.Forms.TextBox txt_ad2;
        private System.Windows.Forms.TextBox txt_ad3;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.ComboBox cmb_cardType;
        private System.Windows.Forms.TextBox txt_carName;
        private System.Windows.Forms.TextBox txt_date_month;
        private System.Windows.Forms.TextBox txt_date_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_Title0;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.TextBox txt_date_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}