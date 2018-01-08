﻿using System;
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

            // Event catched from partent when mouse enter
            Control parentControl = this.Parent;
            parentControl.MouseEnter += new EventHandler(parent_OnFormLoad);

        }

        private bool firstTimeEvent = true;
        private void parent_OnFormLoad(object sender, EventArgs e)
        {
            if (firstTimeEvent)
            {
                System.Diagnostics.Debug.WriteLine("Initilizing CHILD CONTROLLER!");

                threeRatedCarDataGridView.DataSource = GetDataService.BindingSourceFromHost;
                ratedCarIdCB.DataSource = GetDataService.BindingSourceFromHost;
                ratedCarIdCB.DisplayMember = "id";
                ratedCarBrandCB.DataSource = GetDataService.BindingSourceFromHost;
                ratedCarBrandCB.DisplayMember = "brand";
                ratedCarModelCB.DataSource = GetDataService.BindingSourceFromHost;
                ratedCarModelCB.DisplayMember = "model";

                firstTimeEvent = false;
            }
        }

        private bool isBestAvgCars = true;
        private void showBest3Button_Click(object sender, EventArgs e)
        {
            isBestAvgCars = false;
            if (isBestAvgCars)
            {
                best3Label.Text = "Najwyzej oceniane:";
                "SELECT * FROM cars ORDER BY avg_rate DESC LIMIT 3";
            }
            else
            {
                best3Label.Text = "Najczęściej oceniane:";
                "SELECT * FROM cars ORDER BY no_rate DESC LIMIT 3";

            }
        }

        private void giveRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("New rate " + ((ComboBox)sender).Text + " has been given for car ID: " + ratedCarIdCB.Text);
            
            if (this.RateComboBox_SelectedIndexChanged != null)
            {
                this.RateComboBox_SelectedIndexChanged(sender, e);
            }
        }
    }
}
