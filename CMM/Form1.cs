using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace CMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//Для закрытия всего приложения
        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создается объект формы
            Form2 form2 = new Form2();
            //Вызывается заданная форма
            form2.Show();

        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создается объект формы
            Form3 form3 = new Form3();
            //Вызывается заданная форма
            form3.Show();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet1.orderr". При необходимости она может быть перемещена или удалена.
            this.orderrTableAdapter.Fill(this.cmmDataSet1.orderr);

        }
        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Показываем диалог сохранения файла, и проверяем, была ли нажата кнопка «Сохранить», если да, 
            //то выполняем остальные действия 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Сохраняем введенное имя файла в переменную
                string fn = saveFileDialog1.FileName;
                //Создаем файл для записи текстовой информации 
                //с кодировкой 1251(Русскоязычная кодировка Windows)
                StreamWriter sw = new StreamWriter(fn, false, System.Text.Encoding.Default);
                //Создаем копию таблицы для чтения данных
                DataView dv = new DataView(this.cmmDataSet1.orderr as DataTable);
                // Записываем в файл заголовок HTML страницы 
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<title>Заказы</title>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                //Записываем в файл название отчета и заголовки таблицыsw.WriteLine("<h1>Виды страхования</h1>");
                sw.WriteLine("<table border=1>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<td><h3>Номер заказа</h3></td>");
                sw.WriteLine("<td><h3>Статус заказа</h3></td>");
                sw.WriteLine("</tr>");
                //В цикле выводим строки таблицы в HTML документ
                int i;
                for (i = 0; i < dv.Count; i++)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td>" + dv[i]["order_number"] + "</td>");
                    sw.WriteLine("<td>" + dv[i]["order_status"] + "</td>");

                    sw.WriteLine("</tr>");
                }
                //Записываем закрывающие теги HTML документа
                sw.WriteLine("</table>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
                //Закрываем файл
                sw.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
