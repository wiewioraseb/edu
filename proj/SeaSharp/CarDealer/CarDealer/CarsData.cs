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
                CarsData.DbConnection.Open();

                IDbCommand cmd =
               DataFactory.CreateCommand(sqlCommand);

                DbDataAdapter dataAdapter =
                   DataFactory.CreateAdapter(cmd);

                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                CarsData.DbConnection.Close();
        }

        public static void UpdateCar(string sqlCommand)
        {
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
