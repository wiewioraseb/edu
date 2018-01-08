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
            this.label5 = new System.Windows.Forms.Label();
            this.carAvatarLabel = new System.Windows.Forms.Label();
            this.samochodyTableAdapter = new CarDealer.car_dealer_dbDataSetTableAdapters.samochodyTableAdapter();
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
            this.cars1TableAdapter = new CarDealer.carDealer1DataSetTableAdapters.carsTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.cars2TableAdapter = new CarDealer.carDealer2DataSetTableAdapters.carsTableAdapter();
            this.pickDbComboBox = new System.Windows.Forms.ComboBox();
            this.automaticTransmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.airConditionCheckBox = new System.Windows.Forms.CheckBox();
            this.powerSteeringCheckBox = new System.Windows.Forms.CheckBox();
            this.carAvatarPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.showLoginButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.loggedInUserLabel = new System.Windows.Forms.Label();
            this.newCarPanel = new System.Windows.Forms.Panel();
            this.addNewCarButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProdYearTextBox = new System.Windows.Forms.TextBox();
            this.addLacquerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPowerSteeringCheckBox = new System.Windows.Forms.CheckBox();
            this.addAirConditionCheckBox = new System.Windows.Forms.CheckBox();
            this.addAutomaticTransmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addEngineTextBox = new System.Windows.Forms.TextBox();
            this.addModelTextBox = new System.Windows.Forms.TextBox();
            this.addBrandTextBox = new System.Windows.Forms.TextBox();
            this.addMetalicLacquerCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addEntryLabel = new System.Windows.Forms.Label();
            this.rateCarController = new RateCar.RateCarController();
            ((System.ComponentModel.ISupportInitialize)(this.cars1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).BeginInit();
            this.newCarPanel.SuspendLayout();
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
            this.lacquerColorComboBox.FormattingEnabled = true;
            this.lacquerColorComboBox.Location = new System.Drawing.Point(509, 44);
            this.lacquerColorComboBox.Name = "lacquerColorComboBox";
            this.lacquerColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.lacquerColorComboBox.TabIndex = 11;
            this.lacquerColorComboBox.SelectedIndexChanged += new System.EventHandler(this.lacquerColorComboBox_SelectedIndexChanged);
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
            // carAvatarLabel
            // 
            this.carAvatarLabel.AutoSize = true;
            this.carAvatarLabel.Location = new System.Drawing.Point(717, 94);
            this.carAvatarLabel.Name = "carAvatarLabel";
            this.carAvatarLabel.Size = new System.Drawing.Size(59, 13);
            this.carAvatarLabel.TabIndex = 17;
            this.carAvatarLabel.Text = "Miniaturka:";
            // 
            // samochodyTableAdapter
            // 
            this.samochodyTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(748, 515);
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
            this.mainDataGridView.Location = new System.Drawing.Point(28, 172);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.Size = new System.Drawing.Size(791, 175);
            this.mainDataGridView.TabIndex = 36;
            this.mainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDataGridView_CellContentClick);
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
            // cars1TableAdapter
            // 
            this.cars1TableAdapter.ClearBeforeFill = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(636, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cars2TableAdapter
            // 
            this.cars2TableAdapter.ClearBeforeFill = true;
            // 
            // pickDbComboBox
            // 
            this.pickDbComboBox.FormattingEnabled = true;
            this.pickDbComboBox.Location = new System.Drawing.Point(655, 12);
            this.pickDbComboBox.Name = "pickDbComboBox";
            this.pickDbComboBox.Size = new System.Drawing.Size(121, 21);
            this.pickDbComboBox.TabIndex = 38;
            this.pickDbComboBox.Text = "Komis";
            this.pickDbComboBox.SelectedIndexChanged += new System.EventHandler(this.pickDbComboBox_SelectedIndexChanged);
            // 
            // automaticTransmissionCheckBox
            // 
            this.automaticTransmissionCheckBox.AutoSize = true;
            this.automaticTransmissionCheckBox.Location = new System.Drawing.Point(28, 117);
            this.automaticTransmissionCheckBox.Name = "automaticTransmissionCheckBox";
            this.automaticTransmissionCheckBox.Size = new System.Drawing.Size(134, 17);
            this.automaticTransmissionCheckBox.TabIndex = 39;
            this.automaticTransmissionCheckBox.Text = "Automatyczna skrzynia";
            this.automaticTransmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // airConditionCheckBox
            // 
            this.airConditionCheckBox.AutoSize = true;
            this.airConditionCheckBox.Location = new System.Drawing.Point(28, 140);
            this.airConditionCheckBox.Name = "airConditionCheckBox";
            this.airConditionCheckBox.Size = new System.Drawing.Size(84, 17);
            this.airConditionCheckBox.TabIndex = 40;
            this.airConditionCheckBox.Text = "Klimatyzacja";
            this.airConditionCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerSteeringCheckBox
            // 
            this.powerSteeringCheckBox.AutoSize = true;
            this.powerSteeringCheckBox.Location = new System.Drawing.Point(28, 94);
            this.powerSteeringCheckBox.Name = "powerSteeringCheckBox";
            this.powerSteeringCheckBox.Size = new System.Drawing.Size(94, 17);
            this.powerSteeringCheckBox.TabIndex = 41;
            this.powerSteeringCheckBox.Text = "Wspomaganie";
            this.powerSteeringCheckBox.UseVisualStyleBackColor = true;
            // 
            // carAvatarPB
            // 
            this.carAvatarPB.Location = new System.Drawing.Point(717, 113);
            this.carAvatarPB.Name = "carAvatarPB";
            this.carAvatarPB.Size = new System.Drawing.Size(100, 50);
            this.carAvatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carAvatarPB.TabIndex = 16;
            this.carAvatarPB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 811);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Dodaj nowy samochod";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // showLoginButton
            // 
            this.showLoginButton.Location = new System.Drawing.Point(782, 10);
            this.showLoginButton.Name = "showLoginButton";
            this.showLoginButton.Size = new System.Drawing.Size(75, 23);
            this.showLoginButton.TabIndex = 51;
            this.showLoginButton.Text = "Logowanie";
            this.showLoginButton.UseVisualStyleBackColor = true;
            this.showLoginButton.Click += new System.EventHandler(this.showLoginButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Zalogowany jako:";
            // 
            // loggedInUserLabel
            // 
            this.loggedInUserLabel.AutoSize = true;
            this.loggedInUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loggedInUserLabel.Location = new System.Drawing.Point(403, 1);
            this.loggedInUserLabel.Name = "loggedInUserLabel";
            this.loggedInUserLabel.Size = new System.Drawing.Size(36, 13);
            this.loggedInUserLabel.TabIndex = 53;
            this.loggedInUserLabel.Text = "Gość";
            // 
            // newCarPanel
            // 
            this.newCarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCarPanel.Controls.Add(this.addNewCarButton);
            this.newCarPanel.Controls.Add(this.label14);
            this.newCarPanel.Controls.Add(this.label13);
            this.newCarPanel.Controls.Add(this.addPriceTextBox);
            this.newCarPanel.Controls.Add(this.addProdYearTextBox);
            this.newCarPanel.Controls.Add(this.addLacquerTextBox);
            this.newCarPanel.Controls.Add(this.label6);
            this.newCarPanel.Controls.Add(this.addPowerSteeringCheckBox);
            this.newCarPanel.Controls.Add(this.addAirConditionCheckBox);
            this.newCarPanel.Controls.Add(this.addAutomaticTransmissionCheckBox);
            this.newCarPanel.Controls.Add(this.label12);
            this.newCarPanel.Controls.Add(this.addEngineTextBox);
            this.newCarPanel.Controls.Add(this.addModelTextBox);
            this.newCarPanel.Controls.Add(this.addBrandTextBox);
            this.newCarPanel.Controls.Add(this.addMetalicLacquerCheckBox);
            this.newCarPanel.Controls.Add(this.label7);
            this.newCarPanel.Controls.Add(this.label8);
            this.newCarPanel.Controls.Add(this.label9);
            this.newCarPanel.Controls.Add(this.addEntryLabel);
            this.newCarPanel.Location = new System.Drawing.Point(12, 353);
            this.newCarPanel.Name = "newCarPanel";
            this.newCarPanel.Size = new System.Drawing.Size(845, 159);
            this.newCarPanel.TabIndex = 54;
            // 
            // addNewCarButton
            // 
            this.addNewCarButton.Location = new System.Drawing.Point(330, 126);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.Size = new System.Drawing.Size(75, 23);
            this.addNewCarButton.TabIndex = 65;
            this.addNewCarButton.Text = "Dodaj nowy samochod";
            this.addNewCarButton.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(732, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Cena";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(615, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Rok produkcji";
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(732, 47);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.addPriceTextBox.TabIndex = 62;
            // 
            // addProdYearTextBox
            // 
            this.addProdYearTextBox.Location = new System.Drawing.Point(618, 48);
            this.addProdYearTextBox.Name = "addProdYearTextBox";
            this.addProdYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProdYearTextBox.TabIndex = 61;
            // 
            // addLacquerTextBox
            // 
            this.addLacquerTextBox.Location = new System.Drawing.Point(497, 48);
            this.addLacquerTextBox.Name = "addLacquerTextBox";
            this.addLacquerTextBox.Size = new System.Drawing.Size(100, 20);
            this.addLacquerTextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Kolor lakieru:";
            // 
            // addPowerSteeringCheckBox
            // 
            this.addPowerSteeringCheckBox.AutoSize = true;
            this.addPowerSteeringCheckBox.Location = new System.Drawing.Point(22, 91);
            this.addPowerSteeringCheckBox.Name = "addPowerSteeringCheckBox";
            this.addPowerSteeringCheckBox.Size = new System.Drawing.Size(94, 17);
            this.addPowerSteeringCheckBox.TabIndex = 58;
            this.addPowerSteeringCheckBox.Text = "Wspomaganie";
            this.addPowerSteeringCheckBox.UseVisualStyleBackColor = true;
            // 
            // addAirConditionCheckBox
            // 
            this.addAirConditionCheckBox.AutoSize = true;
            this.addAirConditionCheckBox.Location = new System.Drawing.Point(22, 137);
            this.addAirConditionCheckBox.Name = "addAirConditionCheckBox";
            this.addAirConditionCheckBox.Size = new System.Drawing.Size(84, 17);
            this.addAirConditionCheckBox.TabIndex = 57;
            this.addAirConditionCheckBox.Text = "Klimatyzacja";
            this.addAirConditionCheckBox.UseVisualStyleBackColor = true;
            // 
            // addAutomaticTransmissionCheckBox
            // 
            this.addAutomaticTransmissionCheckBox.AutoSize = true;
            this.addAutomaticTransmissionCheckBox.Location = new System.Drawing.Point(22, 114);
            this.addAutomaticTransmissionCheckBox.Name = "addAutomaticTransmissionCheckBox";
            this.addAutomaticTransmissionCheckBox.Size = new System.Drawing.Size(134, 17);
            this.addAutomaticTransmissionCheckBox.TabIndex = 56;
            this.addAutomaticTransmissionCheckBox.Text = "Automatyczna skrzynia";
            this.addAutomaticTransmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Opcje dodatkowe:";
            // 
            // addEngineTextBox
            // 
            this.addEngineTextBox.Location = new System.Drawing.Point(276, 48);
            this.addEngineTextBox.Name = "addEngineTextBox";
            this.addEngineTextBox.Size = new System.Drawing.Size(100, 20);
            this.addEngineTextBox.TabIndex = 54;
            // 
            // addModelTextBox
            // 
            this.addModelTextBox.Location = new System.Drawing.Point(143, 48);
            this.addModelTextBox.Name = "addModelTextBox";
            this.addModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.addModelTextBox.TabIndex = 53;
            // 
            // addBrandTextBox
            // 
            this.addBrandTextBox.Location = new System.Drawing.Point(16, 48);
            this.addBrandTextBox.Name = "addBrandTextBox";
            this.addBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.addBrandTextBox.TabIndex = 52;
            // 
            // addMetalicLacquerCheckBox
            // 
            this.addMetalicLacquerCheckBox.AutoSize = true;
            this.addMetalicLacquerCheckBox.Location = new System.Drawing.Point(400, 46);
            this.addMetalicLacquerCheckBox.Name = "addMetalicLacquerCheckBox";
            this.addMetalicLacquerCheckBox.Size = new System.Drawing.Size(91, 17);
            this.addMetalicLacquerCheckBox.TabIndex = 51;
            this.addMetalicLacquerCheckBox.Text = "Lakier metalik";
            this.addMetalicLacquerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Silnik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Marka samochodu:";
            // 
            // addEntryLabel
            // 
            this.addEntryLabel.AutoSize = true;
            this.addEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addEntryLabel.Location = new System.Drawing.Point(13, 8);
            this.addEntryLabel.Name = "addEntryLabel";
            this.addEntryLabel.Size = new System.Drawing.Size(138, 13);
            this.addEntryLabel.TabIndex = 47;
            this.addEntryLabel.Text = "Dodaj nowy samochód:";
            // 
            // rateCarController
            // 
            this.rateCarController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateCarController.Location = new System.Drawing.Point(834, 62);
            this.rateCarController.Name = "rateCarController";
            this.rateCarController.Size = new System.Drawing.Size(248, 290);
            this.rateCarController.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 544);
            this.Controls.Add(this.rateCarController);
            this.Controls.Add(this.newCarPanel);
            this.Controls.Add(this.loggedInUserLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.showLoginButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powerSteeringCheckBox);
            this.Controls.Add(this.airConditionCheckBox);
            this.Controls.Add(this.automaticTransmissionCheckBox);
            this.Controls.Add(this.pickDbComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mainDataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.carAvatarLabel);
            this.Controls.Add(this.carAvatarPB);
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
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealer2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).EndInit();
            this.newCarPanel.ResumeLayout(false);
            this.newCarPanel.PerformLayout();
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
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox carAvatarPB;
        private System.Windows.Forms.Label carAvatarLabel;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private car_dealer_dbDataSet carDealerDataSet;
        private car_dealer_dbDataSetTableAdapters.samochodyTableAdapter samochodyTableAdapter;
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
        private System.Windows.Forms.Button searchButton;
        private carDealer2DataSetTableAdapters.carsTableAdapter cars2TableAdapter;
        private System.Windows.Forms.ComboBox pickDbComboBox;
        private System.Windows.Forms.CheckBox automaticTransmissionCheckBox;
        private System.Windows.Forms.CheckBox airConditionCheckBox;
        private System.Windows.Forms.CheckBox powerSteeringCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showLoginButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label loggedInUserLabel;
        private System.Windows.Forms.Panel newCarPanel;
        private System.Windows.Forms.Button addNewCarButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.TextBox addProdYearTextBox;
        private System.Windows.Forms.TextBox addLacquerTextBox;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox addPowerSteeringCheckBox;
        private System.Windows.Forms.CheckBox addAirConditionCheckBox;
        private System.Windows.Forms.CheckBox addAutomaticTransmissionCheckBox;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addEngineTextBox;
        private System.Windows.Forms.TextBox addModelTextBox;
        private System.Windows.Forms.TextBox addBrandTextBox;
        internal System.Windows.Forms.CheckBox addMetalicLacquerCheckBox;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label addEntryLabel;
        private RateCar.RateCarController rateCarController;
    }
}

