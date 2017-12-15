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
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).BeginInit();
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
            this.carBrandComboBox.DataSource = this.carsBindingSource;
            this.carBrandComboBox.DisplayMember = "marka";
            this.carBrandComboBox.FormattingEnabled = true;
            this.carBrandComboBox.Location = new System.Drawing.Point(28, 45);
            this.carBrandComboBox.Name = "carBrandComboBox";
            this.carBrandComboBox.Size = new System.Drawing.Size(121, 21);
            this.carBrandComboBox.TabIndex = 3;
            this.carBrandComboBox.Text = "wybierz markę...";
            this.carBrandComboBox.SelectedIndexChanged += new System.EventHandler(this.carBrandComboBox_SelectedIndexChanged);
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
            this.engineComboBox.Text = "wybierz silnik";
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
            this.carModelComboBox.DataSource = this.carsBindingSource;
            this.carModelComboBox.DisplayMember = "model";
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(158, 44);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.carModelComboBox.TabIndex = 6;
            this.carModelComboBox.Text = "wybierz model...";
            this.carModelComboBox.SelectedIndexChanged += new System.EventHandler(this.carModelComboBox_SelectedIndexChanged);
            // 
            // isMetallicLacquerCheckBox
            // 
            this.isMetallicLacquerCheckBox.AutoSize = true;
            this.isMetallicLacquerCheckBox.Location = new System.Drawing.Point(412, 44);
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
            this.lacquerColorComboBox.Text = "wybierz kolor";
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
            this.addEntryLabel.Location = new System.Drawing.Point(28, 175);
            this.addEntryLabel.Name = "addEntryLabel";
            this.addEntryLabel.Size = new System.Drawing.Size(59, 13);
            this.addEntryLabel.TabIndex = 18;
            this.addEntryLabel.Text = "Dodaj wpis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kolor lakieru:";
            // 
            // addMetalicLacquerCheckBox
            // 
            this.addMetalicLacquerCheckBox.AutoSize = true;
            this.addMetalicLacquerCheckBox.Location = new System.Drawing.Point(415, 213);
            this.addMetalicLacquerCheckBox.Name = "addMetalicLacquerCheckBox";
            this.addMetalicLacquerCheckBox.Size = new System.Drawing.Size(91, 17);
            this.addMetalicLacquerCheckBox.TabIndex = 25;
            this.addMetalicLacquerCheckBox.Text = "Lakier metalik";
            this.addMetalicLacquerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Silnik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Marka samochodu:";
            // 
            // addBrandTextBox
            // 
            this.addBrandTextBox.Location = new System.Drawing.Point(31, 215);
            this.addBrandTextBox.Name = "addBrandTextBox";
            this.addBrandTextBox.Size = new System.Drawing.Size(100, 20);
            this.addBrandTextBox.TabIndex = 28;
            // 
            // addModelTextBox
            // 
            this.addModelTextBox.Location = new System.Drawing.Point(158, 215);
            this.addModelTextBox.Name = "addModelTextBox";
            this.addModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.addModelTextBox.TabIndex = 29;
            // 
            // addEngineTextBox
            // 
            this.addEngineTextBox.Location = new System.Drawing.Point(291, 215);
            this.addEngineTextBox.Name = "addEngineTextBox";
            this.addEngineTextBox.Size = new System.Drawing.Size(100, 20);
            this.addEngineTextBox.TabIndex = 30;
            // 
            // addLacquerTextBox
            // 
            this.addLacquerTextBox.Location = new System.Drawing.Point(512, 215);
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
            this.addNewCarButton.Location = new System.Drawing.Point(618, 215);
            this.addNewCarButton.Name = "addNewCarButton";
            this.addNewCarButton.Size = new System.Drawing.Size(75, 23);
            this.addNewCarButton.TabIndex = 33;
            this.addNewCarButton.Text = "Dodaj nowy samochod";
            this.addNewCarButton.UseVisualStyleBackColor = true;
            this.addNewCarButton.Click += new System.EventHandler(this.addNewCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 323);
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
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carAvatarPB)).EndInit();
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
    }
}

