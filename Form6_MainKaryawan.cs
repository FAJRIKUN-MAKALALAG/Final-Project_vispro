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
    public partial class Form6_MainKaryawan : Form
    {
        public Form6_MainKaryawan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form6_MainKaryawan_Load(object sender, EventArgs e)
        {

        }

    }
    
    
}
