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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DALC.GetConnectionString());

            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username,Email,Password)  VALUES(@istadi,@maili,@parol)", con);

            cmd.Parameters.AddWithValue("istadi", textBox1.Text);
            cmd.Parameters.AddWithValue("maili", textBox3.Text);
            cmd.Parameters.AddWithValue("parol", textBox2.Text);



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success");

                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
