using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Filter options for RowFilter extension methods
    /// </summary>
    public enum FilterCondition
    {
        /// <summary>
        /// String starts with
        /// </summary>
        StartsWith,
        /// <summary>
        /// String contains
        /// </summary>
        Contains,
        /// <summary>
        /// String ends with
        /// </summary>
        EndsWith
    }
    /// <summary>
    /// Various extension methods for working with a BindingSource component
    /// </summary>
    public static class BindingSourceExtensions
    {
        /// <summary>
        /// Provides access to the underlying DataTable or an exception is thrown if the DataSource is not a BindingSource
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <returns>DataTable</returns>
        public static DataTable DataTable(this BindingSource sender) => (DataTable)sender.DataSource;
        /// <summary>
        /// Access the DataView of the DataTable
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <returns>Given the BindingSource DataSource is a DataTable returns the DataTable default view</returns>
        public static DataView DataView(this BindingSource sender) => ((DataTable)sender.DataSource).DefaultView;

        /// <summary>
        /// Provides access to the underlying DataRow of the Current property, an exception is thrown if the DataSource is not a BindingSource
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <returns>A DataRow for the Current position of the BindingSource</returns>
        public static DataRow DataRow(this BindingSource sender) => ((DataRowView)sender.Current).Row;
        /// <summary>
        /// Provides filter for starts-with, contains or ends-with
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pField">Field to apply filter on</param>
        /// <param name="pValue">Value for filter</param>
        /// <param name="pCondition">Type of filter</param>
        /// <param name="pCaseSensitive">Filter should be case or case in-sensitive</param>
        public static bool RowFilter(this BindingSource sender, string pField, string pValue, FilterCondition pCondition, bool pCaseSensitive = false)
        {
            switch (pCondition)
            {
                case FilterCondition.StartsWith:
                    sender.RowFilterStartsWith(pField, pValue, pCaseSensitive);
                    break;
                case FilterCondition.Contains:
                    sender.RowFilterContains(pField, pValue, pCaseSensitive);
                    break;
                case FilterCondition.EndsWith:
                    sender.RowFilterEndsWith(pField, pValue, pCaseSensitive);
                    break;
            }

            return sender.Count > 0;
        }
        /// <summary>
        /// Apply filter to the DefaultView of the DataTable
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pField">Field to apply filter on</param>
        /// <param name="pValue">Value for filter</param>
        /// <param name="pCaseSensitive">Filter should be case or case in-sensitive</param>
        /// <returns>Filter has rows</returns>
        public static bool RowFilter(this BindingSource sender, string pField, string pValue, bool pCaseSensitive = false)
        {
            sender.DataTable().CaseSensitive = pCaseSensitive;
            sender.DataView().RowFilter = $"{pField} = '{pValue}'";
            return sender.Count > 0;
        }
        /// <summary>
        /// Apply a filter for Like contains
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pField">Field to apply filter on</param>
        /// <param name="pValue">Value for filter</param>
        /// <param name="pCaseSensitive">Filter should be case or case in-sensitive</param>
        public static void RowFilterContains(this BindingSource sender, string pField, string pValue, bool pCaseSensitive = false)
        {
            sender.DataTable().CaseSensitive = pCaseSensitive;
            sender.DataView().RowFilter = $"{pField} LIKE '%{pValue}%'";
        }
        /// <summary>
        /// Apply a filter for Like starts with
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pField">Field to apply filter on</param>
        /// <param name="pValue">Value for filter</param>
        /// <param name="pCaseSensitive">Filter should be case or case in-sensitive</param>
        public static void RowFilterStartsWith(this BindingSource sender, string pField, string pValue, bool pCaseSensitive = false)
        {
            sender.DataTable().CaseSensitive = pCaseSensitive;
            sender.DataView().RowFilter = $"{pField} LIKE '{pValue}%'";
        }
        /// <summary>
        /// Apply a filter for ends with
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pField">Field to apply filter on</param>
        /// <param name="pValue">Value for filter</param>
        /// <param name="pCaseSensitive">True for case sensitive, false for case insensitive</param>
        public static void RowFilterEndsWith(this BindingSource sender, string pField, string pValue, bool pCaseSensitive = false)
        {
            sender.DataTable().CaseSensitive = pCaseSensitive;
            sender.DataView().RowFilter = $"{pField} LIKE '%{pValue}'";
        }
        /// <summary>
        /// This extension is a free form method for filtering. The usage would be
        /// to provide a user interface to put together the condition.  See unit
        /// test FreeForm_CaseSensitive_OnBoth_Conditions_LastField_NotExact
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <param name="pFilter">Filter condition</param>
        /// <param name="pCaseSensitive">True for case sensitive, false for case insensitive</param>
        public static void RowFilterFreeForm(this BindingSource sender, string pFilter, bool pCaseSensitive = false)
        {
            sender.DataTable().CaseSensitive = pCaseSensitive;
            sender.DataView().RowFilter = pFilter;
        }
        /// <summary>
        /// Clear DataView RowFilter
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        public static void RowFilterClear(this BindingSource sender)
        {
            sender.DataView().RowFilter = "";
        }
        /// <summary>
        /// Determine if DataSource is set
        /// </summary>
        /// <param name="sender">BindingSource with a DataTable set for the DataSource</param>
        /// <returns>True if the DataSource has DataSource property set, false if not set</returns>
        public static bool HasData(this BindingSource sender)
        {
            return sender.DataSource != null;
        }

    }
}
