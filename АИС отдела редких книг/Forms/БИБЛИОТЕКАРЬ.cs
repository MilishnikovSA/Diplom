using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_отдела_редких_книг.Forms
{
    public partial class БИБЛИОТЕКАРЬ : Form
    {
        public static DataTable res { get; private set; }

        public БИБЛИОТЕКАРЬ()
        {
            InitializeComponent();
        }

        private void БИБЛИОТЕКАРЬ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Bibliotekar". При необходимости она может быть перемещена или удалена.
            this.bibliotekarTableAdapter.Fill(this.dataSet.Bibliotekar);
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new AddForms.addБИБЛИОТЕКАРЬ()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Bilbliotekar = "SELECT * FROM Bilbliotekar";
            Loading(Bilbliotekar, authorDataGridView);
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = database.Load(query);
            grid.DataSource = res;
        }
    }
}
