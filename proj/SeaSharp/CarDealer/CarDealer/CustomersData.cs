using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccessLayer
{
    public class CustomersData
    {
        public DataTable GetCustomers()
        {
            string ConnectionString =
               ConfigurationSettings.AppSettings
               ["ConnectionString"];
            DatabaseType dbtype =
               (DatabaseType)Enum.Parse
               (typeof(DatabaseType),
               ConfigurationSettings.AppSettings
               ["DatabaseType"]);

            IDbConnection cnn =
               DataFactory.CreateConnection(ConnectionString);

            string cmdString = "SELECT CustomerID" +
               ",CompanyName,ContactName FROM Customers";

            IDbCommand cmd =
               DataFactory.CreateCommand(cmdString);

            DbDataAdapter da =
               DataFactory.CreateAdapter(cmd);

            DataTable dt = new DataTable("Customers");

            da.Fill(dt);

            return dt;
        }

        //public CustomersDS GetCustomerOrders(string CustomerID)
        //{
        //    // TBD
        //    return null;
        //}
        //public CustomersList GetCustomersByCountry
        //   (string CountryCode)
        //{
        //    // TBD
        //    return null;
        //}
        public bool InsertCustomer()
        {
            // TBD 
            return false;
        }
    }
}
