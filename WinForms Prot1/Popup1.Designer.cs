
namespace WinForms_Prot1
{
    partial class Popup1
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
            this.txt_popup = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_popup
            // 
            this.txt_popup.AutoSize = true;
            this.txt_popup.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_popup.Location = new System.Drawing.Point(12, 9);
            this.txt_popup.Name = "txt_popup";
            this.txt_popup.Size = new System.Drawing.Size(154, 56);
            this.txt_popup.TabIndex = 0;
            this.txt_popup.Text = "POPUP";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(140, 68);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 35);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Popup1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 115);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_popup);
            this.Name = "Popup1";
            this.Text = "Popup1";
            this.Load += new System.EventHandler(this.Popup1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_popup;
        private System.Windows.Forms.Button btn_ok;
    }
}