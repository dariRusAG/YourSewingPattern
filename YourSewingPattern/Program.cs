using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourSewingPattern
{
    static class Program
    {
        // Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static void SetRoundedShape(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);

            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);

            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);

            control.Region = new Region(path);
        }

        // Хранение логина
        public static class UserLogin
        {
            public static string Value { get; set; }
        }

        // Хранение категории
        public static class ClassCategory
        {
            public static string Value { get; set; }
        }

        // Распознавание категории
        public static int NumberCategory()
        {
            string classCategory = ClassCategory.Value;
            int numberCategory;

            if (classCategory == "skirts") numberCategory = 1;
            else if (classCategory == "trousers") numberCategory = 2;
            else if (classCategory == "shorts") numberCategory = 6;
            else if (classCategory == "jeans") numberCategory = 7; 
            else numberCategory = 0;

            return numberCategory;
        }

        public static DataTable FuncFilling(MySqlCommand command)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Выполняем предыдущие команды
            adapter.SelectCommand = command;
            // Передача полученных данных в рабочую переменную
            adapter.Fill(table);

            return table;
        }
    }
}
