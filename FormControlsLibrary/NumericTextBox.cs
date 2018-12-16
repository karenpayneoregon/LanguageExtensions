using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormControlsLibrary
{
    /// <summary>
    /// TODO Needs numeric value property
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    [ToolboxItem(true)]
    public class NumericTextBox : TextBox
    {
		public NumericTextBox()
        {
            MaxLength = 7;
            TextAlign = HorizontalAlignment.Right;
        }

        /// <summary>
        /// Only allow digits to be entered and backspace to be pressed.
        /// </summary>
        /// <param name="e">The event arguments</param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This is overridden to validate pasted text
        /// </summary>
        /// <param name="message">The message</param>
        /// <remarks>If the pasted text contains any non-numeric characters it will not be pasted into the control</remarks>
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x0302)
            {
                var text = (string)Clipboard.GetDataObject()?.GetData(typeof(string));

                if (Regex.IsMatch(text, "[^0-9]"))
                {
                    return;
                }
            }

            base.WndProc(ref message);
        }

        /// <summary>
        /// This is overridden to treat Enter like Tab
        /// </summary>
        /// <param name="keyData">The dialog key to process</param>
        /// <returns>True if handled, false if not</returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if ((keyData & Keys.KeyCode) == Keys.Enter && Parent.SelectNextControl(this,(keyData & Keys.Shift) == Keys.None, true, true, true))
            {
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

    }
}
