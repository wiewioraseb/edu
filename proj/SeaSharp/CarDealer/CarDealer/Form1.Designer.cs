namespace CarDealer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.carBrandComboBox = new System.Windows.Forms.ComboBox();
            this.cars1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealer1DataSet = new CarDealer.carDealer1DataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealerDataSet = new CarDealer.car_dealer_dbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.engineComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.isMetallicLacquerCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lacquerColorComboBox = new System.Windows.Forms.ComboBox();
            this.additionalOptionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.carAvatarPB = new System.Windows.Forms.PictureBox();
            this.carAvatarLabel = new System.Windows.Forms.Label();
            this.addEntryLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMetalicLacquerCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addBrandTextBox = new System.Windows.Forms.TextBox();
            this.addModelTextBox = new System.Windows.Forms.TextBox();
            this.addEngineTextBox = new System.Windows.Forms.TextBox();
            this.addLacquerTextBox = new System.Windows.Forms.TextBox();
            this.samochodyTableAdapter = new CarDealer.car_dealer_dbDataSetTableAdapters.samochodyTableAdapter();
            this.addNewCarButton = new System.Windows.Forms.Button();
            this.computer1 = new CompInfo.Computer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carengineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lacquercolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasmetalliclacquerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.haspowersteeringDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasautomatictransmissionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hasairconditioningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDealer2DataSet = new CarDealer.carDealer2DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.cars2TableAdapter = new CarDealer.carDealer2DataSetTableAdapters.carsTableAdapter();
            this.fillByModelToolStrip = new System.Windows.Forms.ToolStrip();
            this.modelToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.modelToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByModelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByEngineToolStrip = new System.Windows.Forms.ToolStrip();
            this.car_engineToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.car_engineToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByEngineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByModelEngineToolStrip = new System.Windows.Forms.ToolStrip();
            this.modelToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.modelToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.car_engineToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.car_engineToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByModelEngineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cars1TableAdapter = new CarDealer.carDealer1DataSetTableAdapters.carsTableAdapter();
            this.fillByProductionYearToolStrip = new System.Windows.Forms.ToolStrip();
            this.production_yearToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.production_yearToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByProductionYearToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.cars1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer2DataSet)).BeginInit();
            this.fillByModelToolStrip.SuspendLayout();
            this.fillByEngineToolStrip.SuspendLayout();
            this.fillByModelEngineToolStrip.SuspendLayout();
            this.fillByProductionYearToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka samochodu:";
            // 
            // carBrandComboBox
            // 
            this.carBrandComboBox.DataSource = this.cars1BindingSource;
            this.carBrandComboBox.DisplayMember = "brand";
            this.carBrandComboBox.FormattingEnabled = true;
            this.carBrandComboBox.Location = new System.Drawing.Point(28, 45);
            this.carBrandComboBox.Name = "carBrandComboBox";
            this.carBrandComboBox.Size = new System.Drawing.Size(121, 21);
            this.carBrandComboBox.TabIndex = 3;
            this.carBrandComboBox.SelectedIndexChanged += new System.EventHandler(this.carBrandComboBox_SelectedIndexChanged);
            // 
            // cars1BindingSource
            // 
            this.cars1BindingSource.DataMember = "cars";
            this.cars1BindingSource.DataSource = this.carDealer1DataSet;
            // 
            // carDealer1DataSet
            // 
            this.carDealer1DataSet.DataSetName = "carDealer1DataSet";
            this.carDealer1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "samochody";
            this.carsBindingSource.DataSource = this.carDealerDataSet;
            // 
            // carDealerDataSet
            // 
            this.carDealerDataSet.DataSetName = "carDealerDataSet";
            this.carDealerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Silnik:";
            // 
            // engineComboBox
            // 
            this.engineComboBox.DataSource = this.cars1BindingSource;
            this.engineComboBox.DisplayMember = "car_engine";
            this.engineComboBox.FormattingEnabled = true;
            this.engineComboBox.Location = new System.Drawing.Point(285, 44);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Size = new System.Drawing.Size(121, 21);
            this.engineComboBox.TabIndex = 8;
            this.engineComboBox.SelectedIndexChanged += new System.EventHandler(this.engineComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.DataSource = this.cars1BindingSource;
            this.carModelComboBox.DisplayMember = "model";
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(158, 44);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.carModelComboBox.TabIndex = 6;
            this.carModelComboBox.SelectedIndexChanged += new System.EventHandler(this.carModelComboBox_SelectedIndexChanged);
            // 
            // isMetallicLacquerCheckBox
            // 
            this.isMetallicLacquerCheckBox.AutoSize = true;
            this.isMetallicLacquerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cars1BindingSource, "has_metallic_lacquer", true));
            this.isMetallicLacquerCheckBox.Location = new System.Drawing.Point(413, 44);
            this.isMetallicLacquerCheckBox.Name = "isMetallicLacquerCheckBox";
            this.isMetallicLacquerCheckBox.Size = new System.Drawing.Size(91, 17);
            this.isMetallicLacquerCheckBox.TabIndex = 10;
            this.isMetallicLacquerCheckBox.Text = "Lakier metalik";
            this.isMetallicLacquerCheckBox.UseVisualStyleBackColor = true;
            this.isMetallicLacquerCheckBox.CheckedChanged += new System.EventHandler(this.isMetallicLacquerCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kolor lakieru:";
            // 
            // lacquerColorComboBox
            // 
            this.lacquerColorComboBox.DataSource = this.cars1BindingSource;
            this.lacquerColorComboBox.DisplayMember = "lacquer_color";
            this.lacquerColorComboBox.FormattingEnabled = true;
            this.lacquerColorComboBox.Location = new System.Drawing.Point(509, 44);
            this.lacquerColorComboBox.Name = "lacquerColorComboBox";
            this.lacquerColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.lacquerColorComboBox.TabIndex = 11;
            this.lacquerColorComboBox.SelectedIndexChanged += new System.EventHandler(this.lacquerColorComboBox_SelectedIndexChanged);
            // 
            // additionalOptionsCheckedListBox
            // 
            this.additionalOptionsCheckedListBox.FormattingEnabled = true;
            this.additionalOptionsCheckedListBox.Items.AddRange(new object[] {
            "Automatyczna skrzynia biegów",
            "Klimatyzacja",
            "Wspomaganie"});
            this.additionalOptionsCheckedListBox.Location = new System.Drawing.Point(28, 94);
            this.additionalOptionsCheckedListBox.Name = "additionalOptionsCheckedListBox";
            this.additionalOptionsCheckedListBox.Size = new System.Drawing.Size(132, 49);
            this.additionalOptionsCheckedListBox.TabIndex = 15;
            this.additionalOptionsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.additionalOptionsCheckedListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Opcje dodatkowe:";
            // 
            // carAvatarPB
            // 
            this.carAvatarPB.Location = new System.Drawing.Point(646, 94);
            this.carAvatarPB.Name = "carAvatarPB";
            this.carAvatarPB.Size = new System.Drawing.Size(100, 50);
            this.carAvatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carAvatarPB.TabIndex = 16;
            this.carAvatarPB.TabStop = false;
            // 
            // carAvatarLabel
            // 
            this.carAvatarLabel.AutoSize = true;
            this.carAvatarLabel.Location = new System.Drawing.Point(646, 75);
            this.carAvatarLabel.Name = "carAvatarLabel";
            this.carAvatarLabel.Size = new System.Drawing.Size(59, 13);
            this.carAvatarLabel.TabIndex = 17;
            this.carAvatarLabel.Text = "Miniaturka:";
            // 
            // addEntryLabel
            // 
            this.addEntryLabel.AutoSize = true;
            this.addEntryLabel.Location = new System.Drawing.Point(25, 300);
            this.addEntryLabel.Name = "addEntryLabel";
            this.addEntryLabel.Size = new System.Drawing.Size(59, 13);
            this.addEntryLabel.TabIndex = 18;
            this.addEntryLabel.Text = "Dodaj wpis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kolor lakieru:";
            // 
            // addMetalicLacquerCheckBox
            // 
            this.addMetalicLacquerCheckBox.AutoSize = true;
            this.addMetalicLacquerCheckBox.Location = new System.Drawing.Point(412, 338);
            this.addMetalicLacquerCheckBox.Name = "addMetalicLacquerCheckBox";
            this.addMetalicLacquerCheckBox.Size = new System.Drawing.Size(91, 17);
            this.addMetalicLacquerCheckBox.TabIndex = 25;
            this.addMetalicLacquerCheckBox.Text = "Lakier metalik";
            this.addMetalicLacquerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Silnik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Marka samochodu:";
            // 
            // addBrandTextBox
            // 
            this.addBrandTextBox.Location = new System.Drawing.Point(28, 340);
            this.addBrandTextBox.Name = "addBrandTextBox";
            this.addBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.addBrandTextBox.TabIndex = 28;
            // 
            // addModelTextBox
            // 
            this.addModelTextBox.Location = new System.Drawing.Point(155, 340);
            this.addModelTextBox.Name = "addModelTextBox";
            this.addModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.addModelTextBox.TabIndex = 29;
            // 
            // addEngineTextBox
            // 
            this.addEngineTextBox.Location = new System.Drawing.Point(288, 340);
            this.addEngineTextBox.Name = "addEngineTextBox";
            this.addEngineTextBox.Size = new System.Drawing.Size(100, 20);
            this.addEngineTextBox.TabIndex = 30;
            // 
            // addLacquerTextBox
            // 
            this.addLacquerTextBox.Location = new System.Drawing.Point(509, 340);
            this.addLacquerTextBox.Name = "addLacquerTextBox";
            this.addLacquerTextBox.Size = new System.Drawing.Size(100, 20);
            this.addLacquerTextBox.TabIndex = 31;
            // 
            // samochodyTableAdapter
            // 
            this.samochodyTableAdapter.ClearBeforeFill = true;
            // 
            // addNewCarButton
            // 
            this.addNewCarButton.Location = new System.Drawing.Point(615, 340);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.Size = new System.Drawing.Size(75, 23);
            this.addNewCarButton.TabIndex = 33;
            this.addNewCarButton.Text = "Dodaj nowy samochod";
            this.addNewCarButton.UseVisualStyleBackColor = true;
            this.addNewCarButton.Click += new System.EventHandler(this.addNewCarButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(702, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(702, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Architektura procesora:";
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.AutoGenerateColumns = false;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carengineDataGridViewTextBoxColumn,
            this.productionyearDataGridViewTextBoxColumn,
            this.lacquercolorDataGridViewTextBoxColumn,
            this.hasmetalliclacquerDataGridViewCheckBoxColumn,
            this.haspowersteeringDataGridViewCheckBoxColumn,
            this.hasautomatictransmissionDataGridViewCheckBoxColumn,
            this.hasairconditioningDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.mainDataGridView.DataSource = this.cars1BindingSource;
            this.mainDataGridView.Location = new System.Drawing.Point(28, 159);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(791, 129);
            this.mainDataGridView.TabIndex = 36;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carengineDataGridViewTextBoxColumn
            // 
            this.carengineDataGridViewTextBoxColumn.DataPropertyName = "car_engine";
            this.carengineDataGridViewTextBoxColumn.HeaderText = "car_engine";
            this.carengineDataGridViewTextBoxColumn.Name = "carengineDataGridViewTextBoxColumn";
            this.carengineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionyearDataGridViewTextBoxColumn
            // 
            this.productionyearDataGridViewTextBoxColumn.DataPropertyName = "production_year";
            this.productionyearDataGridViewTextBoxColumn.HeaderText = "production_year";
            this.productionyearDataGridViewTextBoxColumn.Name = "productionyearDataGridViewTextBoxColumn";
            this.productionyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lacquercolorDataGridViewTextBoxColumn
            // 
            this.lacquercolorDataGridViewTextBoxColumn.DataPropertyName = "lacquer_color";
            this.lacquercolorDataGridViewTextBoxColumn.HeaderText = "lacquer_color";
            this.lacquercolorDataGridViewTextBoxColumn.Name = "lacquercolorDataGridViewTextBoxColumn";
            this.lacquercolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasmetalliclacquerDataGridViewCheckBoxColumn
            // 
            this.hasmetalliclacquerDataGridViewCheckBoxColumn.DataPropertyName = "has_metallic_lacquer";
            this.hasmetalliclacquerDataGridViewCheckBoxColumn.HeaderText = "has_metallic_lacquer";
            this.hasmetalliclacquerDataGridViewCheckBoxColumn.Name = "hasmetalliclacquerDataGridViewCheckBoxColumn";
            this.hasmetalliclacquerDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // haspowersteeringDataGridViewCheckBoxColumn
            // 
            this.haspowersteeringDataGridViewCheckBoxColumn.DataPropertyName = "has_power_steering";
            this.haspowersteeringDataGridViewCheckBoxColumn.HeaderText = "has_power_steering";
            this.haspowersteeringDataGridViewCheckBoxColumn.Name = "haspowersteeringDataGridViewCheckBoxColumn";
            this.haspowersteeringDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // hasautomatictransmissionDataGridViewCheckBoxColumn
            // 
            this.hasautomatictransmissionDataGridViewCheckBoxColumn.DataPropertyName = "has_automatic_transmission";
            this.hasautomatictransmissionDataGridViewCheckBoxColumn.HeaderText = "has_automatic_transmission";
            this.hasautomatictransmissionDataGridViewCheckBoxColumn.Name = "hasautomatictransmissionDataGridViewCheckBoxColumn";
            this.hasautomatictransmissionDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // hasairconditioningDataGridViewCheckBoxColumn
            // 
            this.hasairconditioningDataGridViewCheckBoxColumn.DataPropertyName = "has_air_conditioning";
            this.hasairconditioningDataGridViewCheckBoxColumn.HeaderText = "has_air_conditioning";
            this.hasairconditioningDataGridViewCheckBoxColumn.Name = "hasairconditioningDataGridViewCheckBoxColumn";
            this.hasairconditioningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDealer2DataSet
            // 
            this.carDealer2DataSet.DataSetName = "carDealer2DataSet";
            this.carDealer2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cars2TableAdapter
            // 
            this.cars2TableAdapter.ClearBeforeFill = true;
            // 
            // fillByModelToolStrip
            // 
            this.fillByModelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripLabel,
            this.modelToolStripTextBox,
            this.fillByModelToolStripButton});
            this.fillByModelToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByModelToolStrip.Name = "fillByModelToolStrip";
            this.fillByModelToolStrip.Size = new System.Drawing.Size(839, 25);
            this.fillByModelToolStrip.TabIndex = 38;
            this.fillByModelToolStrip.Text = "fillByModelToolStrip";
            this.fillByModelToolStrip.Visible = false;
            // 
            // modelToolStripLabel
            // 
            this.modelToolStripLabel.Name = "modelToolStripLabel";
            this.modelToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.modelToolStripLabel.Text = "model:";
            // 
            // modelToolStripTextBox
            // 
            this.modelToolStripTextBox.Name = "modelToolStripTextBox";
            this.modelToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByModelToolStripButton
            // 
            this.fillByModelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByModelToolStripButton.Name = "fillByModelToolStripButton";
            this.fillByModelToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.fillByModelToolStripButton.Text = "FillByModel";
            this.fillByModelToolStripButton.Click += new System.EventHandler(this.fillByModelToolStripButton_Click);
            // 
            // fillByEngineToolStrip
            // 
            this.fillByEngineToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.car_engineToolStripLabel,
            this.car_engineToolStripTextBox,
            this.fillByEngineToolStripButton});
            this.fillByEngineToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByEngineToolStrip.Name = "fillByEngineToolStrip";
            this.fillByEngineToolStrip.Size = new System.Drawing.Size(839, 25);
            this.fillByEngineToolStrip.TabIndex = 39;
            this.fillByEngineToolStrip.Text = "fillByEngineToolStrip";
            // 
            // car_engineToolStripLabel
            // 
            this.car_engineToolStripLabel.Name = "car_engineToolStripLabel";
            this.car_engineToolStripLabel.Size = new System.Drawing.Size(67, 22);
            this.car_engineToolStripLabel.Text = "car_engine:";
            // 
            // car_engineToolStripTextBox
            // 
            this.car_engineToolStripTextBox.Name = "car_engineToolStripTextBox";
            this.car_engineToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByEngineToolStripButton
            // 
            this.fillByEngineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEngineToolStripButton.Name = "fillByEngineToolStripButton";
            this.fillByEngineToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.fillByEngineToolStripButton.Text = "FillByEngine";
            this.fillByEngineToolStripButton.Click += new System.EventHandler(this.fillByEngineToolStripButton_Click);
            // 
            // fillByModelEngineToolStrip
            // 
            this.fillByModelEngineToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripLabel1,
            this.modelToolStripTextBox1,
            this.car_engineToolStripLabel1,
            this.car_engineToolStripTextBox1,
            this.fillByModelEngineToolStripButton});
            this.fillByModelEngineToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByModelEngineToolStrip.Name = "fillByModelEngineToolStrip";
            this.fillByModelEngineToolStrip.Size = new System.Drawing.Size(839, 25);
            this.fillByModelEngineToolStrip.TabIndex = 40;
            this.fillByModelEngineToolStrip.Text = "fillByModelEngineToolStrip";
            this.fillByModelEngineToolStrip.Visible = false;
            // 
            // modelToolStripLabel1
            // 
            this.modelToolStripLabel1.Name = "modelToolStripLabel1";
            this.modelToolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.modelToolStripLabel1.Text = "model:";
            // 
            // modelToolStripTextBox1
            // 
            this.modelToolStripTextBox1.Name = "modelToolStripTextBox1";
            this.modelToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // car_engineToolStripLabel1
            // 
            this.car_engineToolStripLabel1.Name = "car_engineToolStripLabel1";
            this.car_engineToolStripLabel1.Size = new System.Drawing.Size(67, 22);
            this.car_engineToolStripLabel1.Text = "car_engine:";
            // 
            // car_engineToolStripTextBox1
            // 
            this.car_engineToolStripTextBox1.Name = "car_engineToolStripTextBox1";
            this.car_engineToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByModelEngineToolStripButton
            // 
            this.fillByModelEngineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByModelEngineToolStripButton.Name = "fillByModelEngineToolStripButton";
            this.fillByModelEngineToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.fillByModelEngineToolStripButton.Text = "FillByModelEngine";
            this.fillByModelEngineToolStripButton.Click += new System.EventHandler(this.fillByModelEngineToolStripButton_Click);
            // 
            // cars1TableAdapter
            // 
            this.cars1TableAdapter.ClearBeforeFill = true;
            // 
            // fillByProductionYearToolStrip
            // 
            this.fillByProductionYearToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.production_yearToolStripLabel,
            this.production_yearToolStripTextBox,
            this.fillByProductionYearToolStripButton});
            this.fillByProductionYearToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillByProductionYearToolStrip.Name = "fillByProductionYearToolStrip";
            this.fillByProductionYearToolStrip.Size = new System.Drawing.Size(839, 25);
            this.fillByProductionYearToolStrip.TabIndex = 41;
            this.fillByProductionYearToolStrip.Text = "fillByProductionYearToolStrip";
            this.fillByProductionYearToolStrip.Visible = false;
            // 
            // production_yearToolStripLabel
            // 
            this.production_yearToolStripLabel.Name = "production_yearToolStripLabel";
            this.production_yearToolStripLabel.Size = new System.Drawing.Size(96, 22);
            this.production_yearToolStripLabel.Text = "production_year:";
            // 
            // production_yearToolStripTextBox
            // 
            this.production_yearToolStripTextBox.Name = "production_yearToolStripTextBox";
            this.production_yearToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByProductionYearToolStripButton
            // 
            this.fillByProductionYearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByProductionYearToolStripButton.Name = "fillByProductionYearToolStripButton";
            this.fillByProductionYearToolStripButton.Size = new System.Drawing.Size(120, 22);
            this.fillByProductionYearToolStripButton.Text = "FillByProductionYear";
            this.fillByProductionYearToolStripButton.Click += new System.EventHandler(this.fillByProductionYearToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.fillByProductionYearToolStrip);
            this.Controls.Add(this.fillByModelEngineToolStrip);
            this.Controls.Add(this.fillByEngineToolStrip);
            this.Controls.Add(this.fillByModelToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addNewCarButton);
            this.Controls.Add(this.addLacquerTextBox);
            this.Controls.Add(this.addEngineTextBox);
            this.Controls.Add(this.addModelTextBox);
            this.Controls.Add(this.addBrandTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addMetalicLacquerCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addEntryLabel);
            this.Controls.Add(this.carAvatarLabel);
            this.Controls.Add(this.carAvatarPB);
            this.Controls.Add(this.additionalOptionsCheckedListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lacquerColorComboBox);
            this.Controls.Add(this.isMetallicLacquerCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.engineComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.carBrandComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cars1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer2DataSet)).EndInit();
            this.fillByModelToolStrip.ResumeLayout(false);
            this.fillByModelToolStrip.PerformLayout();
            this.fillByEngineToolStrip.ResumeLayout(false);
            this.fillByEngineToolStrip.PerformLayout();
            this.fillByModelEngineToolStrip.ResumeLayout(false);
            this.fillByModelEngineToolStrip.PerformLayout();
            this.fillByProductionYearToolStrip.ResumeLayout(false);
            this.fillByProductionYearToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox carBrandComboBox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox engineComboBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox carModelComboBox;
        internal System.Windows.Forms.CheckBox isMetallicLacquerCheckBox;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox lacquerColorComboBox;
        internal System.Windows.Forms.CheckedListBox additionalOptionsCheckedListBox;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox carAvatarPB;
        private System.Windows.Forms.Label carAvatarLabel;
        private System.Windows.Forms.Label addEntryLabel;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox addMetalicLacquerCheckBox;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addBrandTextBox;
        private System.Windows.Forms.TextBox addModelTextBox;
        private System.Windows.Forms.TextBox addEngineTextBox;
        private System.Windows.Forms.TextBox addLacquerTextBox;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private car_dealer_dbDataSet carDealerDataSet;
        private car_dealer_dbDataSetTableAdapters.samochodyTableAdapter samochodyTableAdapter;
        private System.Windows.Forms.Button addNewCarButton;
        private CompInfo.Computer computer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource cars1BindingSource;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private carDealer1DataSet carDealer1DataSet;
        private carDealer2DataSet carDealer2DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carengineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lacquercolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasmetalliclacquerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn haspowersteeringDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasautomatictransmissionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasairconditioningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private carDealer1DataSetTableAdapters.carsTableAdapter cars1TableAdapter;
        private System.Windows.Forms.Button button1;
        private carDealer2DataSetTableAdapters.carsTableAdapter cars2TableAdapter;
        private System.Windows.Forms.ToolStrip fillByModelToolStrip;
        private System.Windows.Forms.ToolStripLabel modelToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox modelToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByModelToolStripButton;
        private System.Windows.Forms.ToolStrip fillByEngineToolStrip;
        private System.Windows.Forms.ToolStripLabel car_engineToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox car_engineToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByEngineToolStripButton;
        private System.Windows.Forms.ToolStrip fillByModelEngineToolStrip;
        private System.Windows.Forms.ToolStripLabel modelToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox modelToolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel car_engineToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox car_engineToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByModelEngineToolStripButton;
        private System.Windows.Forms.ToolStrip fillByProductionYearToolStrip;
        private System.Windows.Forms.ToolStripLabel production_yearToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox production_yearToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByProductionYearToolStripButton;
    }
}

