using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсовая
{
    public partial class Авторизация : Form
    {
        Database database = new Database();
        public Авторизация()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            if (string.IsNullOrEmpty(loginUser) || string.IsNullOrEmpty(passUser))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID, Login, Password from Пользователи where Login = '{loginUser}' " +
                $"and Password = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                
                form2.ShowDialog();
                this.Show();this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        
        private void Авторизация_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
