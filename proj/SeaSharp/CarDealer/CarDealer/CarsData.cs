using CarDealer.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public abstract class CarDealerConnectionString
    {
        public const string carDealer1 = "server=localhost;user id=root;password=root;database=cardealer1;persistsecurityinfo=True";
        public const string carDealer2 = "server=localhost;user id=root;password=root;database=cardealer2;persistsecurityinfo=True";
    }

    public enum CarDealerEnum
    {
        CarDealer1,
        CarDealer2
    }

    public class DatabaseConnection
    {
        public static void Set(string connectionString = CarDealerConnectionString.carDealer1)
        {
            CarsData.ConnectionString = connectionString;
            CarsData.DatabaseType = DatabaseType.MySQL;
            CarsData.DbConnection = DataFactory.CreateConnection(connectionString);
        }
    }
    class CarsData
    {
        private static string connString;
        private static DatabaseType dbType;
        private static IDbConnection dbConn;

        public static string ConnectionString { get => connString; set => connString = value; }
        public static DatabaseType DatabaseType { get => dbType; set => dbType = value; }
        public static IDbConnection DbConnection { get => dbConn; set => dbConn = value; }

        public static DataTable GetCars(string sqlCommand = "SELECT * FROM cars")
        {
            try
            {
                // IDbConnection cnn =
                //DataFactory.CreateConnection(ConnectionString);

                CarsData.DbConnection.Open();

                IDbCommand cmd =
               DataFactory.CreateCommand(sqlCommand);

            DbDataAdapter dataAdapter =
               DataFactory.CreateAdapter(cmd);

            DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                CarsData.DbConnection.Close();
                return dataTable;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION in GetCars! : " + ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public static void InsertCar(string sqlCommand)
        {
            
                /*

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
                    */

 
                CarsData.DbConnection.Open();

                IDbCommand cmd =
               DataFactory.CreateCommand(sqlCommand);

                DbDataAdapter dataAdapter =
                   DataFactory.CreateAdapter(cmd);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                CarsData.DbConnection.Close();
                
        }
    }
}
