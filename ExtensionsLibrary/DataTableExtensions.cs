using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Various Examples for extending <see cref="DataTable"/> with extension methods
    /// </summary>
    public static class DataTableExtensions
    {
        /// <summary>
        /// Get last column value in this table by column name
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="sender">DataTable</param>
        /// <param name="pColumnName">Name of column to get value for</param>
        /// <returns>Last field value for pColumnName</returns>
        public static T FieldLastValue<T>(this DataTable sender, string pColumnName)
        {
            return sender.Rows[sender.Rows.Count - 1].Field<T>(sender.Columns[pColumnName]);
        }
        /// <summary>
        /// Get last column value in this table by column index
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="sender">DataTable</param>
        /// <param name="pColumnIndex">Ordinal index of column to get value for.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static T FieldLastValue<T>(this DataTable sender, int pColumnIndex)
        {
            return sender.Rows[sender.Rows.Count - 1].Field<T>(sender.Columns[pColumnIndex]);
        }
        /// <summary>
        /// Set ColumnMapping for each field name containing Identifier
        /// </summary>
        /// <param name="sender">DataTable with defined columns</param>
        public static void HideIdentifierFields(this DataTable sender)
        {
            foreach (DataColumn column in sender.Columns)
            {
                if (column.ColumnName.Contains("Identifier"))
                {
                    column.ColumnMapping = MappingType.Hidden;
                }
            }
        }
    }
}
