namespace CMM
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.выполнитьЗапросToolStripMenuItem,
            this.очиститьОкноToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem,
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem,
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem,
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem
            // 
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem.Name = "вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem";
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem.Size = new System.Drawing.Size(368, 22);
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem.Text = "Вывод заказов,  принятых после 1 апреля 2022";
            this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem.Click += new System.EventHandler(this.вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem_Click);
            // 
            // выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem
            // 
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem.Name = "выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem";
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem.Size = new System.Drawing.Size(368, 22);
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem.Text = "Вывод информации о Главном бухгалтере компании";
            this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem.Click += new System.EventHandler(this.выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem_Click);
            // 
            // выполнитьЗапросToolStripMenuItem
            // 
            this.выполнитьЗапросToolStripMenuItem.Name = "выполнитьЗапросToolStripMenuItem";
            this.выполнитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.выполнитьЗапросToolStripMenuItem.Text = "Выполнить запрос";
            this.выполнитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.выполнитьЗапросToolStripMenuItem_Click);
            // 
            // очиститьОкноToolStripMenuItem
            // 
            this.очиститьОкноToolStripMenuItem.Name = "очиститьОкноToolStripMenuItem";
            this.очиститьОкноToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.очиститьОкноToolStripMenuItem.Text = "Очистить окно";
            this.очиститьОкноToolStripMenuItem.Click += new System.EventHandler(this.очиститьОкноToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // количествоЗаписейВТаблицеЗаказыToolStripMenuItem
            // 
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem.Name = "количествоЗаписейВТаблицеЗаказыToolStripMenuItem";
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(368, 22);
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem.Text = "Количество записей в таблице \"Заказы\"";
            this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаписейВТаблицеЗаказыToolStripMenuItem_Click);
            // 
            // информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem
            // 
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem.Name = "информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem";
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem.Size = new System.Drawing.Size(368, 22);
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem.Text = "Информация о заказах, статус которых \"Выполнен\"";
            this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem.Click += new System.EventHandler(this.информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Запросы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вывестиИнформациюОЗаказахВМесяцеАпрелеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводИнформацииОГлавномБухгалтереКомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЗаписейВТаблицеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОЗаказахСтатусКоторыхВыполненToolStripMenuItem;
    }
}