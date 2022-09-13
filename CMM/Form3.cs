using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CMM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 form1 = new Form1();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "select * from orderr where order_date> '2022.04.01'";

        }

        private void выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "select * from workers where post_id= '5001'";

        }
        public void Execute()
        {
            MySqlDataReader mysqlcmm; // или MySql.Data.MySqlClient.MySqlDataReader mysqldatareaderstrah;
            dataGridView1.Refresh();
            // проверка наличия запроса
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите или выберите запрос!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string connectionString = "server=localhost;User Id=root;password=;database=cmm;Character Set=cp1251";
                MySqlConnection connect = new
                MySqlConnection(connectionString);
                connect.Open();
                MySqlCommand mysqlcommand = new MySqlCommand(textBox1.Text, connect);
                mysqlcmm = mysqlcommand.ExecuteReader();
                // массив для записи даннЫх
                ArrayList arraylist = new ArrayList(0);
                foreach (DbDataRecord record in mysqlcmm)
                {
                    arraylist.Add(record); // запись результатов запроса
                }
                // закрытие соединения        
                mysqlcmm.Close();
                // перенос результатов в таблицу вывода
                dataGridView1.DataSource = arraylist;
            }
            catch
            {
                MessageBox.Show("Введите или выберите запрос!", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void очиститьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // очистка текстового окна
            ArrayList arraylist = new ArrayList(0); // создание пустого массива
            // при помощи пустого массива обнуляем таблицу вывода
            dataGridView1.DataSource = arraylist;

        }

        private void количествоЗаписейВТаблицеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "select count(*) from orderr";
        }

        private void информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "select * from orderr where order_status= 'Выполнен'";
        }
    }
}
