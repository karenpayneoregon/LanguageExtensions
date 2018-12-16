using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Language extensions for Windows forms DataGridView
    /// </summary>
    public static class DataGridViewExtensions
    {
        /// <summary>
        /// Cast DataGridView DataSource to a DataTable
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <returns>DataTable or throws an exception if DataSource is not a DataTable</returns>
        public static DataTable DataTable(this DataGridView sender) => (DataTable)sender.DataSource;
        /// <summary>
        /// Write entire contents, rows and cells to a tex file
        /// </summary>
        /// <param name="sender">DataGridView with rows and columns</param>
        /// <param name="pFileName">Path and file name to write too</param>
        /// <param name="defaultNullValue">Default value for null or empty cells</param>
        public static void ExportRows(this DataGridView sender, string pFileName, string defaultNullValue = "(empty)")
        {
            File.WriteAllLines(pFileName,(sender.Rows.Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new {row, rowItem = string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => ((c.Value == null) ? defaultNullValue : c.Value.ToString())))})
                .Select(@row => @row.rowItem)));
        }
        /// <summary>
        /// Given a DataGridView populates without a data source, create a DataTable, populate from rows/cells from the
        /// DataGridView with an option to include/exclude column names.
        /// </summary>
        /// <param name="sender">DataGridView to convert contents to a DataTable</param>
        /// <param name="pColumnNames">Include column names</param>
        /// <returns>A DataTable or if not able to convert an exception is thrown</returns>
        /// <remarks>
        /// There is no attempt made to figure out data types coming from data in the DataGridView
        /// </remarks>
        public static DataTable GetDataTable(this DataGridView sender, bool pColumnNames = true)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in sender.Columns)
            {
                if (column.Visible)
                {
                    if (pColumnNames)
                    {
                        dt.Columns.Add(new DataColumn() { ColumnName = column.Name });
                    }
                    else
                    {
                        dt.Columns.Add();
                    }
                }
            }

            var cellValues = new object[sender.Columns.Count];

            foreach (DataGridViewRow row in sender.Rows)
            {
                if (row.IsNewRow) continue;
                for (int index = 0; index < row.Cells.Count; index++)
                {
                    cellValues[index] = row.Cells[index].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;

        }

    }
}
