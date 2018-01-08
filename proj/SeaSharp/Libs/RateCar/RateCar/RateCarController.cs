using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RateCar.service;

namespace RateCar
{
    public partial class RateCarController: UserControl
    {
        public event EventHandler RateComboBox_SelectedIndexChanged;
        public RateCarController()
        {
            InitializeComponent();

            ratedCarIdCB.Enabled = false;
            ratedCarBrandCB.Enabled = false;
            ratedCarModelCB.Enabled = false;
        }

        private void RateCarController_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("RateCarController_Load");

            threeRatedCarDataGridView.DataSource = GetDataService.BindingSourceFromHost;
            // this.mainDataGridView.DataSource = this.cars1BindingSource;

        }

        private void showBest3Button_Click(object sender, EventArgs e)
        {
            threeRatedCarDataGridView.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarIdCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarIdCB.DisplayMember = "id";
            ratedCarBrandCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarBrandCB.DisplayMember = "brand";
            ratedCarModelCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarModelCB.DisplayMember = "model";
        }

        private void giveRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("New rate " + ((ComboBox)sender).Text + " has been given for car ID: " + ratedCarIdCB.Text);
            
            if (this.RateComboBox_SelectedIndexChanged != null)
            {
                this.RateComboBox_SelectedIndexChanged(this, e);
            }
        }
    }
}
