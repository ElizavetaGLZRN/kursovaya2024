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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая
{
    public partial class Form3 : Form
    {
        Database database = new Database();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                return;
            }

            if (checkUser())
            {
                return;
            }

            string login = textBox1.Text;
            string password = textBox2.Text;

            string queryString = $"INSERT INTO пользователи(login, password) VALUES('{login}', '{password}')";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан! Спасибо за регистрацию!", "Успех!");
                Авторизация form1 = new Авторизация();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            database.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT id, login, password FROM пользователи WHERE login = '{loginUser}' AND password = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
