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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            Program.SetRoundedShape(category_header, 30);
        }

        private void back_category_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        // Перемещение формы
        Point lastPoint;

        private void categoryPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void categoryPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Действия с кнопкой "x" (закрытие)
        private void category_close_Click(object sender, EventArgs e)
        {
            // Выход из приложения
            Application.Exit();
        }

        private void category_close_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            category_close.ForeColor = Color.White;
        }

        private void category_close_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            category_close.ForeColor = Color.FromArgb(63, 55, 77);
        }

        private void category_LK_MouseEnter(object sender, EventArgs e)
        {
            // Изменение цвета при наведении
            category_LK.ForeColor = Color.FromArgb(191, 191, 191);
        }

        private void category_LK_MouseLeave(object sender, EventArgs e)
        {
            // Изменение цвета при выходе за пределы границы кнопки
            category_LK.ForeColor = Color.White;
        }

        private void category_LK_Click(object sender, EventArgs e)
        {
            PrivatForm PrivatForm = new PrivatForm();
            PrivatForm.Show();
        }

        private void back_category_MouseEnter(object sender, EventArgs e)
        {
            back_category.Image = Properties.Resources.back_arrow_white;
        }

        private void back_category_MouseLeave(object sender, EventArgs e)
        {
            back_category.Image = Properties.Resources.back_arrow;
        }

        private void trousers_MouseEnter(object sender, EventArgs e)
        {
            trousers.BackColor = Color.White;
        }

        private void trousers_MouseLeave(object sender, EventArgs e)
        {
            trousers.BackColor = Color.Transparent;
        }

        private void shorts_MouseEnter(object sender, EventArgs e)
        {
            shorts.BackColor = Color.White;
        }

        private void shorts_MouseLeave(object sender, EventArgs e)
        {
            shorts.BackColor = Color.Transparent;
        }

        private void skirts_MouseEnter(object sender, EventArgs e)
        {
            skirts.BackColor = Color.White;
        }

        private void skirts_MouseLeave(object sender, EventArgs e)
        {
            skirts.BackColor = Color.Transparent;
        }

        private void jeans_MouseEnter(object sender, EventArgs e)
        {
            jeans.BackColor = Color.White;
        }

        private void jeans_MouseLeave(object sender, EventArgs e)
        {
            jeans.BackColor = Color.Transparent;
        }

        private void skirts_Click(object sender, EventArgs e)
        {
            Program.ClassCategory.Value = "skirts";

            Hide();
            PatternListForm PatternListForm = new PatternListForm();
            PatternListForm.Show();
        }

        private void trousers_Click(object sender, EventArgs e)
        {
            Program.ClassCategory.Value = "trousers";

            Hide();
            PatternListForm PatternListForm = new PatternListForm();
            PatternListForm.Show();
        }

        private void shorts_Click(object sender, EventArgs e)
        {
            Program.ClassCategory.Value = "shorts";

            Hide();
            PatternListForm PatternListForm = new PatternListForm();
            PatternListForm.Show();
        }

        private void jeans_Click(object sender, EventArgs e)
        {
            Program.ClassCategory.Value = "jeans";

            Hide();
            PatternListForm PatternListForm = new PatternListForm();
            PatternListForm.Show();
        }
    }
}
