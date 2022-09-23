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
    public partial class ИЗДАТЕЛЬСТВО : Form
    {
        public ИЗДАТЕЛЬСТВО()
        {
            InitializeComponent();
        }

        private void ИЗДАТЕЛЬСТВО_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Izdatelstvo". При необходимости она может быть перемещена или удалена.
            this.izdatelstvoTableAdapter.Fill(this.dataSet.Izdatelstvo);
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
    }
}
