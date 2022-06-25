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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            auth_label.ForeColor = Color.White;
        }

        // Действия с кнопкой "x" (закрытие)
        private void auth_close_Click(object sender, EventArgs e)
        {
            // Выход из приложения
            Application.Exit();
        }

        private void auth_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            auth_close.ForeColor = Color.White;
        }

        private void auth_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            auth_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void auth_label_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            auth_label.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void auth_label_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            auth_label.ForeColor = Color.White;
        }

        // Перемещение формы
        Point lastPoint;

        private void authPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void authPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Нажатия кнопки "войти". Авторизация пользователя
        private void signInButton_Click(object sender, EventArgs e)
        {
            if (userField.Text == "логин" || passField.Text == "пароль")
                MessageBox.Show("Введены не все поля");
            else
            {
                DataBase db = new DataBase();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                // Выполнение команды SQL по поиску пользователя
                MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL", db.getConnection());

                // Установка "заглушек" для вводимых полей
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userField.Text;

                DataTable table = Program.FuncFilling(command);

                if (table.Rows.Count > 0)
                {
                    if (passField.Text == table.Rows[0][1].ToString())
                    {
                        Program.UserLogin.Value = userField.Text;
                        Hide();
                        MainForm MainForm = new MainForm();
                        MainForm.Show();
                    }
                    else MessageBox.Show("Неверно введен пароль.");
                }

                else
                    MessageBox.Show("Такого пользователя нет.");
            }
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

        // Переход на окно регистрации
        private void auth_label_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }
    }
}
