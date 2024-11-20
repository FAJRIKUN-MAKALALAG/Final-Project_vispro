using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_vispro
{
    public partial class Form7_MainAdmin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form7_MainAdmin()
        {
            alamat = "server=localhost; database=project_vispro; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCRKaryawan formCRKaryawan = new FormCRKaryawan();
            formCRKaryawan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
{
                // Pastikan semua field penting terisi
                if (!string.IsNullOrWhiteSpace(txtPassword.Text) &&
                    !string.IsNullOrWhiteSpace(txtNama.Text) &&
                    !string.IsNullOrWhiteSpace(txtGaji.Text) &&
                    !string.IsNullOrWhiteSpace(txtAlamat.Text))
                {
                    // Buat query update yang benar
                    query = string.Format("UPDATE tbl_karyawan " +
                                          "SET password = '{0}', nama_user = '{1}', alamat = '{2}', gaji = '{3}', umur = '{4}', " +
                                          "nomor_tlpn = '{5}', gender = '{6}', sebagai = '{7}', bagian = '{8}' " +
                                          "WHERE id_karyawan = '{9}'",
                                          txtPassword.Text,
                                          txtNama.Text,
                                          txtAlamat.Text,
                                          txtGaji.Text,
                                          txtUmur.Text,
                                          txtNoTlpn.Text,
                                          cbGender.Text,
                                          cbSebagai.Text,
                                          cbBagian.Text,
                                          txtID.Text); // Pastikan ID karyawan diisi

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Berhasil!");
                        Form7_MainAdmin_Load(null, null); // Reload data
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data.");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak Lengkap!");
                }
            }
catch (Exception ex)
{
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3_LoginAdmin form3_LoginAdmin = new Form3_LoginAdmin();
            form3_LoginAdmin.Show();
            this.Hide();
        }

        private void cbBagian_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "")
                {
                    query = string.Format("select * from tbl_karyawan where nama_lengkap = '{0}'", txtNama.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtID.Text = kolom["id_karyawan"].ToString();
                            txtNama.Text = kolom["nama_lengkap"].ToString();
                            txtPassword.Text = kolom["password"].ToString();
                            txtNoTlpn.Text = kolom["nomor_tlpn"].ToString();
                            txtAlamat.Text = kolom["alamat"].ToString();
                            txtUmur.Text = kolom["umur"].ToString();
                            cbGender.Text = kolom["gender"].ToString();
                            cbSebagai.Text = kolom["sebagai"].ToString();
                            cbBagian.Text = kolom["bagian"].ToString();
                            txtGaji.Text = kolom["gaji"].ToString();

                        }
                        txtID.Enabled = false;
                        txtNama.Enabled = true;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSearch.Enabled = false;
                        btnClear.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        Form7_MainAdmin_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    // Query untuk menghapus data
                    query = string.Format("DELETE FROM tbl_karyawan WHERE id_karyawan = '{0}'", txtID.Text);

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                    if (res == 1)
                    {
                        MessageBox.Show("Data Berhasil Dihapus!");
                        Form7_MainAdmin_Load(null, null); // Reload data
                    }
                    else
                    {
                        MessageBox.Show("Gagal Menghapus Data.");
                    }
                }
                else
                {
                    MessageBox.Show("ID Karyawan Tidak Boleh Kosong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message);
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_karyawan");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Setting DataGridView DataSource
                dataGridView1.DataSource = ds.Tables[0];

                // Adjusting column widths and headers
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Passsword";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Alamat";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Umur";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Gender";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[8].HeaderText = "Sebagai";
                dataGridView1.Columns[9].Width = 120;
                dataGridView1.Columns[9].HeaderText = "Bagian";
                dataGridView1.Columns[11].Width = 120;
                dataGridView1.Columns[11].HeaderText = "Gaji";


                // Clearing and setting default states for inputs and buttons
                txtNoTlpn.Clear();
                txtNama.Clear();
                txtPassword.Clear();
                txtAlamat.Clear();
                txtUmur.Clear();
                cbGender.Text = string.Empty; // Use Text property for ComboBox
                cbSebagai.Text = string.Empty;
                cbBagian.Text = string.Empty;
                txtGaji.Clear();
                txtNama.Focus();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                
                btnSearch.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form7_MainAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT * FROM tbl_karyawan";
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Setting DataGridView DataSource
                dataGridView1.DataSource = ds.Tables[0];

                // Adjusting column widths and headers
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Passsword";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Nomor Telepon";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Alamat";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Umur";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Gender";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[8].HeaderText = "Sebagai";
                dataGridView1.Columns[9].Width = 120;
                dataGridView1.Columns[9].HeaderText = "Bagian";
                dataGridView1.Columns[11].Width = 120;
                dataGridView1.Columns[11].HeaderText = "Gaji";


                // Clearing and setting default states for inputs and buttons
                txtNoTlpn.Clear();
                txtNama.Clear();
                txtPassword.Clear();
                txtAlamat.Clear();
                txtUmur.Clear();
                cbGender.Text = string.Empty; // Use Text property for ComboBox
                cbSebagai.Text = string.Empty;
                cbBagian.Text = string.Empty;
                txtGaji.Clear();
                txtNama.Focus();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnSearch.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
