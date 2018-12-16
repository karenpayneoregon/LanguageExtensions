using System;
using System.Runtime.InteropServices;
using ExtensionsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class UnitTest1 : Testbase
    {
        [TestMethod]
        public void IsNullOrWhiteSpaceTest()
        {
            string value = "";
            Assert.IsTrue(value.IsNullOrWhiteSpace());
            value = "Text";
            Assert.IsFalse(value.IsNullOrWhiteSpace());
        }
        [TestMethod]
        public void ContainsTest()
        {
            string value = "This is a Sample string";
            // extension method in StringExtensions
            Assert.IsTrue(value.Contains("sample", true));
            Assert.IsTrue(value.Contains("Sample", true));

            // extension method in the Framework
            Assert.IsFalse(value.Contains("sample"));
        }
        [TestMethod]
        public void ToInt32Test()
        {
            string value = "32";
            Assert.IsTrue(value.ToInt32() == 32);

            value = "A";
            Assert.IsTrue(value.ToInt32() == 0);
        }
        [TestMethod]
        public void ToBoolTest()
        {
            string value = "true";
            Assert.IsTrue(value.ToBoolean() ==  true);
            value = "True";
            Assert.IsTrue(value.ToBoolean() == true);
            value = "ABC";
            Assert.IsFalse(value.ToBoolean() == true);
            value = "false";
            Assert.IsTrue(value.ToBoolean() == false);
        }
        [TestMethod]
        public void IsNumericTest()
        {
            string value = "10.9";
            Assert.IsTrue(value.IsNumeric());
            value = ".9";
            Assert.IsTrue(value.IsNumeric());
            value = "-9";
            Assert.IsTrue(value.IsNumeric());

            value = "10,000";
            Assert.IsTrue(value.IsNumeric());

            value = "$10,000";
            Assert.IsFalse(value.IsNumeric());
        }
        [TestMethod]
        public void FormatPhoneNumberTest()
        {
            string value = "5039458306";
            string expected = "(503) 945-8306";

            Assert.AreEqual(value.FormatPhoneNumber(), expected);

            expected = "(503)945-8306";
            Assert.AreNotEqual(value.FormatPhoneNumber(), expected);

            value = "9458306";
            expected = "945-8306";
            Assert.AreEqual(value.FormatPhoneNumber(), expected);

            value = "5039458306123";
            expected = "(503) 945-8306 x123";
            Assert.AreEqual(value.FormatPhoneNumber(), expected);
        }
        [TestMethod]
        public void JoinWithLastSeparatorTest() 
        {
            string[] values = {"Apples","Oranges","Grapes"};
            string expected = "Apples, Oranges and Grapes";
            string result = values.JoinWithLastSeparator();
            Assert.AreEqual(result, expected);
        }
        /// <summary>
        /// In this example the first test works against a incorrect SQL SELECT statement
        /// with an embedded semi-colon while the second go around the SQL SELECT statement
        /// has been corrected.
        ///
        /// In both cases the language extension ActualCommandText() shows the full SQL
        /// statement with parameter values unlike when done simply displaying the SQL with
        /// parameters via Add or AddWithValue
        /// </summary>
        [TestMethod]
        public void ActualCommandTextTest()
        {
            int customerIdentifier = 2;

            var dt = LoadCustomers(customerIdentifier);


            string expected = "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , CT.ContactTitle , " + 
                              "C.[Address] AS Street , C.City , C.PostalCode , C.Country , C.ContactTypeIdentifier " + 
                              "FROM Customers AS C INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = " + 
                              $"CT.ContactTypeIdentifier;WHERE C.CustomerIdentifier = {customerIdentifier}";


            Assert.IsFalse(IsSuccessFul);
            Assert.IsTrue(expected.Contains(";WHERE"));
            Assert.IsTrue(expected.Contains($"C.CustomerIdentifier = {customerIdentifier}"));

            // second take with correct SQL
            dt = LoadCustomers(customerIdentifier, false);
            Assert.IsTrue(IsSuccessFul);
            Assert.IsTrue(dt.Rows.Count == 1);
        }
        [TestMethod]
        public void BetweenTest() 
        {
            var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
            var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
            var theDate = new DateTime(2018, 12, 13, 1, 12, 0);

            Assert.IsTrue(theDate.Between(startDate,endDate));

            theDate = new DateTime(2018, 12, 16, 1, 12, 0);           
            Assert.IsFalse(theDate.Between(startDate, endDate));

            var startInt = 10;
            var endInt = 20;
            var theInt = 12;
            Assert.IsTrue(theInt.Between(startInt,endInt));

            theInt = 21;
            Assert.IsFalse(theInt.Between(startInt, endInt));


        }
    }
}
