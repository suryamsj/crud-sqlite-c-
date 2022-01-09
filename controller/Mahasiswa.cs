using SQLite.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite.controller
{
    class Mahasiswa
    {
        Connection connection = new Connection();

        public bool Insert(Mahasiswa_model model)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("INSERT INTO mahasiswa (nama, nim, alamat) VALUES ('" + model.Nama + "', '" + model.Nim + "','" + model.Alamat + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.CloseConection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(Mahasiswa_model model, string id)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("UPDATE mahasiswa SET nama='" + model.Nama + "'," + "nim='" + model.Nim + "'," +
                        "alamat='" + model.Alamat + "' WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.CloseConection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id)
        {
            Boolean status = false;
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery("DELETE FROM mahasiswa WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.CloseConection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
