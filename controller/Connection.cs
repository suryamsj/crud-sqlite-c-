using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite.controller
{
    class Connection
    {
        string ConnectionString = @"Data Source=|DataDirectory|\mahasiswa.db;Version=3;";
        SQLiteConnection con;

        public void OpenConnection()
        {
            con = new SQLiteConnection(ConnectionString);
            con.Open();
        }

        public void CloseConection()
        {
            con.Close();
        }

        public void ExecuteQuery(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader reader(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string query)
        {
            SQLiteDataAdapter dr = new SQLiteDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile("mahasiswa.db");
                OpenConnection();
                string table = "CREATE TABLE mahasiswa (id INTEGER PRIMARY KEY AUTOINCREMENT, nama TEXT, nim TEXT, alamat TEXT)";
                ExecuteQuery(table);
                CloseConection();
                MessageBox.Show("Database berhasil dibuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
