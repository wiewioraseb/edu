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
            this.ratedCarBrandTB = new System.Windows.Forms.TextBox();
            this.ratedCarModelTB = new System.Windows.Forms.TextBox();
            this.ratedCarIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ratedCarBrandTB
            // 
            this.ratedCarBrandTB.Location = new System.Drawing.Point(37, 48);
            this.ratedCarBrandTB.Name = "ratedCarBrandTB";
            this.ratedCarBrandTB.Size = new System.Drawing.Size(100, 20);
            this.ratedCarBrandTB.TabIndex = 0;
            // 
            // ratedCarModelTB
            // 
            this.ratedCarModelTB.Location = new System.Drawing.Point(144, 48);
            this.ratedCarModelTB.Name = "ratedCarModelTB";
            this.ratedCarModelTB.Size = new System.Drawing.Size(100, 20);
            this.ratedCarModelTB.TabIndex = 1;
            // 
            // ratedCarIdTB
            // 
            this.ratedCarIdTB.Location = new System.Drawing.Point(5, 48);
            this.ratedCarIdTB.Name = "ratedCarIdTB";
            this.ratedCarIdTB.Size = new System.Drawing.Size(26, 20);
            this.ratedCarIdTB.TabIndex = 2;
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
            // RateCarController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratedCarIdTB);
            this.Controls.Add(this.ratedCarModelTB);
            this.Controls.Add(this.ratedCarBrandTB);
            this.Name = "RateCarController";
            this.Size = new System.Drawing.Size(247, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ratedCarBrandTB;
        private System.Windows.Forms.TextBox ratedCarModelTB;
        private System.Windows.Forms.TextBox ratedCarIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
