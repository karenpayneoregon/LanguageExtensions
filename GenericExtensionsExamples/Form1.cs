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
using GenericExtensionsExamples.Classes;

namespace GenericExtensionsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var carList = Cars.List();
            listBox1.DataSource = carList;
            listBox2.DataSource = carList.DistinctBy(car => car.Model).ToList();

            string[] source = { "first", "second", "third", "fourth", "fifth" };
            listBox3.Items.AddRange(source);

            var distinct = source.DistinctBy(word => word.Length);
            listBox4.Items.AddRange(distinct.ToArray());


            delimitedTextBox.AppendText(string.Join(",", source.ToDelimitedString() + "\n"));
            delimitedTextBox.AppendText(Enumerable.Range(1, 10).ToDelimitedString() + "\n");

            var start = DateTime.Now;
            delimitedTextBox.AppendText(Enumerable.Range(0, 1 + DateTime.Now.AddDays(5).Subtract(start).Days)
                .Select(offset => start.AddDays(offset).ToShortDateString()).ToArray().ToDelimitedString("\t"));


            var names = new List<string>() { "Jane", "Mary", "Karen", "Ann" };
            names.AddUnique("Jane");
            names.AddUnique("Sue");
            names.AddUnique("Karen");
            names.AddUnique("Lisa");

            listBox5.DataSource = names;


        }
    }
}
