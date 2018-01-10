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
using RateCar.events;

namespace RateCar
{
    public partial class RateCarController: UserControl
    {
        public delegate void RateEventHandler(object sender, RateEventArgs args);
        public event RateEventHandler SelectedIndexChangedInRateCB;

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

            // Event catched from partent when mouse enter
            Control parentControl = this.Parent;
            parentControl.MouseEnter += new EventHandler(parent_MouseEnter);

            this.ParentForm.Load += new EventHandler(parentForm_Load);
        }

        private void parentForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Event in RateCarController on Parent Form load.");

            ratedCarIdCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarIdCB.DisplayMember = "id";
            ratedCarBrandCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarBrandCB.DisplayMember = "brand";
            ratedCarModelCB.DataSource = GetDataService.BindingSourceFromHost;
            ratedCarModelCB.DisplayMember = "model";

            threeRatedCarDataGridView.DataSource = GetDataService.Best3DataTableFromHost;

            GetDataService.BindingSourceFromHost.DataSourceChanged += new EventHandler(bindingSourceFromHost_DSChanged);
        }

        private void bindingSourceFromHost_DSChanged(object sender, EventArgs e)
        {
            isBestAvgCars = true;
            best3Label.Text = "Najwyzej oceniane:";
            showBest3Button.Text = "Pokaz najczesciej oceniane";

            threeRatedCarDataGridView.DataSource = GetDataService.Best3DataTableFromHost;
        }

        private bool firstTimeEvent = true;
        private void parent_MouseEnter(object sender, EventArgs e)
        {
            if (firstTimeEvent)
            {
                System.Diagnostics.Debug.WriteLine("Initilizing CHILD CONTROLLER!");

                firstTimeEvent = false;
            }
        }

        private bool isBestAvgCars = true;
        private void showBest3Button_Click(object sender, EventArgs e)
        {
            isBestAvgCars = !isBestAvgCars;
            if (isBestAvgCars)
            {
                best3Label.Text = "Najwyzej oceniane:";
                showBest3Button.Text = "Pokaz najczesciej oceniane";
                threeRatedCarDataGridView.DataSource = GetDataService.Best3DataTableFromHost;
                //"SELECT * FROM cars ORDER BY avg_rate DESC LIMIT 3";
            }
            else
            {
                best3Label.Text = "Najczęściej oceniane:";
                showBest3Button.Text = "Pokaz najwyzej oceniane";
                threeRatedCarDataGridView.DataSource = GetDataService.Most3DataTableFromHost;
                //"SELECT * FROM cars ORDER BY no_rate DESC LIMIT 3";
            }
        }

        private void giveRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("New rate " + ((ComboBox)sender).Text + " has been given for car ID: " + ratedCarIdCB.Text);

            if (this.SelectedIndexChangedInRateCB != null)
            {
                this.SelectedIndexChangedInRateCB
                    (sender, new RateEventArgs(Int32.Parse(ratedCarIdCB.Text), ratedCarBrandCB.Text, ratedCarModelCB.Text));
            }
        }
    }
}
