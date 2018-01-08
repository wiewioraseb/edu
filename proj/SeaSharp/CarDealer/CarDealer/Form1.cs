using CarDealer.DataAccessLayer;
using CarDealer.security;
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
            //label10.Text = RateCar.service.GetDataService.TESTINGX;
            RateCar.service.GetDataService.BindingSourceFromHost = this.cars1BindingSource;

            // this.mainDataGridView.DataSource = this.cars1BindingSource;

            foreach (CarDealerEnum enumValue in Enum.GetValues(typeof(CarDealerEnum)))
            {
                pickDbComboBox.Items.Add(enumValue.ToString());
            }

            newCarPanel.Visible = false;

            carBrandComboBox.DropDown += new EventHandler(carBrandComboBox_DropDown);
            carBrandComboBox.SelectionChangeCommitted += new EventHandler(carBrandComboBox_SelectionChangeCommitted);
            carModelComboBox.DropDown += new EventHandler(carModelComboBox_DropDown);
            carModelComboBox.SelectionChangeCommitted += new EventHandler(carModelComboBox_SelectionChangeCommitted);
            engineComboBox.DropDown += new EventHandler(engineComboBox_DropDown);
            //engineComboBox.SelectionChangeCommitted += new EventHandler(engineComboBox_SelectionChangeCommitted);
            lacquerColorComboBox.DropDown += new EventHandler(lacquerColorComboBox_DropDown);
            //lacquerColorComboBox.SelectionChangeCommitted += new EventHandler(lacquerColorComboBox_SelectionChangeCommitted);
            mainDataGridView.CellClick += new DataGridViewCellEventHandler(mainDataGridView_CellClick);

            rateCarController.RateComboBox_SelectedIndexChanged += new EventHandler(RateComboBox_SelectedIndexChanged);


        }

        protected void RateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //handle the event 
            System.Diagnostics.Debug.WriteLine("Rate " + ((ComboBox)sender).Text + "  from RateComboBox recieved in parent");
        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void carBrandComboBox_DropDown(object sender, EventArgs e)
        {
            carBrandComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT brand FROM cars");
            carBrandComboBox.DisplayMember = "brand";
        }
        private void carBrandComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void carModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void carModelComboBox_DropDown(object sender, EventArgs e)
        {
            carModelComboBox.DataSource = CarsData.GetCars("SELECT DISTINCT model FROM cars");
            carModelComboBox.DisplayMember = "model";
        }
        private void carModelComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
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

            try
            {
               
                string carBrand = !addBrandTextBox.Text.Equals("") ?
                    "'"+(addBrandTextBox.Text)+"'" : "NULL";
                string carModel = !addModelTextBox.Text.Equals("") ?
                    "'"+(addModelTextBox.Text)+"'" : "NULL";
                string carEngine = !addEngineTextBox.Text.Equals("") ?
                    "'"+(addEngineTextBox.Text)+"'" : "NULL";
                string prodYear = !addProdYearTextBox.Text.Equals("") ?
                    "'"+(addProdYearTextBox.Text)+"'" : "NULL";
                string lacquerColor = !addLacquerTextBox.Text.Equals("") ?
                    "'"+(addLacquerTextBox.Text)+"'" : "NULL";
                string hasMetallicLacquer = addMetalicLacquerCheckBox.Checked ?
                    "1" : "0";
                string hasPowerSteering = addPowerSteeringCheckBox.Checked ?
                    "1" : "0";
                string hasAutomaticTransmission = addAutomaticTransmissionCheckBox.Checked ?
                    "1" : "0";
                string hasAirConditioning = addAirConditionCheckBox.Checked ?
                    "1" : "0";
                string price = !addPriceTextBox.Text.Equals("") ?
                    "'"+(addPriceTextBox.Text)+"'" : "NULL";


                string insertQuery = "INSERT INTO cars " +
         "(brand, model, car_engine, production_year, lacquer_color, has_metallic_lacquer, has_power_steering, has_automatic_transmission, has_air_conditioning, price) " +
       "VALUES (" +
       "" + carBrand + ", " +
       "" + carModel + ", " +
       "" + carEngine + ", " +
       "" + prodYear + ", " +
       "" + lacquerColor + ", " +
       "'" + hasMetallicLacquer + "', " +
       "'" + hasPowerSteering + "', " +
       "'" + hasAutomaticTransmission + "', " +
       "'" + hasAirConditioning + "', " +
       "" + price + ") ";

                System.Diagnostics.Debug.WriteLine("Insert query: " + insertQuery);
                CarsData.InsertCar(insertQuery);
                this.cars1BindingSource.DataSource = CarsData.GetCars();
                MessageBox.Show("Dodano nowy samochód do komisu: " + CarsData.DbConnection.Database);
            }
            catch (System.Exception ex)
            {
                CarsData.DbConnection.Close();
                MessageBox.Show("NIE udalo sie dodac nowego wpisu! \n" + ex.Message);
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
                queryElements.Add(isMetallicLacquerCheckBox.Checked ?
                    ("has_metallic_lacquer='" + 1 + "'") : null);
                queryElements.Add((lacquerColorComboBox.SelectedIndex > -1) ?
                    ("lacquer_color='" + lacquerColorComboBox.Text + "'") : null);
                queryElements.Add(automaticTransmissionCheckBox.Checked ?
                    ("has_automatic_transmission='" + 1 + "'") : null);
                queryElements.Add(powerSteeringCheckBox.Checked ?
                    ("has_power_steering='" + 1 + "'") : null);
                queryElements.Add(airConditionCheckBox.Checked ?
                    ("has_air_conditioning='" + 1 + "'") : null);

                queryElements.RemoveAll(query => query == null || query.Equals(""));
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

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void mainDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string carBrand = this.mainDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            this.carAvatarPB.Image = (Bitmap)global::CarDealer.Properties.Resources.ResourceManager.GetObject(carBrand.ToLower());
        }

        private void showLoginButton_Click(object sender, EventArgs e)
        {
            if (Authentication.Authorized)
            {
                Authentication.Authorized = false;
                MessageBox.Show("Wylogowano administratora!");
                showLoginButton.Text = "Logowanie";

                loggedInUserLabel.Text = "Gość";

                newCarPanel.Visible = false;

            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.FormClosed += LoginForm_FormClosed;
                loginForm.Show();
            }
            
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("LoginForm was closed");
            if (Authentication.Authorized)
            {
                showLoginButton.Text = "Wyloguj";
                loggedInUserLabel.Text = "Administrator";
                newCarPanel.Visible = true;
            }

        }
    }
}
