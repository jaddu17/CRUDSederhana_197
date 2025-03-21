namespace CRUDSederhana
{
    partial class Form1
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
            this.NIM = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(142, 68);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(50, 25);
            this.NIM.TabIndex = 0;
            this.NIM.Text = "NIM";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(142, 131);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(68, 25);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(357, 62);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(100, 31);
            this.txtNIM.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(357, 125);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 31);
            this.txtNama.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(357, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 31);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(357, 271);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(100, 31);
            this.txtTelepon.TabIndex = 8;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(357, 340);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 31);
            this.txtAlamat.TabIndex = 9;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(643, 88);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(130, 45);
            this.Tambah.TabIndex = 10;
            this.Tambah.Text = "Tambah\r\n";
            this.Tambah.UseVisualStyleBackColor = true;
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(643, 171);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(130, 45);
            this.Hapus.TabIndex = 11;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(643, 257);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(130, 45);
            this.Ubah.TabIndex = 12;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.button2_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(643, 333);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(130, 45);
            this.Refresh.TabIndex = 13;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(60, 400);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.RowHeadersWidth = 82;
            this.dgvMahasiswa.RowTemplate.Height = 33;
            this.dgvMahasiswa.Size = new System.Drawing.Size(913, 281);
            this.dgvMahasiswa.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 705);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Ubah);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.NIM);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

