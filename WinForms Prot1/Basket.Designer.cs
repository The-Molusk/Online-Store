namespace WinForms_Prot1
{
    partial class Basket
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
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.btn_clearBasket = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(1016, 120);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(100, 50);
            this.lbl_Title.TabIndex = 13;
            this.lbl_Title.Text = "Total";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_totalPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_totalPrice.Location = new System.Drawing.Point(1016, 170);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_totalPrice.Size = new System.Drawing.Size(42, 50);
            this.lbl_totalPrice.TabIndex = 14;
            this.lbl_totalPrice.Text = "£";
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Checkout.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Checkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Checkout.Location = new System.Drawing.Point(886, 224);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(376, 61);
            this.btn_Checkout.TabIndex = 15;
            this.btn_Checkout.Text = "Proceed to Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // btn_clearBasket
            // 
            this.btn_clearBasket.BackColor = System.Drawing.Color.Red;
            this.btn_clearBasket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearBasket.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearBasket.ForeColor = System.Drawing.Color.White;
            this.btn_clearBasket.Location = new System.Drawing.Point(886, 291);
            this.btn_clearBasket.Name = "btn_clearBasket";
            this.btn_clearBasket.Size = new System.Drawing.Size(376, 61);
            this.btn_clearBasket.TabIndex = 16;
            this.btn_clearBasket.Text = "Clear Basket";
            this.btn_clearBasket.UseVisualStyleBackColor = false;
            this.btn_clearBasket.Click += new System.EventHandler(this.btn_clearBasket_Click);
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
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clearBasket);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Basket";
            this.Text = "Basket";
            this.Load += new System.EventHandler(this.Basket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Button btn_clearBasket;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_home;
    }
}