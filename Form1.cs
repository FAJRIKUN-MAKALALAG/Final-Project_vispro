using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_vispro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2_LoginKaryawan form2_LoginKaryawan = new Form2_LoginKaryawan();
            form2_LoginKaryawan.Show();
            this.Hide();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            Form3_LoginAdmin form3_LoginAdmin = new Form3_LoginAdmin();
            form3_LoginAdmin.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
