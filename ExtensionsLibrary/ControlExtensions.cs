using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Windows Forms control extensions
    /// </summary>
    public static class ControlExtensions
    {
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        /// <summary>
        /// Provides watermark effect
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="watermarkText">Water mark to set when the TextBox has no content</param>
        public static void SetWatermark(this TextBox sender, string watermarkText)
        {
            SendMessage(sender.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        /// <summary>
        /// Get a collection of TextBox controls within a control.
        /// </summary>
        /// <param name="sender">Control to traverse</param>
        /// <returns>List of TextBox</returns>
        public static List<TextBox> DescendantsOfTextBoxes(this Control sender)
        {
            return sender.Descendants<TextBox>().ToList();
        }
        /// <summary>
        /// Get a collection of TextBox controls within a control.
        /// </summary>
        /// <param name="sender">Control to traverse</param>
        /// <returns>List of TextBox</returns>
        public static List<Button> DescendantsOfButtons(this Control sender)
        {
            return sender.Descendants<Button>().ToList();
        }
        /// <summary>
        /// Get the selected RadioButton in the control. If there is no Radio buttons an exception is thrown and
        /// if none are selected null is returned.
        /// </summary>
        /// <param name="sender">Control to work against</param>
        /// <returns>The selected RadioButton or throws a runtime exception</returns>
        public static RadioButton SelectedRadioButton(this Control sender)
        {
            return sender.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
        }
        /// <summary>
        /// Determine if control has any Radio button controls
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>True if the control has any RadioButton controls</returns>
        /// <remarks>
        /// Does not check child controls, <see cref="Descendants"/> can be used for this.
        /// </remarks>
        public static bool HasRadioButtons(this Control sender)
        {
            return sender.Controls.OfType<Control>().Any(c => c is RadioButton);
        }
        /// <summary>
        /// Get int value for a TextBox.
        /// </summary>
        /// <param name="sender">TextBox to work against</param>
        /// <returns>An int or if unable to convert 0</returns>
        /// <remarks>
        /// This extension is weak in that if the value can not be converted to an int
        /// then a default value of 0 is returned. 
        /// </remarks>
        public static int IntValue(this TextBox sender)
        {
            return int.TryParse(sender.Text, out var valueResult) ? valueResult : 0;
        }
        /// <summary>
        /// Get int value for a TextBox.
        /// </summary>
        /// <param name="sender">TextBox to work against</param>
        /// <returns>A decimal or if unable to convert 0</returns>
        /// <remarks>
        /// This extension is weak in that if the value can not be converted to a decimal
        /// then a default value of 0 is returned. 
        /// </remarks>
        public static decimal DecimalValue(this TextBox sender)
        {
            return decimal.TryParse(sender.Text, out var valueResult) ? valueResult : 0;
        }
    }
}
