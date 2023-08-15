using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace softwarecode
{
    public partial class Hotels : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Travel_agency;Integrated Security=True");
        public Hotels()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Add_Hotels values ('"+textBox1.Text+"','"+comboBox4.Text+"','"+textBox4.Text +"', '"+dateTimePicker1.MaxDate+"','"+dateTimePicker2.MaxDate+ "','"+comboBox1.Text+"','"+textBox8.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+comboBox5.Text+"','"+comboBox2.Text+"','"+comboBox3.Text+"')";
        
            cmd.ExecuteNonQuery();
            conn.Close();

            display();
            MessageBox.Show("Record Added Successfuly");
            
        
        
        
        }
        public void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Add_Hotels";


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            conn.Close();

            


        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            display();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Add_Hotels where Reservation_ID ='" + textBox4.Text + "'";

            cmd.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("record deleted successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Add_Hotels set Hotel_Name ='" + textBox1.Text + "' where Reservation_ID = '" + textBox4.Text + "'";

            cmd.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("record Edited successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Add_Hotels where Reservation_ID = '" + textBox4.Text + "'";


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
           

        }
    }
}
