namespace Project_vispro
{
    partial class Form5_PendaftaranKaryawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_PendaftaranKaryawan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNoTlpn = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBagian = new System.Windows.Forms.ComboBox();
            this.cbSebagai = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.dtpTglMasuk = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 849);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.Beige;
            this.txtNama.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNama.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNama.Location = new System.Drawing.Point(203, 105);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(239, 36);
            this.txtNama.TabIndex = 200;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Beige;
            this.txtPassword.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(203, 247);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 36);
            this.txtPassword.TabIndex = 201;
            // 
            // txtNoTlpn
            // 
            this.txtNoTlpn.BackColor = System.Drawing.Color.Beige;
            this.txtNoTlpn.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNoTlpn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoTlpn.Location = new System.Drawing.Point(203, 333);
            this.txtNoTlpn.Name = "txtNoTlpn";
            this.txtNoTlpn.Size = new System.Drawing.Size(239, 36);
            this.txtNoTlpn.TabIndex = 202;
            this.txtNoTlpn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.Color.Beige;
            this.txtAlamat.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtAlamat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAlamat.Location = new System.Drawing.Point(203, 421);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(239, 36);
            this.txtAlamat.TabIndex = 203;
            // 
            // txtUmur
            // 
            this.txtUmur.BackColor = System.Drawing.Color.Beige;
            this.txtUmur.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUmur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUmur.Location = new System.Drawing.Point(203, 501);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(67, 36);
            this.txtUmur.TabIndex = 204;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Coral;
            this.btnLogin.BackgroundImage = global::Project_vispro.Properties.Resources.________;
            this.btnLogin.Font = new System.Drawing.Font("Niagara Solid", 31.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(976, 501);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 55);
            this.btnLogin.TabIndex = 206;
            this.btnLogin.Text = "daftarkan";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.BackgroundImage = global::Project_vispro.Properties.Resources.________;
            this.button1.Font = new System.Drawing.Font("Niagara Solid", 31.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(976, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 55);
            this.button1.TabIndex = 208;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBagian
            // 
            this.cbBagian.BackColor = System.Drawing.Color.Beige;
            this.cbBagian.Font = new System.Drawing.Font("Niagara Solid", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbBagian.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbBagian.FormattingEnabled = true;
            this.cbBagian.Items.AddRange(new object[] {
            "Kepala [ Operator ]",
            "Operator [ Kora-Kora ]",
            "Operator [ Kincir ]",
            "Operator [ Piring Terbang ]",
            "Operator [ Rumah Hantu ]",
            "Operator [ Tong Setan ]",
            "Operator [ Istana Balon ]",
            "Operator [ Trampolin ]",
            "Kepala [ Keuangan Perusahaan ]",
            "Kepala [ keamanan ]",
            "Keamanan [ Desa ]",
            "Keamanan [ Karyawan ]",
            "Keamanan [ Lapangan ]",
            "Juru Masak [ Perusaaan ]"});
            this.cbBagian.Location = new System.Drawing.Point(203, 748);
            this.cbBagian.Name = "cbBagian";
            this.cbBagian.Size = new System.Drawing.Size(228, 42);
            this.cbBagian.TabIndex = 226;
            this.cbBagian.SelectedIndexChanged += new System.EventHandler(this.cbBagian_SelectedIndexChanged);
            // 
            // cbSebagai
            // 
            this.cbSebagai.BackColor = System.Drawing.Color.Beige;
            this.cbSebagai.Font = new System.Drawing.Font("Niagara Solid", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbSebagai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbSebagai.FormattingEnabled = true;
            this.cbSebagai.Items.AddRange(new object[] {
            "Operator Wahana",
            "Kepala Divisi",
            "Keamanan",
            "Juru Masak"});
            this.cbSebagai.Location = new System.Drawing.Point(203, 669);
            this.cbSebagai.Name = "cbSebagai";
            this.cbSebagai.Size = new System.Drawing.Size(228, 42);
            this.cbSebagai.TabIndex = 225;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Beige;
            this.cbGender.Font = new System.Drawing.Font("Niagara Solid", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbGender.Location = new System.Drawing.Point(203, 579);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(116, 42);
            this.cbGender.TabIndex = 224;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Beige;
            this.txtUser.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Location = new System.Drawing.Point(203, 175);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(239, 36);
            this.txtUser.TabIndex = 227;
            // 
            // dtpTglMasuk
            // 
            this.dtpTglMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpTglMasuk.Location = new System.Drawing.Point(620, 113);
            this.dtpTglMasuk.Name = "dtpTglMasuk";
            this.dtpTglMasuk.Size = new System.Drawing.Size(235, 23);
            this.dtpTglMasuk.TabIndex = 228;
            // 
            // Form5_PendaftaranKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 840);
            this.Controls.Add(this.dtpTglMasuk);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cbBagian);
            this.Controls.Add(this.cbSebagai);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNoTlpn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5_PendaftaranKaryawan";
            this.Text = "Form5_PendaftaranKaryawan";
            this.Load += new System.EventHandler(this.Form5_PendaftaranKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNoTlpn;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbBagian;
        private System.Windows.Forms.ComboBox cbSebagai;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DateTimePicker dtpTglMasuk;
    }
}