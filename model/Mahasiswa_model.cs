using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite.model
{
    class Mahasiswa_model
    {
        string nama, nim, alamat;

        public Mahasiswa_model() { }

        public Mahasiswa_model(string nama, string nim, string alamat)
        {
            this.Nama = nama;
            this.Nim = nim;
            this.Alamat = alamat;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Nim { get => nim; set => nim = value; }
        public string Alamat { get => alamat; set => alamat = value; }
    }
}
