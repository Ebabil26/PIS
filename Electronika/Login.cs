using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronika
{
    public partial class Login : Form
    {
        private MySqlConnection mycon;
        private string connect;

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;
            Kabinet kab = new Kabinet();


            DB db = new DB();
            db.openConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                kab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regestration regestration = new Regestration();
            regestration.Show();
        }

   
    }
}
