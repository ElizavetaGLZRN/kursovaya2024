using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсовая
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Авторизация());
        }
    }

}

namespace База_данных
{
    class База_данных
    {
        // Метод для регистрации нового пользователя
        public void RegisterUser(string login, string password, string name)
        {
            string connectionString = "Data Source=имя_сервера;Initial Catalog=имя_базы_данных;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Создание SQL команды для добавления записи в таблицу пользователей
                    string query = "INSERT INTO Users (Login, Password, Name) VALUES (@Login, @Password, @Name)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавление параметров в SQL команду
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Name", name);

                        // Выполнение SQL команды
                        command.ExecuteNonQuery();

                        Console.WriteLine("Пользователь успешно зарегистрирован.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при регистрации пользователя: " + ex.Message);
                }
            }
        }
    }

}
