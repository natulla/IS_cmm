using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cmmDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cmmDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.orderr". При необходимости она может быть перемещена или удалена.
            this.orderrTableAdapter.Fill(this.cmmDataSet.orderr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.cmmDataSet.delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.cmmDataSet.payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.cmmDataSet.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.cmmDataSet.workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.cmmDataSet.klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.cmmDataSet.provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cmmDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.cmmDataSet.product);

        }

        private void bindingNavigator3_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //записывает данные из DataGridView в DataSet
                    providerDataGridView.DataSource =
                        cmmDataSet.post;
                    //обновляет базу данных 
                    providerTableAdapter.Update(cmmDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                klientDataGridView.DataSource =
                    cmmDataSet.post;
                klientTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                workersDataGridView.DataSource =
                    cmmDataSet.post;
                workersTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                postDataGridView.DataSource =
                    cmmDataSet.post;
                postTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                paymentDataGridView.DataSource =
                    cmmDataSet.post;
                paymentTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                deliveryDataGridView.DataSource =
                    cmmDataSet.post;
                deliveryTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                orderrDataGridView.DataSource =
                    cmmDataSet.post;
                orderrTableAdapter.Update(cmmDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
           Form1 form1 = new Form1();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //закрытие всего клиенского приложения (проекта) со всеми формами
            Application.Exit();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal sum1 = (decimal)cmmDataSet.payment.Compute("SUM(payment_summ)", "payment_id>0");
            textBox1.Text = sum1.ToString();

        }

        int a = 0;// переменная для учета выбранной таблицы из БД
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {
            String a2 = "";
            String a3 = textBox2.Text;
            bool c = false; // c = true, если поле числовое или типа дата
            if (comboBox2.SelectedItem != null && a == 1)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "product_id"; c = true; break;
                    case 1: a2 = "provider_id"; c = true; break;
                    case 2: a2 = "product_name"; break;
                    case 3: a2 = "product_price"; c = true; break;
                    case 4: a2 = "product_country"; break;

                        //   
                }
                if (c == false) productBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";//поиск текста (или частичное совпадение)
                else productBindingSource.Filter = a2 + "=" + a3;// поиск точного совпадения числа или даты 
            }
            else
            if (comboBox2.SelectedItem != null && a == 2)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "provider_id"; c = true; break;
                    case 1: a2 = "provider_name"; break;
                    case 2: a2 = "provider_salary"; c = true; break;

                }
                if (c == false) providerBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else providerBindingSource.Filter = a2 + "=" + "'" + a3 + "'";
            }
            else
                if (comboBox2.SelectedItem != null && a == 3)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "klient_id"; c = true; break;
                    case 1: a2 = "klient_surname"; break;
                    case 2: a2 = "klient_name"; break;
                    case 3: a2 = "klient_patronomyc"; c = true; break;
                    case 4: a2 = "klient_phone"; c = true; break;
                    case 5: a2 = "klient_gender"; break;
                    case 6: a2 = "klient_email"; break;
                }
                if (c == false) klientBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else klientBindingSource.Filter = a2 + "=" + "'" + a3 + "'";
            }

            else
                if (comboBox2.SelectedItem != null && a == 4)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "workers_id"; c = true; break;
                    case 1: a2 = "post_id"; c = true; break;
                    case 2: a2 = "workers_surname"; break;
                    case 3: a2 = "workers_name"; c = true; break;
                    case 4: a2 = "workers_patronomyc"; break;
                    case 5: a2 = "workers_gender"; break;
                    case 6: a2 = "workers_phone"; c = true; break;
                    case 7: a2 = "workers_passport"; c = true; break;
                    case 8: a2 = "workers_adress"; break;
                    case 9: a2 = "workers_inn"; c = true; break;

                }
                if (c == false) workersBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else workersBindingSource.Filter = a2 + "=" + "'" + a3 + "'";
            }

            else
                if (comboBox2.SelectedItem != null && a == 5)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "post_id"; c = true; break;
                    case 1: a2 = "post_name"; break;
                    case 2: a2 = "post_salary"; c = true; break;
                }
                if (c == false) postBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else postBindingSource.Filter = a2 + "=" + "'" + a3 + "'";

            }

            else
                if (comboBox2.SelectedItem != null && a == 6)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "payment_id"; c = true; break;
                    case 1: a2 = "payment_date"; c = true; break;
                    case 2: a2 = "payment_summ"; c = true; break;

                }
                if (c == false) paymentBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else paymentBindingSource.Filter = a2 + "=" + "'" + a3 + "'";

            }

            else
                if (comboBox2.SelectedItem != null && a == 7)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "delivery_id"; c = true; break;
                    case 1: a2 = "fio_driver"; break;
                    case 2: a2 = "phone_driver"; c = true; break;
                    case 3: a2 = "delivery_date"; c = true; break;
                    case 4: a2 = "delivery_adress"; break;

                }
                if (c == false) deliveryBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else deliveryBindingSource.Filter = a2 + "=" + "'" + a3 + "'";

            }

            else
                if (comboBox2.SelectedItem != null && a == 8)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: a2 = "order_number"; c = true; break;
                    case 1: a2 = "product_date"; c = true; break;
                    case 2: a2 = "workers_id"; c = true; break;
                    case 3: a2 = "payment_name"; c = true; break;
                    case 4: a2 = "delivery_id"; c = true; break;
                    case 5: a2 = "klient_id"; c = true; break;
                    case 6: a2 = "order_date"; c = true; break;
                    case 7: a2 = "order_status"; break;
                    case 8: a2 = "order_quantity"; c = true; break;
                }
                if (c == false) orderrBindingSource.Filter = a2 + " LIKE '%" + a3 + "%'";
                else orderrBindingSource.Filter = a2 + "=" + "'" + a3 + "'";

            }

            else MessageBox.Show("Ничего не введено");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            if (a == 1)
                productBindingSource.Filter = "";
            if (a == 2)
                providerBindingSource.Filter = "";
            if (a == 3)
                klientBindingSource.Filter = "";
            if (a == 4)
                workersBindingSource.Filter = "";
            if (a == 5)
                postBindingSource.Filter = "";
            if (a == 6)
                paymentBindingSource.Filter = "";
            if (a == 7)
                deliveryBindingSource.Filter = "";
            if (a == 8)
                orderrBindingSource.Filter = "";
            comboBox2.SelectedIndex = -1;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // создание сохранения в Excel файл

            // прописываем расширение по умолчанию
            saveFileDialog2.DefaultExt = "xls";
            // фильтры, применяемые при сохранении
            saveFileDialog2.Filter = "Excel files(*.xls)|*.xls";
            // заголовок окна сохранения
            saveFileDialog2.Title = "Экспорт: Excel";
            if (saveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // создание потока записи данных
                FileStream orderrStream =
                    new FileStream(saveFileDialog2.FileName, FileMode.Create);
                try
                {
                    // экспорт данных в файл
                    StreamWriter StreamWriterorderr =
                        new StreamWriter(orderrStream, System.Text.Encoding.Unicode);
                    // экспорт заголовков полей
                    foreach (System.Data.DataColumn Column in
                        cmmDataSet.orderr.Columns)
                        StreamWriterorderr.Write(Column.Caption + "\t");
                    StreamWriterorderr.WriteLine();
                    // Экспорт записей
                    foreach (System.Data.DataRow Row in cmmDataSet.orderr.Rows)
                    {
                        foreach (object Entity in Row.ItemArray)
                        {
                            StreamWriterorderr.Write(Entity.ToString() + "\t");
                        }
                        StreamWriterorderr.WriteLine();
                    }
                    StreamWriterorderr.Flush(); // очистка
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                orderrStream.Close();  // закрытие потока
                //process.Start(VidStrahStream.Name);
            }

        }

        private void cmmDataSetBindingSource5_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: dataGridView1.DataSource = productBindingSource; a = 1; break;
                    case 1: dataGridView1.DataSource = providerBindingSource; a = 2; break;
                    case 2: dataGridView1.DataSource = klientBindingSource; a = 3; break;
                    case 3: dataGridView1.DataSource = workersBindingSource; a = 4; break;
                    case 4: dataGridView1.DataSource = postBindingSource; a = 5; break;
                    case 5: dataGridView1.DataSource = paymentBindingSource; a = 6; break;
                    case 6: dataGridView1.DataSource = deliveryBindingSource; a = 7; break;
                    case 7: dataGridView1.DataSource = orderrBindingSource; a = 8; break;
                }
            }
            if (a == 1)
            {
                comboBox2.Items.Add("Код товара");
                comboBox2.Items.Add("Код поставщика");
                comboBox2.Items.Add("Название товара");
                comboBox2.Items.Add("Стоимость");
                comboBox2.Items.Add("Страна производства");
            }
            if (a == 2)
            {
                comboBox2.Items.Add("Код поставщика");
                comboBox2.Items.Add("Наименование");
                comboBox2.Items.Add("Адрес");
                comboBox2.Items.Add("Телефон");
                comboBox2.Items.Add("e-mail");
            }
            if (a == 3)
            {
                comboBox2.Items.Add("Код клиента");
                comboBox2.Items.Add("Фамилия");
                comboBox2.Items.Add("Имя");
                comboBox2.Items.Add("Отчество");
                comboBox2.Items.Add("Телефон");
                comboBox2.Items.Add("Пол");
                comboBox2.Items.Add("E-mail");
            }
            if (a == 4)
            {
                comboBox2.Items.Add("Код работника");
                comboBox2.Items.Add("Код должности");
                comboBox2.Items.Add("Фамилия");
                comboBox2.Items.Add("Имя");
                comboBox2.Items.Add("Отчество");
                comboBox2.Items.Add("Пол");
                comboBox2.Items.Add("Телефон");
                comboBox2.Items.Add("Паспорт");
                comboBox2.Items.Add("Адрес");
                comboBox2.Items.Add("ИНН");
            }
            if (a == 5)
            {
                comboBox2.Items.Add("Код должности");
                comboBox2.Items.Add("Наименование");
                comboBox2.Items.Add("Оклад");
            }
            if (a == 6)
            {
                comboBox2.Items.Add("Код платежа");
                comboBox2.Items.Add("Дата платежа");
                comboBox2.Items.Add("Сумма платежа");
            }
            if (a == 7)
            {
                comboBox2.Items.Add("Код доставки");
                comboBox2.Items.Add("ФИО водителя");
                comboBox2.Items.Add("Телефон");
                comboBox2.Items.Add("Дата доставки");
                comboBox2.Items.Add("Адрес доставки");
            }
            if (a == 8)
            {
                comboBox2.Items.Add("Номер заказа");
                comboBox2.Items.Add("Код товара");
                comboBox2.Items.Add("Код сотрудника");
                comboBox2.Items.Add("Код платежа");
                comboBox2.Items.Add("Код доставки");
                comboBox2.Items.Add("Код клиента");
                comboBox2.Items.Add("Дата доставки");
                comboBox2.Items.Add("Статус доставки");
                comboBox2.Items.Add("Количество товара");
            
        
        }

    }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

