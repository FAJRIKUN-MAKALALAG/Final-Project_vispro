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
    public partial class Form2_LoginKaryawan : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form2_LoginKaryawan()

        {
            alamat = "server=localhost; database=db_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // String koneksi ke database, sesuaikan dengan pengaturan database Anda
            string connectionString = "server=localhost;user id=root;password=;database=project_vispro";

            // Ambil data dari input form
            string namaUser = txtUser.Text;
            string password = txtPassword.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk memeriksa apakah user dan password cocok
                    string query = "SELECT COUNT(*) FROM tbl_karyawan WHERE nama_user = @namaUser AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@namaUser", namaUser);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        // Jika user ditemukan, buka form tujuan
                        MessageBox.Show("Login berhasil!");
                        Form6_MainKaryawan form6_MainKaryawan = new Form6_MainKaryawan();
                        form6_MainKaryawan.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nama pengguna atau password salah.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat login: " + ex.Message);
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5_PendaftaranKaryawan form5_PendaftaranKaryawan = new Form5_PendaftaranKaryawan();
            form5_PendaftaranKaryawan.Show();
            this.Hide();

        }

        private void Form2_LoginKaryawan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
