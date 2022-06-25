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
    public partial class DataChangeForm : Form
    {
        public DataChangeForm()
        {
            InitializeComponent();
            FillingDataChangeForm();
        }

        public void FillingDataChangeForm()
        {
            string login = Program.UserLogin.Value;
            DataBase db = new DataBase();

            // Выполнение команды SQL по поиску пользователя
            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `Логин` = @uL", db.getConnection());

            // Установка "заглушки"
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            DataTable table = Program.FuncFilling(command);

            userField.Text = table.Rows[0][0].ToString();
            passField.Text = table.Rows[0][1].ToString();
            pers_paramField.Text = table.Rows[0][2].ToString();

            Initial_passField();
        }

        public void Initial_passField()
        {
            passField.Multiline = false;
            passField.AutoSize = false;
            passField.Size = new Size(passField.Size.Width, userField.Size.Height);
            passField.UseSystemPasswordChar = true;

            passField.ForeColor = Color.Black;
        }

        public void Initial_passField_repeat()
        {
            passField_repeat.Multiline = false;
            passField_repeat.AutoSize = false;
            passField_repeat.Size = new Size(passField_repeat.Size.Width, userField.Size.Height);
            passField_repeat.UseSystemPasswordChar = true;

            passField_repeat.ForeColor = Color.Black;
        }

        // Перемещение формы
        Point lastPoint;

        private void dataChangePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void dataChangePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Действия с кнопкой "x" (закрытие)
        private void dataChange_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dataChange_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            dataChange_close.ForeColor = Color.White;
        }

        private void dataChange_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            dataChange_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void cancellation_label_Click(object sender, EventArgs e)
        {
            FillingDataChangeForm();
        }

        private void cancellation_label_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            cancellation_label.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void cancellation_label_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            cancellation_label.ForeColor = Color.White;
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
            {
                passField.Text = "";
                Initial_passField();
            }
        }

        private void passField_repeat_Leave(object sender, EventArgs e)
        {
            if (passField_repeat.Text == "")
            {
                passField_repeat.UseSystemPasswordChar = false;
                passField_repeat.Multiline = true;
                passField_repeat.AutoSize = true;

                passField_repeat.ForeColor = Color.FromArgb(246, 239, 243);
                passField_repeat.Text = "подтвердите пароль";
            }
        }

        private void passField_repeat_Enter(object sender, EventArgs e)
        {
            if (passField_repeat.Text == "подтвердите пароль")
            {
                passField_repeat.Text = "";
                Initial_passField_repeat();
            }
        }

        private void passField_repeat_TextChanged(object sender, EventArgs e)
        {
            if (passField.Text != passField_repeat.Text)
                passField_repeat.BackColor = Color.FromArgb(255, 179, 179);
            else passField_repeat.BackColor = SystemColors.Window;
        }

        private void pers_paramField_Enter(object sender, EventArgs e)
        {
            if (pers_paramField.Text == "личные параметры")
            {
                pers_paramField.Text = "";
                pers_paramField.ForeColor = Color.Black;
            }
        }

        private void pers_paramField_Leave(object sender, EventArgs e)
        {
            if (pers_paramField.Text == "")
            {
                pers_paramField.ForeColor = Color.FromArgb(246, 239, 243);
                pers_paramField.Text = "личные параметры";
            }
        }

        private void pers_paramField_TextChanged(object sender, EventArgs e)
        {
            string str = pers_paramField.Text;
            int count = 0;
            int temp = 0;
            bool res = false;
            int i = 0;

            foreach (char ch in str)
            {
                i++;

                if ((int)ch >= 65 && (int)ch <= 90 || (int)ch >= 97 && (int)ch <= 122)
                    res = true;
                    
                if (ch == ' ')
                {
                    count++;
                    temp = i;
                }
            }

            if ((count != 17 || str.Length == temp || res == true) && i != 0 && pers_paramField.Text != "личные параметры")
                pers_paramField.BackColor = Color.FromArgb(255, 179, 179);
            else pers_paramField.BackColor = SystemColors.Window;

            if (pers_paramField.Text == "")
            {
                pers_paramField.ForeColor = Color.FromArgb(246, 239, 243);
                pers_paramField.Text = "личные параметры";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pers_paramField.BackColor == Color.FromArgb(255, 179, 179) ||
                passField_repeat.BackColor == Color.FromArgb(255, 179, 179)) 
                MessageBox.Show("Неверно введены некоторые поля");
            else
            {
                string login = Program.UserLogin.Value;
                DataBase db = new DataBase();

                // Выполнение команды SQL по поиску пользователя
                MySqlCommand command = new MySqlCommand("UPDATE `пользователи` set `Логин` = @uLN, `Пароль` = @uPN, `Личные параметры` = @uMN  where `Логин` = @uL", db.getConnection());

                // Установка "заглушек"
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@uLN", MySqlDbType.VarChar).Value = userField.Text;
                command.Parameters.Add("@uPN", MySqlDbType.VarChar).Value = passField.Text;
                command.Parameters.Add("@uMN", MySqlDbType.VarChar).Value = pers_paramField.Text;

                Program.UserLogin.Value = userField.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные изменены.");
                    Hide();
                }

                else MessageBox.Show("Непредвидимая ошибка. Не удалось обновить данные.");

                db.closeConnection();
            }
        }

        private void DataChangeForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pers_paramField, "Обхват груди, обхват талии, обхват бедер, высота бедер, центр груди, высота груди, ширина груди, ширина над грудью, \n" +
                "расстояние между двумя предыдущими мерками, ширина спины, длина до талии спинки 1, длина до талии спинки 2, длина до талии переда, \n" +
                "обхват шеи, длина плеча, обхват плеча, обхват запястья, длина рукава");
        }
    }
}
