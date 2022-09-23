﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АИС_отдела_редких_книг.AddForms
{
    public partial class addАВТОР : Form
    {
        public addАВТОР()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string add = String.Format("INSERT INTO Author (first_name, second_name, surname) VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Автор добавлен");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Фамилия")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Фамилия";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Имя")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Имя";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Отчество")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Отчество";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
