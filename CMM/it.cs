using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMM
{
    public partial class it : Form
    {
        bool vis = true;
        public it()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                textBox2.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                vis = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" & textBox2.Text == "root")
            {
                
                
                Form1 form1 = new Form1();
                //Вызывается заданная форма
                
                form1.Show();
                
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
