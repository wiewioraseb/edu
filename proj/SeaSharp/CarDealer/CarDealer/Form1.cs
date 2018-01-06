using CarDealer.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DatabaseConnection.Set();

            // For english exceptions
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();

            //DataFactory x = new DataFactory();

            //Generic connection to db:
            // https://msdn.microsoft.com/en-us/library/ms971568.aspx

            //Some example:
            //https://www.codeproject.com/Articles/6217/An-ADO-NET-multi-database-multi-tier-solution

            // Examples from 'best practises'
            // https://msdn.microsoft.com/en-us/library/ms971481.aspx

            // multiple databses with ado.net
            // https://www.codeproject.com/Questions/503675/DataSetpluswithplusdifferentplusDatabasesplusorplu
            // https://forums.asp.net/p/949947/1155679.aspx?Re+Using+two+different+databases+with+a+dataset+

            // Hack tableAdapter to execute dynamic select queries:
            // https://www.codeproject.com/Articles/17324/Extending-TableAdapters-for-Dynamic-SQL
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carDealer2DataSet.cars' table. You can move, or remove it, as needed.
            this.cars2TableAdapter.Fill(this.carDealer2DataSet.cars);
            // TODO: This line of code loads data into the 'carDealer1DataSet.cars' table. You can move, or remove it, as needed.
            this.cars1TableAdapter.Fill(this.carDealer1DataSet.cars);
            // TODO: This line of code loads data into the 'car_dealer_dbDataSet.samochody' table. You can move, or remove it, as needed.
            this.samochodyTableAdapter.Fill(this.carDealerDataSet.samochody);
            System.Diagnostics.Debug.WriteLine("Form1_Load");

            label10.Text = computer1.CPU.Architecture;

            foreach (CarDealerEnum enumValue in Enum.GetValues(typeof(CarDealerEnum)))
            {
                pickDbComboBox.Items.Add(enumValue.ToString());
            }

            //carModelComboBox.Enabled = false;
            //engineComboBox.Enabled = false;
            //lacquerColorComboBox.Enabled = false;

            carBrandComboBox.DropDown += new EventHandler(carBrandComboBox_DropDown);
            carBrandComboBox.SelectionChangeCommitted += new EventHandler(carBrandComboBox_SelectionChangeCommitted);
            carModelComboBox.DropDown += new EventHandler(carModelComboBox_DropDown);
            carModelComboBox.SelectionChangeCommitted += new EventHandler(carModelComboBox_SelectionChangeCommitted);
            engineComboBox.DropDown += new EventHandler(engineComboBox_DropDown);
            //engineComboBox.SelectionChangeCommitted += new EventHandler(engineComboBox_SelectionChangeCommitted);
            lacquerColorComboBox.DropDown += new EventHandler(lacquerColorComboBox_DropDown);
            //lacquerColorComboBox.SelectionChangeCommitted += new EventHandler(lacquerColorComboBox_SelectionChangeCommitted);
        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void carBrandComboBox_DropDown(object sender, EventArgs e)
        {
            carBrandComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT brand FROM cars");
            carBrandComboBox.DisplayMember = "brand";

            /* System.Diagnostics.Debug.WriteLine("Car Brand DropDown Event!");

            //carBrandComboBox.DataSource = carBrands;
            carModelComboBox.Enabled = true; */
        }
        private void carBrandComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*
            //this.cars1BindingSource.DataSource = CarsData.GetCars("SELECT DISTINCT brand FROM cars");
            System.Diagnostics.Debug.WriteLine("instanceOf: " + this.cars1BindingSource.DataSource.GetType());

            DataTable queriedDataTable;

            if (this.cars1BindingSource.DataSource is DataSet)
            {
                System.Diagnostics.Debug.WriteLine("DATASET TYPE!");
                queriedDataTable = ((DataSet)this.cars1BindingSource.DataSource).Tables["cars"];
            }
            else if(this.cars1BindingSource.DataSource.GetType() == typeof(DataTable))
            {
                System.Diagnostics.Debug.WriteLine("DATATABLE TYPE!");
                queriedDataTable = ((DataTable)this.cars1BindingSource.DataSource);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("OTHER TYPE!");
                queriedDataTable = ((DataTable)this.cars1BindingSource.DataSource);
            }

            //this.cars1BindingSource.DataSource = null;

            System.Diagnostics.Debug.WriteLine(
                "carBrandComboBox.Text: " + carBrandComboBox.Text +
                " carBrandComboBox.SelectedText: " + carBrandComboBox.SelectedText +
                " carBrandComboBox.GetItemText(c.SelectedItem): " + carBrandComboBox.GetItemText(carBrandComboBox.SelectedItem)
                );

            string filter = carBrandComboBox.GetItemText(carBrandComboBox.SelectedItem);
            DataRow[] filteredDataTableRows = queriedDataTable.Select("brand = '" + filter + "'");
            DataTable resultDataTable = filteredDataTableRows.Any() ?
                filteredDataTableRows.CopyToDataTable() : new DataTable();

            this.cars1BindingSource.DataSource = resultDataTable;
              

            //carBrandComboBox.DisplayMember = "brand";
            */
        }

        private void carModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carAvatarPB.
            //this.carAvatarPB.Image = global::CarDealer.Properties.Resources.toyota_cruiser;
            this.carAvatarPB.Image = (Bitmap)global::CarDealer.Properties.Resources.ResourceManager.GetObject("toyota_cruiser");

        }
        private void carModelComboBox_DropDown(object sender, EventArgs e)
        {
            carModelComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT model FROM cars");
            carModelComboBox.DisplayMember = "model";
        }
        private void carModelComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*carModelComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT model FROM cars");
            carModelComboBox.DisplayMember = "model";*/
        }

        private void engineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void engineComboBox_DropDown(object sender, EventArgs e)
        {
            engineComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT car_engine FROM cars");
            engineComboBox.DisplayMember = "car_engine";
        }

        private void isMetallicLacquerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lacquerColorComboBox.DataSource = new DataTable();
        }

        private void lacquerColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lacquerColorComboBox_DropDown(object sender, EventArgs e)
        {
            bool isMetallicType = isMetallicLacquerCheckBox.Checked;
            //MessageBox.Show("metallicType: " + isMetallicType);
            string appendToSqlQuery = isMetallicType ? " WHERE has_metallic_lacquer=1" : "";
            lacquerColorComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT lacquer_color FROM cars" + appendToSqlQuery);
            lacquerColorComboBox.DisplayMember = "lacquer_color";
        }

        private void additionalOptionsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewCarButton_Click(object sender, EventArgs e)
        {
            // BindingList: https://stackoverflow.com/questions/9758577/c-sharp-datagridview-not-updated-when-datasource-is-changed 
            //enginesList.Add(addEngineTextBox.Text);
            // dirty hack
            //engineComboBox.DataSource = null;
            //engineComboBox.DataSource = enginesList;

            try
            {
                //this.carsBindingSource.AddNew();
                //DataRow dr = this.carsBindingSource.Rows[IntPosition];
                //dr.BeginEdit();
                //dr[1] = "New Value";

                //this.carsBindingSource.Insert(0, "String");

                this.cars1TableAdapter.Insert(
                    addBrandTextBox.Text.ToString(),
                    addModelTextBox.Text.ToString(),
                    addEngineTextBox.Text.ToString(),
                    "2017",
                    "yellow",
                    0,
                    1,
                    0,
                    1,
                    45000
                    );

                this.Validate();
                //this.carsBindingSource.EndEdit();
                this.cars1TableAdapter.Update(this.carDealer1DataSet.cars);
                this.cars1TableAdapter.Fill(this.carDealer1DataSet.cars);

                MessageBox.Show("Dodano nowy wpis.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("NIE udalo sie dodac nowego wpisu!");
                System.Diagnostics.Debug.WriteLine("NIE udalo sie dodac nowego wpisu: " + ex.StackTrace);
                System.Diagnostics.Debug.WriteLine("NIE udalo sie dodac nowego wpisu MESSAGE: " + ex.Message);

            }
        }

        private void Validate()
        {
            System.Diagnostics.Debug.WriteLine("Zwalidowano!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT * FROM cars";


                List<string> queryElements = new List<string>();
                queryElements.Add( (carBrandComboBox.SelectedIndex > -1) ? 
                    ("brand='" + carBrandComboBox.Text+"'") : null);
                queryElements.Add((carModelComboBox.SelectedIndex > -1) ?
                    ("model='" + carModelComboBox.Text + "'") : null);
                queryElements.Add((engineComboBox.SelectedIndex > -1) ?
                    ("car_engine='" + engineComboBox.Text + "'") : null);
                queryElements.Add((lacquerColorComboBox.SelectedIndex > -1) ?
                    ("lacquer_color='" + lacquerColorComboBox.Text + "'") : null);

                queryElements.RemoveAll(query => query == null);
                if (queryElements.Count > 0)
                {
                    sqlQuery += " WHERE ";
      
                    foreach (string query in queryElements)
                    {
                        if (queryElements.IndexOf(query) == queryElements.Count-1)
                        {
                            sqlQuery += query;
                            break;
                        }
                        sqlQuery += query + " AND ";
                    }
                }

                System.Diagnostics.Debug.WriteLine("sqlQuery : " + sqlQuery);


                foreach (object itemChecked in additionalOptionsCheckedListBox.CheckedItems)
                {
                    //itemChecked.Checked ?
                }

                this.cars1BindingSource.DataSource = CarsData.GetCars(sqlQuery);
                
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION! : " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void pickDbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDatabase = ((ComboBox)sender).SelectedIndex;

            switch (selectedDatabase)
            {
                case (int)CarDealerEnum.CarDealer1:
                    DatabaseConnection.Set(CarDealerConnectionString.carDealer1);
                    break;
                case (int)CarDealerEnum.CarDealer2:
                    DatabaseConnection.Set(CarDealerConnectionString.carDealer2);
                    break;
                default:
                    DatabaseConnection.Set();
                    break;
            }

            this.cars1BindingSource.DataSource = CarsData.GetCars();
        }
    }
}
