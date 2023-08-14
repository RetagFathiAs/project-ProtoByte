using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (System.Diagnostics.Debugger.IsAttached)
            { this.StartPosition = FormStartPosition.CenterScreen; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            label2.BackColor = Color.Transparent;
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = user.Text;
            String pass = password.Text;
            if (username == "Retag" && pass == "123")
            {
                this.Hide();
                dashboard ds = new dashboard();
                ds.Show();
            }
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
