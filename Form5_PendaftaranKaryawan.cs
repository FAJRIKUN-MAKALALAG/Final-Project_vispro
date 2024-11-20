using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_vispro
{
    public partial class Form5_PendaftaranKaryawan : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public Form5_PendaftaranKaryawan()
        {
            alamat = "server=localhost; database=project_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_LoginKaryawan form2_LoginKaryawan = new Form2_LoginKaryawan();
            form2_LoginKaryawan.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_PendaftaranKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Ubah string koneksi sesuai dengan pengaturan database Anda
            string connectionString = "server=localhost;user id=root;password=;database=project_vispro";

            // Ambil nilai dari masing-masing input
            string name = txtNama.Text;
            string namaUser = txtUser.Text;
            string password = txtPassword.Text;
            string nomorTelp = txtNoTlpn.Text;
            string alamat = txtAlamat.Text;
            string umur = txtUmur.Text;
            string gender = cbGender.SelectedItem.ToString();
            string sebagai = cbSebagai.SelectedItem.ToString();
            string bagian = cbBagian.SelectedItem.ToString();
            string tglDaftar = dtpTglMasuk.Value.ToString("yyyy-MM-dd");


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query untuk memasukkan data ke tabel tbl_karyawan
                    string query = "INSERT INTO tbl_karyawan (nama_lengkap, nama_user, password, nomor_tlpn, alamat, umur, gender, sebagai, bagian, tgl_daftar) " +
                                   "VALUES (@name, @namaUser, @password, @nomorTelp, @alamat, @umur, @gender, @sebagai, @bagian, @tglDaftar)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@namaUser", namaUser);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@nomorTelp", nomorTelp);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@sebagai", sebagai);
                    cmd.Parameters.AddWithValue("@bagian", bagian);
                    cmd.Parameters.AddWithValue("@tglDaftar", tglDaftar);


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data karyawan berhasil disimpan.");

                    Form2_LoginKaryawan form2_LoginKaryawan = new Form2_LoginKaryawan();
                    form2_LoginKaryawan.Show();
                    this.Hide();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message);
            }

        }

        private void cbBagian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
