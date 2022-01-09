
namespace SQLite
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Nim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Simpan = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Datatable = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Tentang = new System.Windows.Forms.Button();
            this.Donasi = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            this.Kostume = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datatable)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Datatable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Hapus);
            this.groupBox2.Controls.Add(this.Ubah);
            this.groupBox2.Controls.Add(this.Simpan);
            this.groupBox2.Controls.Add(this.Alamat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Nim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Nama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama :";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(9, 53);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(441, 22);
            this.Nama.TabIndex = 3;
            // 
            // Nim
            // 
            this.Nim.Location = new System.Drawing.Point(9, 114);
            this.Nim.Name = "Nim";
            this.Nim.Size = new System.Drawing.Size(441, 22);
            this.Nim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIM :";
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(9, 182);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(441, 22);
            this.Alamat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alamat :";
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(9, 210);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(143, 40);
            this.Simpan.TabIndex = 2;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(158, 210);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(143, 40);
            this.Ubah.TabIndex = 8;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(307, 210);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(143, 40);
            this.Hapus.TabIndex = 9;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cari);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(483, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(9, 53);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(644, 22);
            this.Cari.TabIndex = 11;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cari Data :";
            // 
            // Datatable
            // 
            this.Datatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datatable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Datatable.Location = new System.Drawing.Point(3, 18);
            this.Datatable.Name = "Datatable";
            this.Datatable.RowHeadersWidth = 51;
            this.Datatable.RowTemplate.Height = 24;
            this.Datatable.Size = new System.Drawing.Size(1124, 270);
            this.Datatable.TabIndex = 0;
            this.Datatable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datatable_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Kostume);
            this.groupBox4.Controls.Add(this.Github);
            this.groupBox4.Controls.Add(this.Donasi);
            this.groupBox4.Controls.Add(this.Tentang);
            this.groupBox4.Location = new System.Drawing.Point(483, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(659, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informasi";
            // 
            // Tentang
            // 
            this.Tentang.Location = new System.Drawing.Point(9, 35);
            this.Tentang.Name = "Tentang";
            this.Tentang.Size = new System.Drawing.Size(206, 60);
            this.Tentang.TabIndex = 0;
            this.Tentang.Text = "Tentang";
            this.Tentang.UseVisualStyleBackColor = true;
            this.Tentang.Click += new System.EventHandler(this.Tentang_Click);
            // 
            // Donasi
            // 
            this.Donasi.Location = new System.Drawing.Point(228, 35);
            this.Donasi.Name = "Donasi";
            this.Donasi.Size = new System.Drawing.Size(206, 60);
            this.Donasi.TabIndex = 1;
            this.Donasi.Text = "Donasi";
            this.Donasi.UseVisualStyleBackColor = true;
            this.Donasi.Click += new System.EventHandler(this.Donasi_Click);
            // 
            // Github
            // 
            this.Github.Location = new System.Drawing.Point(447, 35);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(206, 60);
            this.Github.TabIndex = 2;
            this.Github.Text = "Github";
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // Kostume
            // 
            this.Kostume.Location = new System.Drawing.Point(9, 101);
            this.Kostume.Name = "Kostume";
            this.Kostume.Size = new System.Drawing.Size(644, 60);
            this.Kostume.TabIndex = 3;
            this.Kostume.Text = "Kostume Aplikasi C# Desktop";
            this.Kostume.UseVisualStyleBackColor = true;
            this.Kostume.Click += new System.EventHandler(this.Kostume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 583);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CRUD Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datatable)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Cari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Datatable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Tentang;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Button Donasi;
        private System.Windows.Forms.Button Kostume;
    }
}

