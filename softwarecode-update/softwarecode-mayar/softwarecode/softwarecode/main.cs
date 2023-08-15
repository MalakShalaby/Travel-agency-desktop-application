using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwarecode
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Package P = new Package();
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hotels h = new Hotels();
            h.Show();
        }
    }
}
