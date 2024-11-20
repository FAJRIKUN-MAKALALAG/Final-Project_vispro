namespace Project_vispro
{
    partial class Form2_LoginKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_LoginKaryawan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPendaftaran = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 849);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Beige;
            this.txtUser.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Location = new System.Drawing.Point(546, 249);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(239, 36);
            this.txtUser.TabIndex = 195;
            this.txtUser.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Beige;
            this.txtPassword.Font = new System.Drawing.Font("Niagara Solid", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(546, 371);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 36);
            this.txtPassword.TabIndex = 196;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Coral;
            this.btnLogin.BackgroundImage = global::Project_vispro.Properties.Resources.________;
            this.btnLogin.Font = new System.Drawing.Font("Niagara Solid", 31.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(741, 497);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 55);
            this.btnLogin.TabIndex = 197;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Coral;
            this.btnBack.BackgroundImage = global::Project_vispro.Properties.Resources.________;
            this.btnBack.Font = new System.Drawing.Font("Niagara Solid", 31.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(342, 497);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 55);
            this.btnBack.TabIndex = 198;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPendaftaran
            // 
            this.btnPendaftaran.BackColor = System.Drawing.Color.Coral;
            this.btnPendaftaran.BackgroundImage = global::Project_vispro.Properties.Resources.________;
            this.btnPendaftaran.Font = new System.Drawing.Font("Niagara Solid", 31.25F, System.Drawing.FontStyle.Bold);
            this.btnPendaftaran.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPendaftaran.Location = new System.Drawing.Point(629, 609);
            this.btnPendaftaran.Name = "btnPendaftaran";
            this.btnPendaftaran.Size = new System.Drawing.Size(260, 55);
            this.btnPendaftaran.TabIndex = 199;
            this.btnPendaftaran.Text = "Daftarkan diri anda";
            this.btnPendaftaran.UseVisualStyleBackColor = false;
            this.btnPendaftaran.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2_LoginKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 861);
            this.Controls.Add(this.btnPendaftaran);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2_LoginKaryawan";
            this.Text = "Form2_LoginKaryawan";
            this.Load += new System.EventHandler(this.Form2_LoginKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPendaftaran;
    }
}