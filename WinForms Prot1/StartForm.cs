using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForms_Prot1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            
        }

        private void StartForm_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
