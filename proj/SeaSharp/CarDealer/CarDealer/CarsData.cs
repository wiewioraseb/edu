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
    class CarsData
    {
        public static DataTable GetCars(string sqlCommand, DatabaseType dbType, string connectionString)
        {
            try
            {

                IDbConnection cnn =
               DataFactory.CreateConnection
               (connectionString, dbType);

                cnn.Open();


                IDbCommand cmd =
               DataFactory.CreateCommand(
               sqlCommand, dbType, cnn);

            DbDataAdapter dataAdapter =
               DataFactory.CreateAdapter(cmd, dbType);

            DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                cnn.Close();
            return dataTable;
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL EXCEPTION in GetCars! : " + ex.Message + "\n" + ex.StackTrace);
                return null;
            }
        }

        public bool InsertCar()
        {
            // TBD 
            return false;
        }
    }
}
