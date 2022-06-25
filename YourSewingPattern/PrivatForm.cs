using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace YourSewingPattern
{
    public partial class PrivatForm : Form
    {
        public PrivatForm()
        {
            InitializeComponent();
            Program.SetRoundedShape(privat_header, 30);
            FillingPrivateForm();
        }

        public void FillingPrivateForm()
        {
            string login = Program.UserLogin.Value;
            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL", db.getConnection());

            // Установка "заглушки"
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            DataTable table = Program.FuncFilling(command);

            string str = table.Rows[0][1].ToString();
            for (int i = 0; i < str.Length; i++) str = str.Replace(str[i], '*');

            login_privat.Text = table.Rows[0][0].ToString();
            password_privat.Text = str;
            personal_parameters_privat.Text = table.Rows[0][2].ToString();
        }

       // Перемещение формы
       Point lastPoint;

        private void privatPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void privatPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void privat_close_Click(object sender, EventArgs e)
        {
            // Выход из приложения
            Application.Exit();
        }

        private void privat_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            privat_close.ForeColor = Color.White;
        }

        private void privat_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            privat_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void back_privat_MouseEnter(object sender, EventArgs e)
        {
            back_privat.Image = Properties.Resources.back_arrow_white;
        }

        private void back_privat_MouseLeave(object sender, EventArgs e)
        {
            back_privat.Image = Properties.Resources.back_arrow;
        }

        private void back_privat_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            DataChangeForm DataChangeForm = new DataChangeForm();
            DataChangeForm.Show();
        }

        private void edit_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            edit.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            edit.ForeColor = Color.White;
        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            FavoritesListForm FavoritesListForm = new FavoritesListForm();
            FavoritesListForm.Show();
        }

        private void PrivatForm_Activated(object sender, EventArgs e)
        {
            FillingPrivateForm();
        }

        private void deleteAkk_button_Click(object sender, EventArgs e)
        {
            string login = Program.UserLogin.Value;
            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("DELETE FROM `пользователи` WHERE `пользователи`.`Логин` = @uL", db.getConnection());

            // Установка "заглушки"
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт удален.");

            db.closeConnection();

            Application.Exit();
        }
    }
}
