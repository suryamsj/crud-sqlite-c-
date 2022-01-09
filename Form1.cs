using SQLite.controller;
using SQLite.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite
{
    public partial class Form1 : Form
    {
        //Memanggil class dan objek (Conenction, Mahasiswa dan Mahasiswa_model)
        Connection connection = new Connection();
        Mahasiswa mahasiswa = new Mahasiswa();
        Mahasiswa_model model = new Mahasiswa_model();

        //Deklarasi variabel id
        string id;

        public Form1()
        {
            InitializeComponent();
        }

        //Method untuk menampilkan data Mahasiswa
        private void Datatables()
        {
            //Melakukan query select ke database
            Datatable.DataSource = connection.ShowDataInGridView("SELECT * FROM mahasiswa");

            //Merubah nama kolom yang akan ditampilkan
            Datatable.Columns[0].HeaderText = "#";
            Datatable.Columns[1].HeaderText = "Nama";
            Datatable.Columns[2].HeaderText = "Nim";
            Datatable.Columns[3].HeaderText = "Alamat";
        }

        //Method untuk menghapus / mereset textbox
        private void HapusText()
        {
            Nama.Clear();
            Nim.Clear();
            Alamat.Clear();
        }

        //Ketika form diload untuk pertama kali
        private void Form1_Load(object sender, EventArgs e)
        {
            //Cek apakah file database ada atau tidak
            if (!File.Exists("./mahasiswa.db"))
            {
                //Membuat pesan dialog yes / no
                DialogResult pesan = MessageBox.Show("Database belum ada, apakah anda ingin dibuatkan database nya?", "Informasi  ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                //Jika iya
                if (pesan == DialogResult.Yes)
                {
                    //Membuat file database baru
                    connection.CreateDatabase();

                    //Memanggil method datatables
                    Datatables();
                }

                //Jika tidak
                else
                {
                    //Tampilkan pesan
                    MessageBox.Show("Aplikasi harus ada database untuk berjalan!","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    //Program langsung keluar
                    Application.Exit();
                }
            }

            //Jika file ada
            else
            {
                //Memanggil method datatables
                Datatables();
            }
        }

        //Ketika tombol simpan di klik
        private void Simpan_Click(object sender, EventArgs e)
        {
            //Cek apakah form sudah terisi atau belum
            //Jika belum
            if (Nama.Text == "" || Nim.Text == "" || Alamat.Text == "")
            {
                //Tampilkan pesan
                MessageBox.Show("Form tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Jika sudah
            else
            {
                //Insert data
                model.Nama = Nama.Text;
                model.Nim = Nim.Text;
                model.Alamat = Alamat.Text;

                mahasiswa.Insert(model);

                //Memanggil method hapustext dan datatables
                HapusText();
                Datatables();
            }
        }

        //Ketika tombol ubah di klik
        private void Ubah_Click(object sender, EventArgs e)
        {
            //Cek apakah form sudah terisi atau belum
            //Jika belum
            if (Nama.Text == "" || Nim.Text == "" || Alamat.Text == "")
            {
                //Tampilkan pesan
                MessageBox.Show("Form tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Jika sudah
            else
            {
                //Update data
                model.Nama = Nama.Text;
                model.Nim = Nim.Text;
                model.Alamat = Alamat.Text;

                mahasiswa.Update(model, id);

                //Memanggil method hapustext dan datatables
                HapusText();
                Datatables();
            }
        }

        //Ketika tombol hapus di klik
        private void Hapus_Click(object sender, EventArgs e)
        {
            //Membuat pesan dialog yes / no
            DialogResult pesan = MessageBox.Show("Yakin data mau dihapus?", "Informasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            //Jika iya
            if (pesan == DialogResult.Yes)
            {
                //Hapus data mahasiswa
                mahasiswa.Delete(id);

                //Memanggil method datatables
                Datatables();
            }
        }

        //Ketika cell datatable di klik
        private void Datatable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Datatable.Rows[e.RowIndex].Cells[0].Value.ToString();
            Nama.Text = Datatable.Rows[e.RowIndex].Cells[1].Value.ToString();
            Nim.Text = Datatable.Rows[e.RowIndex].Cells[2].Value.ToString();
            Alamat.Text = Datatable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        //Ketika ada perubahan pada textbox pencarian data mahasiswa
        private void Cari_TextChanged(object sender, EventArgs e)
        {
            string pencarian = Cari.Text;
            try
            {
                Datatable.DataSource = connection.ShowDataInGridView("SELECT * FROM mahasiswa WHERE nama LIKE '%" + pencarian + "%' OR nim LIKE '%" + pencarian + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Tentang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi ini dibuat dengan menggunakan database SQLite dan untuk sebagai bahan belajar CRUD C# DENGAN SQLITE.","Tentang",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Donasi_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah kamu ingin donasi kepada Muhammad Surya?", "Donasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Jika iya
            if (pesan == DialogResult.Yes)
            {
                try
                {
                    Process.Start("https://trakteer.id/suryamsj/tip");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Gagal",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void Github_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://trakteer.id/suryamsj/tip");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kostume_Click(object sender, EventArgs e)
        {
            Costume costume = new Costume();
            costume.Show();
        }
    }
}
