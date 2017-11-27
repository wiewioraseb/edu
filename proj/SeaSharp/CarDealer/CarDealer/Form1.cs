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
        Dictionary<String, List<String>> cars = new Dictionary<String, List<String>>();
        List<String> carBrands = new List<String>();
        //List<String> carModels = new List<String>();
        //List<String> engines = new List<String>();

        String[] initialCarBrands = { "Opel", "BMW", "Mitsubishi", "Citroen", "Toyota" };
        //String[] opelModels = { "Astra", "Omega", "Mokka", "Insignia", "Zefira" };
        List<String> opelModels = new List<String>(new String[] { "Astra", "Omega", "Mokka", "Insignia", "Zefira" });
        //List<String> opelEngines = new List<String>(new String[] { "1.3", "1.6", "2.0"});
        //String[] bmwModels = { "E46", "X6", "M235i", "X4", "M2" };
        List<String> bmwModels = new List<String>(new String[] { "E46", "X6", "M235i", "X4", "M2" });
        //List<String> bmwEngines = new List<String>(new String[] { "1.3", "1.6", "2.0" });
        //String[] mitsubishiModels = { "Lancer", "Outlander", "Colt", "Pajero", "Sigma" };
        List<String> mitsubishiModels = new List<String>(new String[] { "Lancer", "Outlander", "Colt", "Pajero", "Sigma" });
        //List<String> mitsubishiEngines = new List<String>(new String[] { "1.3", "1.6", "2.0" });
        //String[] citroenModels = { "C3", "Nemo", "C5", "Axel", "Evasion" };
        List<String> citroenModels = new List<String>(new String[] { "C3", "Nemo", "C5", "Axel", "Evasion" });
        //List<String> citroenEngines = new List<String>(new String[] { "1.3", "1.6", "2.0" });
        //String[] toyotaModels = { "Camry", "Premio", "Prius", "Corolla", "Cruiser" };
        List<String> toyotaModels = new List<String>(new String[] { "Camry", "Premio", "Prius", "Corolla", "Cruiser" });
        //List<String> toyotaEngines = new List<String>(new String[] { "1.3", "1.6", "2.0" });

        List<String> engines = new List<String>(new String[] { "1.3", "1.6", "2.0" });

        public Form1()
        {
            InitializeComponent();

            carBrands.AddRange(initialCarBrands);
            cars.Add(initialCarBrands[0], opelModels);
            cars.Add(initialCarBrands[1], bmwModels);
            cars.Add(initialCarBrands[2], mitsubishiModels);
            cars.Add(initialCarBrands[3], citroenModels);
            cars.Add(initialCarBrands[4], toyotaModels);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carBrandComboBox.SelectedIndex = -1;

                carModelComboBox.Enabled = false;
                engineComboBox.Enabled = false;
                lacquerColorComboBox.Enabled = false;

            carBrandComboBox.DropDown += new EventHandler(carBrandComboBox_DropDown);


        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carBrandComboBox_DropDown(object sender, EventArgs e)
        {
            carBrandComboBox.DataSource = carBrands;
            carModelComboBox.Enabled = true;
        }


        private void carModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void carModelComboBox_DropDown(object sender, EventArgs e)
        {
            //engineComboBox.DataSource = 
            //engineComboBox.Enabled = true;
        }
    }
}
