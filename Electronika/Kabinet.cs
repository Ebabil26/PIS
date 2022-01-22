using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using SD = System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronika
{
    public partial class Kabinet : Form
    {
        public Kabinet(string querry = "")
        {
            InitializeComponent();
            if (querry != "")
                PrintTable(querry);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sklad skl = new Sklad();
            skl.Show();
            PrintTable("SELECT * FROM `sklad`");
        }

        private void PrintTable(string querry)
        {
            try
            {
                string script = querry;

                SD.DataTable table = new SD.DataTable();

            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zapros_postavshik post = new Zapros_postavshik();
            post.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vnutrenie_zaprosi vnzap = new Vnutrenie_zaprosi();
            vnzap.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
