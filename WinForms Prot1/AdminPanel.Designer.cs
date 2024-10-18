namespace WinForms_Prot1
{
    partial class AdminPanel
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
            this.btn_home = new System.Windows.Forms.Button();
            this.lbl_userControl = new System.Windows.Forms.Label();
            this.lbl_productControl = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_removeUser = new System.Windows.Forms.Button();
            this.btn_accessLevel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_accessLevel = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.cbox_category = new System.Windows.Forms.ComboBox();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_removeAcess = new System.Windows.Forms.Button();
            this.btn_pardon = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_addImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_picNum = new System.Windows.Forms.Label();
            this.btn_clearImages = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // lbl_userControl
            // 
            this.lbl_userControl.AutoSize = true;
            this.lbl_userControl.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_userControl.ForeColor = System.Drawing.Color.White;
            this.lbl_userControl.Location = new System.Drawing.Point(57, 105);
            this.lbl_userControl.Name = "lbl_userControl";
            this.lbl_userControl.Size = new System.Drawing.Size(265, 41);
            this.lbl_userControl.TabIndex = 55;
            this.lbl_userControl.Text = "User Controls";
            // 
            // lbl_productControl
            // 
            this.lbl_productControl.AutoSize = true;
            this.lbl_productControl.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_productControl.ForeColor = System.Drawing.Color.White;
            this.lbl_productControl.Location = new System.Drawing.Point(734, 105);
            this.lbl_productControl.Name = "lbl_productControl";
            this.lbl_productControl.Size = new System.Drawing.Size(322, 41);
            this.lbl_productControl.TabIndex = 56;
            this.lbl_productControl.Text = "Product Controls";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Username.ForeColor = System.Drawing.Color.White;
            this.txt_Username.Location = new System.Drawing.Point(35, 149);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.Size = new System.Drawing.Size(312, 51);
            this.txt_Username.TabIndex = 57;
            // 
            // btn_removeUser
            // 
            this.btn_removeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_removeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_removeUser.Location = new System.Drawing.Point(35, 368);
            this.btn_removeUser.Name = "btn_removeUser";
            this.btn_removeUser.Size = new System.Drawing.Size(312, 35);
            this.btn_removeUser.TabIndex = 58;
            this.btn_removeUser.Text = "Remove User";
            this.btn_removeUser.UseVisualStyleBackColor = false;
            this.btn_removeUser.Click += new System.EventHandler(this.btn_removeUser_Click);
            // 
            // btn_accessLevel
            // 
            this.btn_accessLevel.BackColor = System.Drawing.Color.Cyan;
            this.btn_accessLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_accessLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_accessLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_accessLevel.Location = new System.Drawing.Point(135, 305);
            this.btn_accessLevel.Name = "btn_accessLevel";
            this.btn_accessLevel.Size = new System.Drawing.Size(212, 36);
            this.btn_accessLevel.TabIndex = 59;
            this.btn_accessLevel.Text = "Change Access Level";
            this.btn_accessLevel.UseVisualStyleBackColor = false;
            this.btn_accessLevel.Click += new System.EventHandler(this.btn_accessLevel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(450, 32);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(436, 41);
            this.lbl_title.TabIndex = 60;
            this.lbl_title.Text = "Administrator Controls";
            // 
            // txt_accessLevel
            // 
            this.txt_accessLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_accessLevel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_accessLevel.ForeColor = System.Drawing.Color.White;
            this.txt_accessLevel.Location = new System.Drawing.Point(35, 305);
            this.txt_accessLevel.Name = "txt_accessLevel";
            this.txt_accessLevel.PlaceholderText = "Level";
            this.txt_accessLevel.Size = new System.Drawing.Size(94, 36);
            this.txt_accessLevel.TabIndex = 61;
            // 
            // txt_productName
            // 
            this.txt_productName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_productName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_productName.ForeColor = System.Drawing.Color.White;
            this.txt_productName.Location = new System.Drawing.Point(411, 149);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.PlaceholderText = "Product Name";
            this.txt_productName.Size = new System.Drawing.Size(405, 36);
            this.txt_productName.TabIndex = 63;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_price.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_price.ForeColor = System.Drawing.Color.White;
            this.txt_price.Location = new System.Drawing.Point(411, 191);
            this.txt_price.Name = "txt_price";
            this.txt_price.PlaceholderText = "Price";
            this.txt_price.Size = new System.Drawing.Size(195, 36);
            this.txt_price.TabIndex = 64;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_description.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_description.ForeColor = System.Drawing.Color.White;
            this.txt_description.Location = new System.Drawing.Point(411, 230);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PlaceholderText = "Description";
            this.txt_description.Size = new System.Drawing.Size(886, 246);
            this.txt_description.TabIndex = 65;
            // 
            // cbox_category
            // 
            this.cbox_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbox_category.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_category.ForeColor = System.Drawing.Color.White;
            this.cbox_category.FormattingEnabled = true;
            this.cbox_category.Items.AddRange(new object[] {
            "Skin",
            "Vehicle",
            "Cash"});
            this.cbox_category.Location = new System.Drawing.Point(612, 191);
            this.cbox_category.Name = "cbox_category";
            this.cbox_category.Size = new System.Drawing.Size(204, 33);
            this.cbox_category.TabIndex = 66;
            this.cbox_category.Text = "Category";
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.Cyan;
            this.btn_addNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addNew.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addNew.Location = new System.Drawing.Point(612, 482);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(192, 36);
            this.btn_addNew.TabIndex = 67;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = false;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Cyan;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.Location = new System.Drawing.Point(411, 482);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(195, 36);
            this.btn_update.TabIndex = 68;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.Location = new System.Drawing.Point(822, 149);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(192, 35);
            this.btn_search.TabIndex = 69;
            this.btn_search.Text = "Display Info";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_removeAcess
            // 
            this.btn_removeAcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_removeAcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removeAcess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_removeAcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_removeAcess.Location = new System.Drawing.Point(35, 206);
            this.btn_removeAcess.Name = "btn_removeAcess";
            this.btn_removeAcess.Size = new System.Drawing.Size(312, 35);
            this.btn_removeAcess.TabIndex = 70;
            this.btn_removeAcess.Text = "Community Ban";
            this.btn_removeAcess.UseVisualStyleBackColor = false;
            this.btn_removeAcess.Click += new System.EventHandler(this.btn_removeAcess_Click);
            // 
            // btn_pardon
            // 
            this.btn_pardon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pardon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pardon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pardon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pardon.Location = new System.Drawing.Point(35, 247);
            this.btn_pardon.Name = "btn_pardon";
            this.btn_pardon.Size = new System.Drawing.Size(312, 35);
            this.btn_pardon.TabIndex = 71;
            this.btn_pardon.Text = "Pardon";
            this.btn_pardon.UseVisualStyleBackColor = false;
            this.btn_pardon.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(830, 187);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(56, 41);
            this.lbl_ID.TabIndex = 72;
            this.lbl_ID.Text = "ID";
            // 
            // btn_addImage
            // 
            this.btn_addImage.BackColor = System.Drawing.Color.Cyan;
            this.btn_addImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addImage.Location = new System.Drawing.Point(701, 527);
            this.btn_addImage.Name = "btn_addImage";
            this.btn_addImage.Size = new System.Drawing.Size(192, 36);
            this.btn_addImage.TabIndex = 73;
            this.btn_addImage.Text = "Add Image";
            this.btn_addImage.UseVisualStyleBackColor = false;
            this.btn_addImage.Click += new System.EventHandler(this.btn_addImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 41);
            this.label1.TabIndex = 74;
            this.label1.Text = "Images in use:";
            // 
            // lbl_picNum
            // 
            this.lbl_picNum.AutoSize = true;
            this.lbl_picNum.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_picNum.ForeColor = System.Drawing.Color.White;
            this.lbl_picNum.Location = new System.Drawing.Point(411, 562);
            this.lbl_picNum.Name = "lbl_picNum";
            this.lbl_picNum.Size = new System.Drawing.Size(113, 41);
            this.lbl_picNum.TabIndex = 75;
            this.lbl_picNum.Text = "[No.]";
            // 
            // btn_clearImages
            // 
            this.btn_clearImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clearImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearImages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clearImages.Location = new System.Drawing.Point(701, 569);
            this.btn_clearImages.Name = "btn_clearImages";
            this.btn_clearImages.Size = new System.Drawing.Size(192, 36);
            this.btn_clearImages.TabIndex = 76;
            this.btn_clearImages.Text = "Clear Images";
            this.btn_clearImages.UseVisualStyleBackColor = false;
            this.btn_clearImages.Click += new System.EventHandler(this.btn_clearImages_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_deleteProduct.Location = new System.Drawing.Point(810, 482);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(192, 36);
            this.btn_deleteProduct.TabIndex = 77;
            this.btn_deleteProduct.Text = "Delete";
            this.btn_deleteProduct.UseVisualStyleBackColor = false;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1309, 661);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_clearImages);
            this.Controls.Add(this.lbl_picNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addImage);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_pardon);
            this.Controls.Add(this.btn_removeAcess);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.cbox_category);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.txt_accessLevel);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_accessLevel);
            this.Controls.Add(this.btn_removeUser);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_productControl);
            this.Controls.Add(this.lbl_userControl);
            this.Controls.Add(this.btn_home);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_userControl;
        private System.Windows.Forms.Label lbl_productControl;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_removeUser;
        private System.Windows.Forms.Button btn_accessLevel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_accessLevel;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ComboBox cbox_category;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_removeAcess;
        private System.Windows.Forms.Button btn_pardon;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_addImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_picNum;
        private System.Windows.Forms.Button btn_clearImages;
        private System.Windows.Forms.Button btn_deleteProduct;
    }
}