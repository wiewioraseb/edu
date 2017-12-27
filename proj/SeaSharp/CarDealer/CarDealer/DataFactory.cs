using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CarDealer.DataAccessLayer
{
    public enum DatabaseType
    {
        Access,
        SQLServer,
        Oracle
        // any other data source type
    }

    public enum ParameterType
    {
        Integer,
        Char,
        VarChar
        // define rest of parameter type set
    }

    // https://msdn.microsoft.com/en-us/library/ms971568.aspx
    public class DataFactory
    {
        private DataFactory() { }

        public static IDbConnection CreateConnection
           (string ConnectionString, DatabaseType dbtype)
        {
            IDbConnection cnn;

            switch (dbtype)
            {
                case DatabaseType.Access:
                    cnn = new OleDbConnection
                       (ConnectionString);
                    break;
                case DatabaseType.SQLServer:
                    cnn = new SqlConnection
                       (ConnectionString);
                    break;
                //case DatabaseType.Oracle:
                //    cnn = new OracleConnection
                //       (ConnectionString);
                //    break;
                default:
                    cnn = new SqlConnection
                       (ConnectionString);
                    break;
            }

            return cnn;
        }


        public static IDbCommand CreateCommand
           (string CommandText, DatabaseType dbtype, IDbConnection cnn)
        {
            IDbCommand cmd;
            switch (dbtype)
            {
                case DatabaseType.Access:
                    cmd = new OleDbCommand
                       (CommandText,
                       (OleDbConnection)cnn);
                    break;

                case DatabaseType.SQLServer:
                    cmd = new SqlCommand
                       (CommandText,
                       (SqlConnection)cnn);
                    break;

                //case DatabaseType.Oracle:
                //    cmd = new OracleCommand
                //       (CommandText,
                //       (OracleConnection)cnn);
                //    break;
                default:
                    cmd = new SqlCommand
                       (CommandText,
                       (SqlConnection)cnn);
                    break;
            }

            return cmd;
        }


        public static DbDataAdapter CreateAdapter
           (IDbCommand cmd, DatabaseType dbtype)
        {
            DbDataAdapter da;
            switch (dbtype)
            {
                case DatabaseType.Access:
                    da = new OleDbDataAdapter
                       ((OleDbCommand)cmd);
                    break;

                case DatabaseType.SQLServer:
                    da = new SqlDataAdapter
                       ((SqlCommand)cmd);
                    break;

                //case DatabaseType.Oracle:
                //    da = new OracleDataAdapter
                //       ((OracleCommand)cmd);
                //    break;

                default:
                    da = new SqlDataAdapter
                       ((SqlCommand)cmd);
                    break;
            }

            return da;
        }
    }
}
