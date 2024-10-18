
namespace WinForms_Prot1
{
    partial class Login
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.btn_forgot = new System.Windows.Forms.Button();
            this.btn_noAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbl_title.Location = new System.Drawing.Point(507, 83);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(312, 112);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Login";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.Location = new System.Drawing.Point(507, 254);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.Size = new System.Drawing.Size(312, 51);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.Location = new System.Drawing.Point(507, 338);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(312, 51);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_proceed
            // 
            this.btn_proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_proceed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_proceed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_proceed.Location = new System.Drawing.Point(579, 411);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(169, 41);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "Login";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // btn_forgot
            // 
            this.btn_forgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_forgot.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_forgot.Location = new System.Drawing.Point(579, 507);
            this.btn_forgot.Name = "btn_forgot";
            this.btn_forgot.Size = new System.Drawing.Size(169, 23);
            this.btn_forgot.TabIndex = 4;
            this.btn_forgot.Text = "Forgot your password?";
            this.btn_forgot.UseVisualStyleBackColor = false;
            this.btn_forgot.Click += new System.EventHandler(this.btn_forgot_Click);
            // 
            // btn_noAcc
            // 
            this.btn_noAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_noAcc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_noAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_noAcc.Location = new System.Drawing.Point(579, 478);
            this.btn_noAcc.Name = "btn_noAcc";
            this.btn_noAcc.Size = new System.Drawing.Size(169, 23);
            this.btn_noAcc.TabIndex = 5;
            this.btn_noAcc.Text = "Sign Up";
            this.btn_noAcc.UseVisualStyleBackColor = false;
            this.btn_noAcc.Click += new System.EventHandler(this.btn_noAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(595, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\'t have an account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Location = new System.Drawing.Point(442, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 509);
            this.pictureBox1.TabIndex = 7;
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
            this.btn_home.TabIndex = 48;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_noAcc);
            this.Controls.Add(this.btn_forgot);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Button btn_forgot;
        private System.Windows.Forms.Button btn_noAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
    }
}