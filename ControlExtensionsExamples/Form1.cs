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

namespace ControlExtensionsExamples
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
            textBox1.SetWatermark("No purpose");
            IntTextBox.SetWatermark("Numbers only or else");
            IntTextBox.Text = "10";
            intLabel.Text = $"{IntTextBox.IntValue()}";

            if (selectedRadioGroupBox.HasRadioButtons())
            {
                selectedRadioGroupBox.Controls.OfType<RadioButton>()
                    .FirstOrDefault(rb => rb.Text == "C#").Checked = true;
            }


            ActiveControl = exitButton;

        }

        private void selectedRadioButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedRadioGroupBox.SelectedRadioButton().Text);
        }

        private void descendantButton1_Click(object sender, EventArgs e)
        {
            var test = descendantsGroupBox.DescendantsOfTextBoxes();
            
            MessageBox.Show(descendantsGroupBox.DescendantsOfButtons().Select(button => button.Text).ToArray().ToDelimitedString("\n"));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
