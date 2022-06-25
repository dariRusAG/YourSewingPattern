using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace YourSewingPattern
{
    public partial class PatternListForm : Form
    {
        public PatternListForm()
        {
            InitializeComponent();
            Program.SetRoundedShape(pattern_header, 30);
            FillingPatternForm();
        }

        public void FillingPatternForm()
        {
            int numberCategory = Program.NumberCategory();

            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT `Номер выкройки`,`Название`,`Основные мерки`,`Дополнительные мерки` FROM `выкройки` e WHERE e.`Категории_Номер категории` = @nC", db.getConnection());
            // Установка "заглушки"
            command.Parameters.Add("@nC", MySqlDbType.VarChar).Value = numberCategory;

            DataTable table = Program.FuncFilling(command);

            // заполняем таблицу данными из базы данных
            dataGridView1.DataSource = table.DefaultView;
        }

        // Перемещение формы
        Point lastPoint;

        private void patternPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void patternPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void back_patterns_Click(object sender, EventArgs e)
        {
            Hide();
            CategoryForm CategoryForm = new CategoryForm();
            CategoryForm.Show();
        }

        private void back_patterns_MouseEnter(object sender, EventArgs e)
        {
            back_patterns.Image = Properties.Resources.back_arrow_white;
        }

        private void back_patterns_MouseLeave(object sender, EventArgs e)
        {
            back_patterns.Image = Properties.Resources.back_arrow;
        }

        private void patterns_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patterns_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            patterns_close.ForeColor = Color.White;
        }

        private void patterns_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            patterns_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void patterns_LK_Click(object sender, EventArgs e)
        {
            PrivatForm PrivatForm = new PrivatForm();
            PrivatForm.Show();
        }

        private void patterns_LK_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            patterns_LK.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void patterns_LK_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            patterns_LK.ForeColor = Color.White;
        }

        private void PatternButton_Click(object sender, EventArgs e)
        {
            string login = Program.UserLogin.Value;
            int numberRow = dataGridView1.CurrentCell.RowIndex;
            string notes = Interaction.InputBox("Добавить заметку:");

            DataBase db = new DataBase();

            //Выполнение команды SQL по добавлению выкройки в список избранного
            MySqlCommand command = new MySqlCommand("INSERT INTO `избранное пользователей` values(@uL, @vN, @nts)", db.getConnection());

            //Установка "заглушек" для вводимых полей
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@vN", MySqlDbType.VarChar).Value = dataGridView1[0, numberRow].Value.ToString();
            command.Parameters.Add("@nts", MySqlDbType.VarChar).Value = notes;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Выкройка добавлена в избранное.");

            db.closeConnection();
        }
    }
}
