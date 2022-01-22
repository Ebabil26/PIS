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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `zapros_postav` (`Nazvanie`, `Artikul`, `Kolichestvo`, `Status_oplati`, `Status_otpravki`) VALUES (@Nazvanie, @Artikul, @Kolichestvo, @Status_oplati, @Status_otpravki)", db.getConnection());

            command.Parameters.Add("@Nazvanie", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@Artikul", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@Kolichestvo", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@Status_oplati", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@Status_otpravki", MySqlDbType.VarChar).Value = textBox5.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Успешно");
            else
                MessageBox.Show("Неуспешно");


            db.closeConnection();
        }
    }
}
