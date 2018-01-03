﻿using CarDealer.DataAccessLayer;
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
        private static string connString;
        private static DatabaseType dbType;
        private static IDbConnection dbConn;

        public static string ConnectionString { get => connString; set => connString = value; }
        public static DatabaseType DatabaseType { get => dbType; set => dbType = value; }
        public static IDbConnection DbConnection { get => dbConn; set => dbConn = value; }

        public static DataTable GetCars(string sqlCommand)
        {
            try
            {
                IDbConnection cnn =
               DataFactory.CreateConnection(ConnectionString);

                cnn.Open();
                
                IDbCommand cmd =
               DataFactory.CreateCommand(sqlCommand);

            DbDataAdapter dataAdapter =
               DataFactory.CreateAdapter(cmd);

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
