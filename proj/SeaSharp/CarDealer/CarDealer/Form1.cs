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

        List<String> enginesList = new List<String>(new String[] { "1.3", "1.6", "2.0" });
        List<String> lacquerColors = new List<String>(new String[] { "czarny", "biały", "żółty", "zielony", "niebieski", "szary", "czerwony", "fioletowy" });
        List<String> metallicLacquerColors = new List<String>(new String[] { "czarny", "zielony", "niebieski", "czerwony"});

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
            // TODO: This line of code loads data into the 'car_dealer_dbDataSet.samochody' table. You can move, or remove it, as needed.
            this.samochodyTableAdapter.Fill(this.carDealerDataSet.samochody);
            System.Diagnostics.Debug.WriteLine("Form1_Load");

            carModelComboBox.Enabled = false;
            engineComboBox.Enabled = false;
            lacquerColorComboBox.Enabled = false;

            carBrandComboBox.DropDown += new EventHandler(carBrandComboBox_DropDown);
            carModelComboBox.DropDown += new EventHandler(carModelComboBox_DropDown);
            engineComboBox.DropDown += new EventHandler(engineComboBox_DropDown);
            lacquerColorComboBox.DropDown += new EventHandler(lacquerColorComboBox_DropDown);
        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void carBrandComboBox_DropDown(object sender, EventArgs e)
        {
            //carBrandComboBox.DataSource = carBrands;
            carModelComboBox.Enabled = true;
        }

        private void carModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carAvatarPB.
            //this.carAvatarPB.Image = global::CarDealer.Properties.Resources.toyota_cruiser;
            this.carAvatarPB.Image = (Bitmap)global::CarDealer.Properties.Resources.ResourceManager.GetObject("toyota_cruiser");

        }
        private void carModelComboBox_DropDown(object sender, EventArgs e)
        {
            String selectedCarBrand = carBrandComboBox.SelectedItem.ToString();
            carModelComboBox.DataSource = cars[selectedCarBrand];
            engineComboBox.Enabled = true;
        }

        private void engineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void engineComboBox_DropDown(object sender, EventArgs e)
        {
            engineComboBox.DataSource = enginesList;
            lacquerColorComboBox.Enabled = true;
        }

        private void isMetallicLacquerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lacquerColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lacquerColorComboBox_DropDown(object sender, EventArgs e)
        {
            lacquerColorComboBox.DataSource = isMetallicLacquerCheckBox.Checked ? metallicLacquerColors : lacquerColors;

        }

        private void additionalOptionsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addEngineButton_Click(object sender, EventArgs e)
        {
            // BindingList: https://stackoverflow.com/questions/9758577/c-sharp-datagridview-not-updated-when-datasource-is-changed 
            enginesList.Add(addEngineTextBox.Text);
            // dirty hack
            engineComboBox.DataSource = null;
            engineComboBox.DataSource = enginesList;

            try
            {
                //this.carsBindingSource.AddNew();
                //DataRow dr = this.carsBindingSource.Rows[IntPosition];
                //dr.BeginEdit();
                //dr[1] = "New Value";

                this.samochodyTableAdapter.Insert(
                    addBrandTextBox.Text.ToString(),
                    addModelTextBox.Text.ToString(),
                    addEngineTextBox.Text.ToString(),
                    "1990",
                    2000
                    );

                this.Validate();
                //this.carsBindingSource.EndEdit();
                this.samochodyTableAdapter.Update(this.carDealerDataSet.samochody);
                this.samochodyTableAdapter.Fill(this.carDealerDataSet.samochody);

                MessageBox.Show("Dodano nowy wpis.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("NIE udalo sie dodac nowego wpisu!");
            }
        }

        private void Validate()
        {
            System.Diagnostics.Debug.WriteLine("Zwalidowano!");
        }
    }
}
