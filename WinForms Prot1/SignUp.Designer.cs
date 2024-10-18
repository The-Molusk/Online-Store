
namespace WinForms_Prot1
{
    partial class SignUp
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.cBox_TAC = new System.Windows.Forms.CheckBox();
            this.lbl_TAC = new System.Windows.Forms.Label();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.lbl_HaveAcc = new System.Windows.Forms.Label();
            this.btn_LoginPage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_title.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(471, 66);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(418, 112);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Sign Up";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.Location = new System.Drawing.Point(471, 191);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.Size = new System.Drawing.Size(418, 39);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.Location = new System.Drawing.Point(471, 236);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceholderText = "E-Mail";
            this.txt_email.Size = new System.Drawing.Size(418, 39);
            this.txt_email.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(471, 281);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(418, 39);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_confirmPassword.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.txt_confirmPassword.Location = new System.Drawing.Point(471, 326);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PlaceholderText = "Confirm Password";
            this.txt_confirmPassword.Size = new System.Drawing.Size(418, 39);
            this.txt_confirmPassword.TabIndex = 5;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // cBox_TAC
            // 
            this.cBox_TAC.AutoSize = true;
            this.cBox_TAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cBox_TAC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_TAC.Location = new System.Drawing.Point(487, 416);
            this.cBox_TAC.Name = "cBox_TAC";
            this.cBox_TAC.Size = new System.Drawing.Size(229, 19);
            this.cBox_TAC.TabIndex = 7;
            this.cBox_TAC.Text = "I have read and agree to the ";
            this.cBox_TAC.UseVisualStyleBackColor = false;
            this.cBox_TAC.CheckedChanged += new System.EventHandler(this.cBox_TAC_CheckedChanged);
            // 
            // lbl_TAC
            // 
            this.lbl_TAC.AutoSize = true;
            this.lbl_TAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_TAC.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_TAC.Location = new System.Drawing.Point(715, 417);
            this.lbl_TAC.Name = "lbl_TAC";
            this.lbl_TAC.Size = new System.Drawing.Size(147, 15);
            this.lbl_TAC.TabIndex = 11;
            this.lbl_TAC.Text = "Terms and Conditions";
            this.lbl_TAC.Click += new System.EventHandler(this.lbl_TAC_Click);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Proceed.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Proceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Proceed.Location = new System.Drawing.Point(569, 450);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(209, 46);
            this.btn_Proceed.TabIndex = 8;
            this.btn_Proceed.Text = "Sign Up";
            this.btn_Proceed.UseVisualStyleBackColor = false;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // lbl_HaveAcc
            // 
            this.lbl_HaveAcc.AutoSize = true;
            this.lbl_HaveAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_HaveAcc.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_HaveAcc.Location = new System.Drawing.Point(569, 499);
            this.lbl_HaveAcc.Name = "lbl_HaveAcc";
            this.lbl_HaveAcc.Size = new System.Drawing.Size(200, 18);
            this.lbl_HaveAcc.TabIndex = 9;
            this.lbl_HaveAcc.Text = "Already have an account?";
            // 
            // btn_LoginPage
            // 
            this.btn_LoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LoginPage.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_LoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_LoginPage.Location = new System.Drawing.Point(600, 520);
            this.btn_LoginPage.Name = "btn_LoginPage";
            this.btn_LoginPage.Size = new System.Drawing.Size(147, 35);
            this.btn_LoginPage.TabIndex = 10;
            this.btn_LoginPage.Text = "Login";
            this.btn_LoginPage.UseVisualStyleBackColor = false;
            this.btn_LoginPage.Click += new System.EventHandler(this.btn_LoginPage_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Phone.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Phone.ForeColor = System.Drawing.Color.White;
            this.txt_Phone.Location = new System.Drawing.Point(471, 371);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PlaceholderText = "Phone Number";
            this.txt_Phone.Size = new System.Drawing.Size(418, 39);
            this.txt_Phone.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(411, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 569);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            this.btn_home.TabIndex = 49;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.btn_LoginPage);
            this.Controls.Add(this.lbl_HaveAcc);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.lbl_TAC);
            this.Controls.Add(this.cBox_TAC);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.CheckBox cBox_TAC;
        private System.Windows.Forms.Label lbl_TAC;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.Label lbl_HaveAcc;
        private System.Windows.Forms.Button btn_LoginPage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
    }
}