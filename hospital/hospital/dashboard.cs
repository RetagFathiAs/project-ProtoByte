using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
namespace hospital
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            if (System.Diagnostics.Debugger.IsAttached)
            { this.StartPosition = FormStartPosition.CenterScreen; }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void addpatient_Click(object sender, EventArgs e)
        {
            addcreator1.ForeColor = System.Drawing.Color.Red;
            addcreator2.ForeColor = System.Drawing.Color.Black;
            addcreator3.ForeColor = System.Drawing.Color.Black;
            addcreator4.ForeColor = System.Drawing.Color.Black;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            pictureBox1.Visible = false;
            panel4.Visible = false;
        }

        private void adddiagnosis_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            pictureBox1.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            addcreator2.ForeColor = System.Drawing.Color.Red;
            addcreator3.ForeColor = System.Drawing.Color.Black;
            addcreator1.ForeColor = System.Drawing.Color.Black;
            addcreator4.ForeColor = System.Drawing.Color.Black;
            
        }

        private void history_Click(object sender, EventArgs e)
        {
            addcreator3.ForeColor = System.Drawing.Color.Red;
            addcreator2.ForeColor = System.Drawing.Color.Black;
            addcreator4.ForeColor = System.Drawing.Color.Black;
            addcreator1.ForeColor = System.Drawing.Color.Black;
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FAMILY-PC; database = Zhospital; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient inner join Patientmore on AddPatient.pid = Patientmore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];

        }

        private void hospitalinfo_Click(object sender, EventArgs e)
        {
            addcreator4.ForeColor = System.Drawing.Color.Red;
            addcreator2.ForeColor = System.Drawing.Color.Black;
            addcreator3.ForeColor = System.Drawing.Color.Black;
            addcreator1.ForeColor = System.Drawing.Color.Black;
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false; 
            panel3.Visible = false;
            pictureBox1.Visible = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = namebox.Text;
                string address = addressbox.Text;
                int age = Convert.ToInt32(agebox.Text);
                Int64 contact = Convert.ToInt64(contactbox.Text);
                string gender = combogender.Text;
                string bgroup = bloodbox.Text;
                string disease = igg.Text;
                int patid = Convert.ToInt32(patientid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FAMILY-PC; database = Zhospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + name + "','" + address + "','" + contact + "','" + age + "','" + gender + "','" + bgroup + "','" + disease + "','" + patid + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show(" Data Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Formate OR Patient is already Exist !");
            }


            namebox.Clear();
            addressbox.Clear();
            agebox.Clear();
            contactbox.Clear();
            combogender.ResetText();
            bloodbox.Clear();
            igg.Clear();
            patientid.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {int pid = Convert.ToInt32(textBox1.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = FAMILY-PC; database = Zhospital;integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient where pid = "+ pid +"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                string sympt = sybox.Text;
                string diag = dibox.Text;
                string medicines = medbox.Text;
                string ward = reqward.Text;
                string ward_type = tward.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = FAMILY-PC; database = Zhospital;integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Patientmore values(" + pid + ",'" + sympt + "','" + diag + "','" + medicines + "','" + ward + "','" + ward_type + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show(" Data Saved.");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Formate.");
            }

            textBox1.Clear();
            sybox.Clear();
            dibox.Clear();
            medbox.Clear();
            reqward.ResetText();
            tward.ResetText();

        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}

