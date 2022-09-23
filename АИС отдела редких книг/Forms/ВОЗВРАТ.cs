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
    public partial class ВОЗВРАТ : Form
    {
        public static DataTable res { get; private set; }

        public ВОЗВРАТ()
        {
            InitializeComponent();
        }

        private void ВОЗВРАТ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Vozvrat". При необходимости она может быть перемещена или удалена.
            this.vozvratTableAdapter.Fill(this.dataSet.Vozvrat);
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
            (new AddForms.addВОЗВРАТ()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Vozvrat = "SELECT * FROM Vozvrat";
            Loading(Vozvrat, authorDataGridView);
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = database.Load(query);
            grid.DataSource = res;
        }
    }
}
