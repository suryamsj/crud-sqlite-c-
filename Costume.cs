using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite
{
    public partial class Costume : Form
    {
        public Costume()
        {
            InitializeComponent();
        }

        private void Whatsapp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://wa.link/qm9pqf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Facebook_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.facebook.com/msuryamsj/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Instagram_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.instagram.com/ciiciocii/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {
            MessageBox.Show("msurya672@gmail.com","Email",MessageBoxButtons.OK);
        }
    }
}
