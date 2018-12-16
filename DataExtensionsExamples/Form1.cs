using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionsLibrary;

namespace DataExtensionsExamples
{
    public partial class Form1 : Form
    {
        private DataOperations _dataOperations = new DataOperations();
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _dataOperations.LoadCustomers();
            dataGridView1.DataSource = _bindingSource;
        }
        /// <summary>
        /// Get current record primary key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentPrimaryKeyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Current key: {_bindingSource.DataRow().Field<int>("CustomerIdentifier")}");            
        }
        /// <summary>
        /// Get last primary key regardless of the sort.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastPrimaryKeyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Last Key: {_bindingSource.DataTable().FieldLastValue<int>("CustomerIdentifier")}");
        }
        /// <summary>
        /// Example of filtering
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filterTextBox.Text.IsNullOrWhiteSpace())
            {
                _bindingSource.RowFilterClear();
                return;
            }

            var rb = groupBox1.SelectedRadioButton();
            if (rb == null) return;

            var filterCondition = EnumExtensions.StringToEnum<FilterCondition>(rb.Name.Replace("rdo", ""));
            if (!_bindingSource.RowFilter("CompanyName", filterTextBox.Text, filterCondition))
            {
                MessageBox.Show("No matches");
                _bindingSource.RowFilterClear();
            }
        }
    }
}
