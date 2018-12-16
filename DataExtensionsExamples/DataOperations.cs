using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLibrary;
using ExtensionsLibrary;

namespace DataExtensionsExamples
{
    public class DataOperations : BaseSqlServerConnections
    {
        public DataOperations()
        {
            DefaultCatalog = "NorthWindAzure";
        }

        private const string SelectStatement = "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , " + 
                                               "CT.ContactTitle , C.[Address] AS Street , C.City , C.PostalCode , " +
                                               "C.Country , C.ContactTypeIdentifier " + 
                                               "FROM Customers AS C " + 
                                               "INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier;";

        public DataTable LoadCustomers()
        {
            var dt = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cmd.CommandText = SelectStatement;

                    cn.Open();
                    dt.Load(cmd.ExecuteReader());
                    dt.HideIdentifierFields();
                }
            }

            return dt;
        }

    }
}
