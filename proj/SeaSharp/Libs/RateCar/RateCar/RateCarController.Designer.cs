namespace RateCar
{
    partial class RateCarController
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.giveRateComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.threeRatedCarDataGridView = new System.Windows.Forms.DataGridView();
            this.showBest3Button = new System.Windows.Forms.Button();
            this.best3Label = new System.Windows.Forms.Label();
            this.ratedCarIdCB = new System.Windows.Forms.ComboBox();
            this.ratedCarBrandCB = new System.Windows.Forms.ComboBox();
            this.ratedCarModelCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.threeRatedCarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oceń samochód";
            // 
            // giveRateComboBox
            // 
            this.giveRateComboBox.FormattingEnabled = true;
            this.giveRateComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.giveRateComboBox.Location = new System.Drawing.Point(96, 74);
            this.giveRateComboBox.Name = "giveRateComboBox";
            this.giveRateComboBox.Size = new System.Drawing.Size(41, 21);
            this.giveRateComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ocena:";
            // 
            // threeRatedCarDataGridView
            // 
            this.threeRatedCarDataGridView.AllowUserToAddRows = false;
            this.threeRatedCarDataGridView.AllowUserToDeleteRows = false;
            this.threeRatedCarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threeRatedCarDataGridView.Location = new System.Drawing.Point(3, 119);
            this.threeRatedCarDataGridView.Name = "threeRatedCarDataGridView";
            this.threeRatedCarDataGridView.ReadOnly = true;
            this.threeRatedCarDataGridView.Size = new System.Drawing.Size(239, 138);
            this.threeRatedCarDataGridView.TabIndex = 9;
            // 
            // showBest3Button
            // 
            this.showBest3Button.Location = new System.Drawing.Point(92, 263);
            this.showBest3Button.Name = "showBest3Button";
            this.showBest3Button.Size = new System.Drawing.Size(153, 23);
            this.showBest3Button.TabIndex = 10;
            this.showBest3Button.Text = "Pokaz najczesciej oceniane";
            this.showBest3Button.UseVisualStyleBackColor = true;
            this.showBest3Button.Click += new System.EventHandler(this.showBest3Button_Click);
            // 
            // best3Label
            // 
            this.best3Label.AutoSize = true;
            this.best3Label.Location = new System.Drawing.Point(4, 100);
            this.best3Label.Name = "best3Label";
            this.best3Label.Size = new System.Drawing.Size(99, 13);
            this.best3Label.TabIndex = 11;
            this.best3Label.Text = "Najwyzej oceniane:";
            // 
            // ratedCarIdCB
            // 
            this.ratedCarIdCB.FormattingEnabled = true;
            this.ratedCarIdCB.Location = new System.Drawing.Point(3, 46);
            this.ratedCarIdCB.Name = "ratedCarIdCB";
            this.ratedCarIdCB.Size = new System.Drawing.Size(39, 21);
            this.ratedCarIdCB.TabIndex = 12;
            // 
            // ratedCarBrandCB
            // 
            this.ratedCarBrandCB.FormattingEnabled = true;
            this.ratedCarBrandCB.Location = new System.Drawing.Point(49, 46);
            this.ratedCarBrandCB.Name = "ratedCarBrandCB";
            this.ratedCarBrandCB.Size = new System.Drawing.Size(88, 21);
            this.ratedCarBrandCB.TabIndex = 13;
            // 
            // ratedCarModelCB
            // 
            this.ratedCarModelCB.FormattingEnabled = true;
            this.ratedCarModelCB.Location = new System.Drawing.Point(144, 46);
            this.ratedCarModelCB.Name = "ratedCarModelCB";
            this.ratedCarModelCB.Size = new System.Drawing.Size(98, 21);
            this.ratedCarModelCB.TabIndex = 14;
            // 
            // RateCarController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ratedCarModelCB);
            this.Controls.Add(this.ratedCarBrandCB);
            this.Controls.Add(this.ratedCarIdCB);
            this.Controls.Add(this.best3Label);
            this.Controls.Add(this.showBest3Button);
            this.Controls.Add(this.threeRatedCarDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.giveRateComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RateCarController";
            this.Size = new System.Drawing.Size(248, 289);
            this.Load += new System.EventHandler(this.RateCarController_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threeRatedCarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox giveRateComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView threeRatedCarDataGridView;
        private System.Windows.Forms.Button showBest3Button;
        private System.Windows.Forms.Label best3Label;
        private System.Windows.Forms.ComboBox ratedCarIdCB;
        private System.Windows.Forms.ComboBox ratedCarBrandCB;
        private System.Windows.Forms.ComboBox ratedCarModelCB;
    }
}
