using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        Dictionary<String, List<String>> Cars = new Dictionary<String, List<String>>();
        List<String> carBrands = new List<String>();
        List<String> carModels = new List<String>();
        List<String> engines = new List<String>();

        String[] initialCarBrands = { "Opel", "BMW", "Mitsubishi", "Citroen", "Toyota" };


        public Form1()
        {
            InitializeComponent();

            carBrands.AddRange(initialCarBrands);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carBrandComboBox.DataSource = carBrands;

        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


    }
}
