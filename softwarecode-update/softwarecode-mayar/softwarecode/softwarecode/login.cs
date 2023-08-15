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

namespace softwarecode
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Travel_agency;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username= txt_Username.Text;
            user_password= txt_Password.Text;
            try
            {
                string querry = "SELECT * FROM Login_new WHERE username='"+txt_Username.Text+ "' AND password='"+txt_Password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry , conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_Username.Text;
                    user_password = txt_Password.Text;



                    main dashboard = new main();
                    dashboard.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Username.Clear();
                    txt_Password.Clear();   
                    txt_Username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();
            txt_Username.Focus();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to Exit", "Exit" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();

            }
        }
    }
}
