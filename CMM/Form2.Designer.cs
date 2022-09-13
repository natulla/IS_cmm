namespace CMM
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label provider_idLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_priceLabel;
            System.Windows.Forms.Label product_countryLabel;
            System.Windows.Forms.Label dataColumn1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmmDataSet = new CMM.cmmDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.providerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.klientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.postDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem6 = new System.Windows.Forms.ToolStripButton();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem6 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem6 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.bindingNavigator7 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem7 = new System.Windows.Forms.ToolStripButton();
            this.orderrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem7 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem7 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.orderrDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmmDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.provider_idComboBox = new System.Windows.Forms.ComboBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_priceTextBox = new System.Windows.Forms.TextBox();
            this.product_countryTextBox = new System.Windows.Forms.TextBox();
            this.dataColumn1TextBox = new System.Windows.Forms.TextBox();
            this.productTableAdapter = new CMM.cmmDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new CMM.cmmDataSetTableAdapters.TableAdapterManager();
            this.deliveryTableAdapter = new CMM.cmmDataSetTableAdapters.deliveryTableAdapter();
            this.klientTableAdapter = new CMM.cmmDataSetTableAdapters.klientTableAdapter();
            this.orderrTableAdapter = new CMM.cmmDataSetTableAdapters.orderrTableAdapter();
            this.paymentTableAdapter = new CMM.cmmDataSetTableAdapters.paymentTableAdapter();
            this.postTableAdapter = new CMM.cmmDataSetTableAdapters.postTableAdapter();
            this.providerTableAdapter = new CMM.cmmDataSetTableAdapters.providerTableAdapter();
            this.workersTableAdapter = new CMM.cmmDataSetTableAdapters.workersTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.cmmDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            product_idLabel = new System.Windows.Forms.Label();
            provider_idLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            product_priceLabel = new System.Windows.Forms.Label();
            product_countryLabel = new System.Windows.Forms.Label();
            dataColumn1Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).BeginInit();
            this.bindingNavigator7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrDataGridView)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(577, 446);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(57, 13);
            product_idLabel.TabIndex = 2;
            product_idLabel.Text = "product id:";
            // 
            // provider_idLabel
            // 
            provider_idLabel.AutoSize = true;
            provider_idLabel.Location = new System.Drawing.Point(577, 472);
            provider_idLabel.Name = "provider_idLabel";
            provider_idLabel.Size = new System.Drawing.Size(59, 13);
            provider_idLabel.TabIndex = 4;
            provider_idLabel.Text = "provider id:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Location = new System.Drawing.Point(577, 499);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(75, 13);
            product_nameLabel.TabIndex = 6;
            product_nameLabel.Text = "product name:";
            // 
            // product_priceLabel
            // 
            product_priceLabel.AutoSize = true;
            product_priceLabel.Location = new System.Drawing.Point(577, 525);
            product_priceLabel.Name = "product_priceLabel";
            product_priceLabel.Size = new System.Drawing.Size(72, 13);
            product_priceLabel.TabIndex = 8;
            product_priceLabel.Text = "product price:";
            // 
            // product_countryLabel
            // 
            product_countryLabel.AutoSize = true;
            product_countryLabel.Location = new System.Drawing.Point(577, 551);
            product_countryLabel.Name = "product_countryLabel";
            product_countryLabel.Size = new System.Drawing.Size(84, 13);
            product_countryLabel.TabIndex = 10;
            product_countryLabel.Text = "product country:";
            // 
            // dataColumn1Label
            // 
            dataColumn1Label.AutoSize = true;
            dataColumn1Label.Location = new System.Drawing.Point(577, 577);
            dataColumn1Label.Name = "dataColumn1Label";
            dataColumn1Label.Size = new System.Drawing.Size(77, 13);
            dataColumn1Label.TabIndex = 12;
            dataColumn1Label.Text = "Data Column1:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.productBindingNavigator);
            this.tabPage1.Controls.Add(this.productDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(786, 25);
            this.productBindingNavigator.TabIndex = 1;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.cmmDataSet;
            // 
            // cmmDataSet
            // 
            this.cmmDataSet.DataSetName = "cmmDataSet";
            this.cmmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click_1);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(0, 31);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(549, 237);
            this.productDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код товара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "provider_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код поставщика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название товара";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "product_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость (р. за шт)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product_country";
            this.dataGridViewTextBoxColumn5.HeaderText = "Страна производства";
            this.dataGridViewTextBoxColumn5.Items.AddRange(new object[] {
            "Россия",
            "Германия",
            "Китай",
            "Швеция",
            "США",
            "Франция",
            "Канада"});
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.providerDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поставщики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.providerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // providerDataGridView
            // 
            this.providerDataGridView.AutoGenerateColumns = false;
            this.providerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.providerDataGridView.DataSource = this.providerBindingSource;
            this.providerDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.providerDataGridView.Location = new System.Drawing.Point(0, 31);
            this.providerDataGridView.Name = "providerDataGridView";
            this.providerDataGridView.Size = new System.Drawing.Size(544, 220);
            this.providerDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "provider_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код поставщика";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provider_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn7.Items.AddRange(new object[] {
            "STABILA",
            "DAXMER",
            "Folder",
            "NEO TOOLS",
            "Гранит",
            "Агро",
            "DECOR"});
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "provider_adress";
            this.dataGridViewTextBoxColumn8.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "provider_phone";
            this.dataGridViewTextBoxColumn9.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "provider_email";
            this.dataGridViewTextBoxColumn10.HeaderText = "e-mail";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.bindingNavigator2);
            this.tabPage3.Controls.Add(this.klientDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator2.BindingSource = this.klientBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator2.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // klientDataGridView
            // 
            this.klientDataGridView.AutoGenerateColumns = false;
            this.klientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.klientDataGridView.DataSource = this.klientBindingSource;
            this.klientDataGridView.Location = new System.Drawing.Point(0, 31);
            this.klientDataGridView.Name = "klientDataGridView";
            this.klientDataGridView.Size = new System.Drawing.Size(749, 220);
            this.klientDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "klient_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "klient_surname";
            this.dataGridViewTextBoxColumn12.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "klient_name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "klient_patronymic";
            this.dataGridViewTextBoxColumn14.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "klient_phone";
            this.dataGridViewTextBoxColumn15.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "klient_gender";
            this.dataGridViewTextBoxColumn16.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn16.Items.AddRange(new object[] {
            "ж",
            "м"});
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "klient_email";
            this.dataGridViewTextBoxColumn17.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.bindingNavigator3);
            this.tabPage4.Controls.Add(this.workersDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator3.BindingSource = this.workersBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator3.Size = new System.Drawing.Size(792, 25);
            this.bindingNavigator3.TabIndex = 1;
            this.bindingNavigator3.Text = "bindingNavigator3";
            this.bindingNavigator3.RefreshItems += new System.EventHandler(this.bindingNavigator3_RefreshItems);
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Добавить";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem3.Text = "для {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(0, 28);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(792, 237);
            this.workersDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "workers_id";
            this.dataGridViewTextBoxColumn18.HeaderText = "Код работника";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "post_id";
            this.dataGridViewTextBoxColumn19.HeaderText = "Код должности";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "workers_surname";
            this.dataGridViewTextBoxColumn20.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "workers_name";
            this.dataGridViewTextBoxColumn21.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "workers_patronomyc";
            this.dataGridViewTextBoxColumn22.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "workers_gender";
            this.dataGridViewTextBoxColumn23.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn23.Items.AddRange(new object[] {
            "ж",
            "м"});
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "workers_phone";
            this.dataGridViewTextBoxColumn24.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "workers_passport";
            this.dataGridViewTextBoxColumn25.HeaderText = "Паспорт";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "workers_adress";
            this.dataGridViewTextBoxColumn26.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "workers_inn";
            this.dataGridViewTextBoxColumn27.HeaderText = "ИНН";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.bindingNavigator4);
            this.tabPage5.Controls.Add(this.postDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 309);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Должности";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.bindingNavigator4.BindingSource = this.postBindingSource;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator4.Size = new System.Drawing.Size(792, 25);
            this.bindingNavigator4.TabIndex = 1;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "Добавить";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem4.Text = "для {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // postDataGridView
            // 
            this.postDataGridView.AutoGenerateColumns = false;
            this.postDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.postDataGridView.DataSource = this.postBindingSource;
            this.postDataGridView.Location = new System.Drawing.Point(0, 28);
            this.postDataGridView.Name = "postDataGridView";
            this.postDataGridView.Size = new System.Drawing.Size(343, 220);
            this.postDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "post_id";
            this.dataGridViewTextBoxColumn28.HeaderText = "Код должности";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "post_name";
            this.dataGridViewTextBoxColumn29.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "post_salary";
            this.dataGridViewTextBoxColumn30.HeaderText = "Оклад";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.button10);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.bindingNavigator5);
            this.tabPage6.Controls.Add(this.paymentDataGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 309);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Платежи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Итого заказов на сумму:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(255, 266);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Расчет";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(271, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.bindingNavigatorAddNewItem5;
            this.bindingNavigator5.BindingSource = this.paymentBindingSource;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem5;
            this.bindingNavigator5.DeleteItem = this.bindingNavigatorDeleteItem5;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem5;
            this.bindingNavigator5.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator5.TabIndex = 1;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorAddNewItem5
            // 
            this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
            this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
            this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem5.Text = "Добавить";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem5.Text = "для {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem5
            // 
            this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
            this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
            this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem5.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(3, 31);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.Size = new System.Drawing.Size(343, 220);
            this.paymentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn31.HeaderText = "Код платежа";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "payment_date";
            this.dataGridViewTextBoxColumn32.HeaderText = "Дата платежа";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "payment_summ";
            this.dataGridViewTextBoxColumn33.HeaderText = "Сумма платежа";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button6);
            this.tabPage7.Controls.Add(this.bindingNavigator6);
            this.tabPage7.Controls.Add(this.deliveryDataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(792, 309);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Доставка";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(267, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = this.bindingNavigatorAddNewItem6;
            this.bindingNavigator6.BindingSource = this.deliveryBindingSource;
            this.bindingNavigator6.CountItem = this.bindingNavigatorCountItem6;
            this.bindingNavigator6.DeleteItem = this.bindingNavigatorDeleteItem6;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem6,
            this.bindingNavigatorMovePreviousItem6,
            this.bindingNavigatorSeparator18,
            this.bindingNavigatorPositionItem6,
            this.bindingNavigatorCountItem6,
            this.bindingNavigatorSeparator19,
            this.bindingNavigatorMoveNextItem6,
            this.bindingNavigatorMoveLastItem6,
            this.bindingNavigatorSeparator20,
            this.bindingNavigatorAddNewItem6,
            this.bindingNavigatorDeleteItem6});
            this.bindingNavigator6.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator6.MoveFirstItem = this.bindingNavigatorMoveFirstItem6;
            this.bindingNavigator6.MoveLastItem = this.bindingNavigatorMoveLastItem6;
            this.bindingNavigator6.MoveNextItem = this.bindingNavigatorMoveNextItem6;
            this.bindingNavigator6.MovePreviousItem = this.bindingNavigatorMovePreviousItem6;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.bindingNavigatorPositionItem6;
            this.bindingNavigator6.Size = new System.Drawing.Size(792, 25);
            this.bindingNavigator6.TabIndex = 1;
            this.bindingNavigator6.Text = "bindingNavigator6";
            // 
            // bindingNavigatorAddNewItem6
            // 
            this.bindingNavigatorAddNewItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem6.Image")));
            this.bindingNavigatorAddNewItem6.Name = "bindingNavigatorAddNewItem6";
            this.bindingNavigatorAddNewItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem6.Text = "Добавить";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "delivery";
            this.deliveryBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem6
            // 
            this.bindingNavigatorCountItem6.Name = "bindingNavigatorCountItem6";
            this.bindingNavigatorCountItem6.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem6.Text = "для {0}";
            this.bindingNavigatorCountItem6.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem6
            // 
            this.bindingNavigatorDeleteItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem6.Image")));
            this.bindingNavigatorDeleteItem6.Name = "bindingNavigatorDeleteItem6";
            this.bindingNavigatorDeleteItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem6.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem6
            // 
            this.bindingNavigatorMoveFirstItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem6.Image")));
            this.bindingNavigatorMoveFirstItem6.Name = "bindingNavigatorMoveFirstItem6";
            this.bindingNavigatorMoveFirstItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem6.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem6
            // 
            this.bindingNavigatorMovePreviousItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem6.Image")));
            this.bindingNavigatorMovePreviousItem6.Name = "bindingNavigatorMovePreviousItem6";
            this.bindingNavigatorMovePreviousItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem6.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator18
            // 
            this.bindingNavigatorSeparator18.Name = "bindingNavigatorSeparator18";
            this.bindingNavigatorSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem6
            // 
            this.bindingNavigatorPositionItem6.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem6.AutoSize = false;
            this.bindingNavigatorPositionItem6.Name = "bindingNavigatorPositionItem6";
            this.bindingNavigatorPositionItem6.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem6.Text = "0";
            this.bindingNavigatorPositionItem6.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator19
            // 
            this.bindingNavigatorSeparator19.Name = "bindingNavigatorSeparator19";
            this.bindingNavigatorSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem6
            // 
            this.bindingNavigatorMoveNextItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem6.Image")));
            this.bindingNavigatorMoveNextItem6.Name = "bindingNavigatorMoveNextItem6";
            this.bindingNavigatorMoveNextItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem6.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem6
            // 
            this.bindingNavigatorMoveLastItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem6.Image")));
            this.bindingNavigatorMoveLastItem6.Name = "bindingNavigatorMoveLastItem6";
            this.bindingNavigatorMoveLastItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem6.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator20
            // 
            this.bindingNavigatorSeparator20.Name = "bindingNavigatorSeparator20";
            this.bindingNavigatorSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // deliveryDataGridView
            // 
            this.deliveryDataGridView.AutoGenerateColumns = false;
            this.deliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.deliveryDataGridView.DataSource = this.deliveryBindingSource;
            this.deliveryDataGridView.Location = new System.Drawing.Point(0, 28);
            this.deliveryDataGridView.Name = "deliveryDataGridView";
            this.deliveryDataGridView.Size = new System.Drawing.Size(558, 220);
            this.deliveryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "delivery_id";
            this.dataGridViewTextBoxColumn34.HeaderText = "Код доставки";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "fio_driver";
            this.dataGridViewTextBoxColumn35.HeaderText = "ФИО водителя";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "phone_driver";
            this.dataGridViewTextBoxColumn36.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "delivery_date";
            this.dataGridViewTextBoxColumn37.HeaderText = "Дата доставки";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "delivery_adress";
            this.dataGridViewTextBoxColumn38.HeaderText = "Адрес доставки";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button13);
            this.tabPage8.Controls.Add(this.button7);
            this.tabPage8.Controls.Add(this.bindingNavigator7);
            this.tabPage8.Controls.Add(this.orderrDataGridView);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(792, 309);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Заказы";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(606, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(132, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "Экспорт в Excel";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(267, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // bindingNavigator7
            // 
            this.bindingNavigator7.AddNewItem = this.bindingNavigatorAddNewItem7;
            this.bindingNavigator7.BindingSource = this.orderrBindingSource;
            this.bindingNavigator7.CountItem = this.bindingNavigatorCountItem7;
            this.bindingNavigator7.DeleteItem = this.bindingNavigatorDeleteItem7;
            this.bindingNavigator7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem7,
            this.bindingNavigatorMovePreviousItem7,
            this.bindingNavigatorSeparator21,
            this.bindingNavigatorPositionItem7,
            this.bindingNavigatorCountItem7,
            this.bindingNavigatorSeparator22,
            this.bindingNavigatorMoveNextItem7,
            this.bindingNavigatorMoveLastItem7,
            this.bindingNavigatorSeparator23,
            this.bindingNavigatorAddNewItem7,
            this.bindingNavigatorDeleteItem7});
            this.bindingNavigator7.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator7.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bindingNavigator7.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bindingNavigator7.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bindingNavigator7.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bindingNavigator7.Name = "bindingNavigator7";
            this.bindingNavigator7.PositionItem = this.bindingNavigatorPositionItem7;
            this.bindingNavigator7.Size = new System.Drawing.Size(792, 25);
            this.bindingNavigator7.TabIndex = 1;
            this.bindingNavigator7.Text = "bindingNavigator7";
            // 
            // bindingNavigatorAddNewItem7
            // 
            this.bindingNavigatorAddNewItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem7.Image")));
            this.bindingNavigatorAddNewItem7.Name = "bindingNavigatorAddNewItem7";
            this.bindingNavigatorAddNewItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem7.Text = "Добавить";
            // 
            // orderrBindingSource
            // 
            this.orderrBindingSource.DataMember = "orderr";
            this.orderrBindingSource.DataSource = this.cmmDataSet;
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem7.Text = "для {0}";
            this.bindingNavigatorCountItem7.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem7
            // 
            this.bindingNavigatorDeleteItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem7.Image")));
            this.bindingNavigatorDeleteItem7.Name = "bindingNavigatorDeleteItem7";
            this.bindingNavigatorDeleteItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem7.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem7
            // 
            this.bindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem7.Image")));
            this.bindingNavigatorMoveFirstItem7.Name = "bindingNavigatorMoveFirstItem7";
            this.bindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem7.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem7
            // 
            this.bindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem7.Image")));
            this.bindingNavigatorMovePreviousItem7.Name = "bindingNavigatorMovePreviousItem7";
            this.bindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem7.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator21
            // 
            this.bindingNavigatorSeparator21.Name = "bindingNavigatorSeparator21";
            this.bindingNavigatorSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem7
            // 
            this.bindingNavigatorPositionItem7.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem7.AutoSize = false;
            this.bindingNavigatorPositionItem7.Name = "bindingNavigatorPositionItem7";
            this.bindingNavigatorPositionItem7.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem7.Text = "0";
            this.bindingNavigatorPositionItem7.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator22
            // 
            this.bindingNavigatorSeparator22.Name = "bindingNavigatorSeparator22";
            this.bindingNavigatorSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem7
            // 
            this.bindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem7.Image")));
            this.bindingNavigatorMoveNextItem7.Name = "bindingNavigatorMoveNextItem7";
            this.bindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem7.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem7
            // 
            this.bindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem7.Image")));
            this.bindingNavigatorMoveLastItem7.Name = "bindingNavigatorMoveLastItem7";
            this.bindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem7.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator23
            // 
            this.bindingNavigatorSeparator23.Name = "bindingNavigatorSeparator23";
            this.bindingNavigatorSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // orderrDataGridView
            // 
            this.orderrDataGridView.AutoGenerateColumns = false;
            this.orderrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47});
            this.orderrDataGridView.DataSource = this.orderrBindingSource;
            this.orderrDataGridView.Location = new System.Drawing.Point(0, 28);
            this.orderrDataGridView.Name = "orderrDataGridView";
            this.orderrDataGridView.Size = new System.Drawing.Size(796, 220);
            this.orderrDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "order_number";
            this.dataGridViewTextBoxColumn39.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn40.HeaderText = "Код товара";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "workers_id";
            this.dataGridViewTextBoxColumn41.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn42.HeaderText = "Код платежа";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "delivery_id";
            this.dataGridViewTextBoxColumn43.HeaderText = "Код доставки";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "klient_id";
            this.dataGridViewTextBoxColumn44.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn45.HeaderText = "Дата доставки";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "order_status";
            this.dataGridViewTextBoxColumn46.HeaderText = "Статус доставки";
            this.dataGridViewTextBoxColumn46.Items.AddRange(new object[] {
            "Выполнен",
            "В обработке",
            "Отложен",
            "Аннулирован",
            "Доставлено",
            "Ожидает звонка"});
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "order_quantity";
            this.dataGridViewTextBoxColumn47.HeaderText = "Количество товара (шт)";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.comboBox1);
            this.tabPage9.Controls.Add(this.button12);
            this.tabPage9.Controls.Add(this.button11);
            this.tabPage9.Controls.Add(this.textBox2);
            this.tabPage9.Controls.Add(this.dataGridView1);
            this.tabPage9.Controls.Add(this.comboBox2);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Controls.Add(this.label2);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(792, 309);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Поиск данных";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Товары",
            "Поставщики",
            "Клиенты",
            "Сотрудники",
            "Должности",
            "Платежи",
            "Доставка",
            "Заказы"});
            this.comboBox1.Location = new System.Drawing.Point(179, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(411, 263);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "Очистить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(411, 216);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "Поиск";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(240, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введите текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите поле для поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите таблицу";
            // 
            // cmmDataSetBindingSource1
            // 
            this.cmmDataSetBindingSource1.DataSource = this.cmmDataSet;
            this.cmmDataSetBindingSource1.Position = 0;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(667, 443);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(121, 20);
            this.product_idTextBox.TabIndex = 3;
            // 
            // provider_idComboBox
            // 
            this.provider_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "provider_id", true));
            this.provider_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "DataColumn1", true));
            this.provider_idComboBox.DataSource = this.providerBindingSource;
            this.provider_idComboBox.DisplayMember = "provider_name";
            this.provider_idComboBox.FormattingEnabled = true;
            this.provider_idComboBox.Location = new System.Drawing.Point(667, 469);
            this.provider_idComboBox.Name = "provider_idComboBox";
            this.provider_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.provider_idComboBox.TabIndex = 5;
            this.provider_idComboBox.ValueMember = "provider_id";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_name", true));
            this.product_nameTextBox.Location = new System.Drawing.Point(667, 496);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.product_nameTextBox.TabIndex = 7;
            // 
            // product_priceTextBox
            // 
            this.product_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_price", true));
            this.product_priceTextBox.Location = new System.Drawing.Point(667, 522);
            this.product_priceTextBox.Name = "product_priceTextBox";
            this.product_priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.product_priceTextBox.TabIndex = 9;
            // 
            // product_countryTextBox
            // 
            this.product_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "product_country", true));
            this.product_countryTextBox.Location = new System.Drawing.Point(667, 548);
            this.product_countryTextBox.Name = "product_countryTextBox";
            this.product_countryTextBox.Size = new System.Drawing.Size(121, 20);
            this.product_countryTextBox.TabIndex = 11;
            // 
            // dataColumn1TextBox
            // 
            this.dataColumn1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "DataColumn1", true));
            this.dataColumn1TextBox.Location = new System.Drawing.Point(667, 574);
            this.dataColumn1TextBox.Name = "dataColumn1TextBox";
            this.dataColumn1TextBox.Size = new System.Drawing.Size(121, 20);
            this.dataColumn1TextBox.TabIndex = 13;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.klientTableAdapter = this.klientTableAdapter;
            this.tableAdapterManager.orderrTableAdapter = this.orderrTableAdapter;
            this.tableAdapterManager.paymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.postTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.providerTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMM.cmmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workersTableAdapter = this.workersTableAdapter;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // orderrTableAdapter
            // 
            this.orderrTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 37);
            this.button8.TabIndex = 1;
            this.button8.Text = "Назад";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(437, 356);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 37);
            this.button9.TabIndex = 2;
            this.button9.Text = "Выйти из программы";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // cmmDataSetBindingSource
            // 
            this.cmmDataSetBindingSource.DataSource = this.cmmDataSet;
            this.cmmDataSetBindingSource.Position = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(product_idLabel);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.product_idTextBox);
            this.Controls.Add(provider_idLabel);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.provider_idComboBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.dataColumn1TextBox);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(dataColumn1Label);
            this.Controls.Add(product_priceLabel);
            this.Controls.Add(this.product_countryTextBox);
            this.Controls.Add(this.product_priceTextBox);
            this.Controls.Add(product_countryLabel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблицы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).EndInit();
            this.bindingNavigator7.ResumeLayout(false);
            this.bindingNavigator7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrDataGridView)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmmDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private cmmDataSet cmmDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private cmmDataSetTableAdapters.productTableAdapter productTableAdapter;
        private cmmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private cmmDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView providerDataGridView;
        private cmmDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.DataGridView klientDataGridView;
        private cmmDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private cmmDataSetTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.DataGridView postDataGridView;
        private cmmDataSetTableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private cmmDataSetTableAdapters.deliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem6;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator18;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator19;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator20;
        private System.Windows.Forms.DataGridView deliveryDataGridView;
        private cmmDataSetTableAdapters.orderrTableAdapter orderrTableAdapter;
        private System.Windows.Forms.BindingSource orderrBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem7;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.DataGridView orderrDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.ComboBox provider_idComboBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_priceTextBox;
        private System.Windows.Forms.TextBox product_countryTextBox;
        private System.Windows.Forms.TextBox dataColumn1TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.BindingSource cmmDataSetBindingSource;
        private System.Windows.Forms.BindingSource cmmDataSetBindingSource1;
    }
}