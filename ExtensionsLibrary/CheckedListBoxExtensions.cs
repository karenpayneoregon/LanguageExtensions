using System.Linq;
using System.Windows.Forms;

namespace ExtensionsLibrary
{
    /// <summary>
    /// Contains language extensions for CheckedListBox
    /// </summary>
    public static class CheckedListBoxExtensions
    {
        /// <summary>
        /// Find item, set check state
        /// </summary>
        /// <param name="sender">CheckedListBox</param>
        /// <param name="pText">text to locate case insensitive</param>
        /// <param name="pChecked">set check state to</param>
        public static void FindItemAndSetChecked(this CheckedListBox sender, string pText, bool pChecked)
        {
            var result = sender.Items.Cast<string>().Select((item, index) => new {Item = item, Index = index}).FirstOrDefault(@this => @this.Item.ToLower() == pText.ToLower());

            if (result != null)
            {
                sender.SetItemChecked(result.Index, pChecked);
            }
        }
    }
}
