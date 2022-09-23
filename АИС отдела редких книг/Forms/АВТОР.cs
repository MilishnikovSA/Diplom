using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_отдела_редких_книг.Forms
{
    public partial class АВТОР : Form
    {
        public static DataTable res { get; private set; }

        public АВТОР()
        {
            InitializeComponent();
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
            (new AddForms.addАВТОР()).Show();
        }

        private void АВТОР_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.dataSet.Author);
            LoadTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Author = "SELECT * FROM Author";
            Loading(Author, authorDataGridView);
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = database.Load(query);
            grid.DataSource = res;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string Author = "SELECT * FROM Author ORDER BY first_name";
            Loading(Author, authorDataGridView);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string Author = "SELECT * FROM Author ORDER BY second_name";
            Loading(Author, authorDataGridView);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            foreach (DataGridViewRow row in authorDataGridView.SelectedRows)
            {
                authorDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < authorDataGridView.RowCount; i++)
            {
                authorDataGridView.Rows[i].Selected = false;
                for (int j = 0; j < authorDataGridView.ColumnCount; j++)
                    if (authorDataGridView.Rows[i].Cells[j].Value != null)
                        if (authorDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            authorDataGridView.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
