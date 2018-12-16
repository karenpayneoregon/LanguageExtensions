using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseLibrary;
using ExtensionsLibrary;

namespace CommonTest
{
    public class Testbase : BaseSqlServerConnections
    {
        public Testbase()
        {
            DefaultCatalog = "NorthWindAzure";
        }

        protected string ActualCommandText;

        private const string SelectStatementBad = "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , " +
                                                  "CT.ContactTitle , C.[Address] AS Street , C.City , C.PostalCode , " +
                                                  "C.Country , C.ContactTypeIdentifier " +
                                                  "FROM Customers AS C " +
                                                  "INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier;" +
                                                  "WHERE C.CustomerIdentifier = @CustomerIdentifier";

        private const string SelectStatementGood = "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , " +
                                                   "CT.ContactTitle , C.[Address] AS Street , C.City , C.PostalCode , " +
                                                   "C.Country , C.ContactTypeIdentifier " +
                                                   "FROM Customers AS C " +
                                                   "INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " +
                                                   "WHERE C.CustomerIdentifier = @CustomerIdentifier";
        /// <summary>
        /// Load Customer by primary key
        /// </summary>
        /// <param name="CustomerIdentifier"></param>
        /// <param name="pBad">true for incorrect SQL, false for correct SQL</param>
        /// <returns>DataTable with one record on success or empty rows for failure</returns>
        public DataTable LoadCustomers(int CustomerIdentifier, bool pBad = true)
        {
            mHasException = false;

            var dt = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = pBad ? SelectStatementBad : SelectStatementGood;                    

                    cmd.Parameters.AddWithValue("@CustomerIdentifier", CustomerIdentifier);

                    try
                    {
                        cn.Open();
                        dt.Load(cmd.ExecuteReader());
                        dt.HideIdentifierFields();
                    }
                    catch (Exception ex)
                    {
                        ActualCommandText = cmd.ActualCommandText();
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return dt;

        }
    }
}
