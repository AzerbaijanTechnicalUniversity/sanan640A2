using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectaztu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection con = new SqlConnection(DALC.GetConnectionString());

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Users where username ='" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("ugurlu");
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("istifadeci adi veya sifre yanlisdir");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
