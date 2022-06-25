using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace YourSewingPattern
{
    public partial class FavoritesListForm : Form
    {
        public FavoritesListForm()
        {
            InitializeComponent();
            Program.SetRoundedShape(favorites_header, 30);
            FillingFavoritesForm();
        }

        public void FillingFavoritesForm()
        {
            string login = Program.UserLogin.Value;
            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT v.`Номер выкройки`, v.`Название`, v.`Основные мерки`, v.`Дополнительные мерки`, izb.`Заметки` FROM `избранное пользователей` izb, `выкройки` v WHERE izb.`Пользователи_Логин` = @uL AND izb.`Выкройки_Номер выкройки` = v.`Номер выкройки`", db.getConnection());

            // Установка "заглушки"
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            DataTable table = Program.FuncFilling(command);

            // заполняем таблицу данными из базы данных
            dataGridView1.DataSource = table.DefaultView;
        }

        // Действия с кнопкой "x" (закрытие)
        private void favorites_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_favorites_Click(object sender, EventArgs e)
        {
            Hide();
            CategoryForm CategoryForm = new CategoryForm();
            CategoryForm.Show();
        }

        private void back_favorites_MouseEnter(object sender, EventArgs e)
        {
            back_favorites.Image = Properties.Resources.back_arrow_white;
        }

        private void back_favorites_MouseLeave(object sender, EventArgs e)
        {
            back_favorites.Image = Properties.Resources.back_arrow;
        }

        private void favorites_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            favorites_close.ForeColor = Color.White;
        }

        private void favorites_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            favorites_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        // Перемещение формы
        Point lastPoint;

        private void favoritesPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void favoritesPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string login = Program.UserLogin.Value;
            int numberRow = dataGridView1.CurrentCell.RowIndex;

            DataBase db = new DataBase();

            // Выполнение команды SQL по удалению выкройки из списка избранного
            MySqlCommand command = new MySqlCommand("DELETE FROM `избранное пользователей` WHERE `избранное пользователей`.`Пользователи_Логин` = @uL AND `избранное пользователей`.`Выкройки_Номер выкройки` = @vN", db.getConnection());

            //Установка "заглушек" для вводимых полей
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@vN", MySqlDbType.VarChar).Value = dataGridView1[0, numberRow].Value.ToString();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Выкройка удалена из избранного.");

            db.closeConnection();

            FillingFavoritesForm();
        }

        private void favorites_main_Click(object sender, EventArgs e)
        {
            Hide();
            PrivatForm PrivatForm = new PrivatForm();
            PrivatForm.Hide();

            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void favorites_main_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            favorites_main.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void favorites_main_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            favorites_main.ForeColor = Color.White;
        }

        private void update_notes_Click(object sender, EventArgs e)
        {
            string login = Program.UserLogin.Value;
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            string notes = Interaction.InputBox("Изменить заметку:");

            DataBase db = new DataBase();

            // Выполнение команды SQL по удалению выкройки из списка избранного
            MySqlCommand command = new MySqlCommand("UPDATE `избранное пользователей` SET `Заметки` = @nts WHERE `избранное пользователей`.`Пользователи_Логин` = @uL AND `избранное пользователей`.`Выкройки_Номер выкройки` = @vN", db.getConnection());

            //Установка "заглушек" для вводимых полей
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@vN", MySqlDbType.VarChar).Value = dataGridView1[0, numberRow].Value.ToString();
            command.Parameters.Add("@nts", MySqlDbType.VarChar).Value = notes;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Заметка изменена.");

            db.closeConnection();

            FillingFavoritesForm();
        }
    }
}
