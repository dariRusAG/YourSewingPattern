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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Program.SetRoundedShape(main_header, 30);
        }

        // Перемещение формы
        Point lastPoint;

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Действия с кнопкой "x" (закрытие)
        private void main_close_Click(object sender, EventArgs e)
        {
            // Выход из приложения
            Application.Exit();
        }

        private void main_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            main_close.ForeColor = Color.White;
        }

        private void main_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            main_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void main_LK_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            main_LK.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void main_LK_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            main_LK.ForeColor = Color.White;
        }

        private void main_LK_Click(object sender, EventArgs e)
        {
            PrivatForm PrivatForm = new PrivatForm();
            PrivatForm.Show();
        }

        private void two_category_Click(object sender, EventArgs e)
        {
            Hide();
            CategoryForm CategoryForm = new CategoryForm();
            CategoryForm.Show();
        }

        private void one_category_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится в стадии разработки.");
        }

        private void three_category_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится в стадии разработки.");
        }
    }
}
