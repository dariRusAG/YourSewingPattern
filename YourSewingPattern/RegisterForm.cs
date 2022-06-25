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

namespace YourSewingPattern
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            register_label.ForeColor = Color.White;
            TotalLoading();
        }

        public void TotalLoading()
        {
            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT count(*) AS Пользователи, (SELECT count(*) FROM `выкройки`) AS Выкройки FROM `пользователи`", db.getConnection());

            DataTable table = Program.FuncFilling(command);

            label_res.Text = "В НАШЕЙ СИСТЕМЕ УЖЕ " + table.Rows[0][0].ToString() + " ЗАРЕГИСТРИРОВАННЫХ ПОЛЬЗОВАТЕЛЕЙ И " + table.Rows[0][1].ToString() + " ВЫКРОЕК В КАТАЛОГЕ!";
        }

        // Действия с кнопкой "x" (закрытие)
        private void register_close_Click(object sender, EventArgs e)
        {
            // Выход из приложения
            Application.Exit();
        }

        private void register_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            register_close.ForeColor = Color.White;
        }

        private void register_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            register_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void register_label_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            register_label.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void register_label_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            register_label.ForeColor = Color.White;
        }

        // Перемещение формы
        Point lastPoint;

        private void registerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void registerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Нажатия кнопки "зарегистрироваться". Регистрация пользователя
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (userField.Text == "логин" || passField.Text == "пароль")
                MessageBox.Show("Введены не все поля");
            else
            {
                DataBase db = new DataBase();
                if (Chek_userField() == true) return;

                // Выполнение команды SQL по поиску пользователя
                MySqlCommand command = new MySqlCommand("INSERT INTO `пользователи` values(@uL, @uP, NULL)", db.getConnection());

                // Установка "заглушек" для вводимых полей
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userField.Text;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан.");
                    Hide();
                    LoginForm LoginForm = new LoginForm();
                    LoginForm.Show();
                }

                db.closeConnection();
            }
        }

        // Проверка вводимых значений
        public Boolean Chek_userField()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL", db.getConnection());

            // Установка "заглушек" для вводимых полей
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userField.Text;
            adapter.SelectCommand = command;

            // Передача полученных данных в рабочую переменную
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть.");
                return true;
            }

            else 
                return false;
        }

        private void userField_Enter(object sender, EventArgs e)
        {
            if (userField.Text == "логин")
            {
                userField.Text = "";
                userField.ForeColor = Color.Black;
            }
        }

        private void userField_Leave(object sender, EventArgs e)
        {
            if (userField.Text == "")
            {
                userField.ForeColor = Color.FromArgb(246, 239, 243);
                userField.Text = "логин";
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Multiline = true;
                passField.AutoSize = true;

                passField.ForeColor = Color.FromArgb(246, 239, 243);
                passField.Text = "пароль";
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "пароль")
                passField.Text = "";

            passField.Multiline = false;
            passField.AutoSize = false;
            passField.Size = new Size(passField.Size.Width, userField.Size.Height);
            passField.UseSystemPasswordChar = true;

            passField.ForeColor = Color.Black;
        }

        // Открытие формы авторизации при нажатии
        private void register_label_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }
    }
}
