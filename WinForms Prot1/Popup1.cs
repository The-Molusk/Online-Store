using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class Popup1 : Form
    {
        string errText;
        public Popup1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Popup1_Load(object sender, EventArgs e)
        {
            txt_popup.Text = errText;
        }
        public void getError(string errorText)
        {
            errText = errorText;
        }
    }
}
