using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace FormControlsLibrary
{

    [ToolboxItem(true)]
    [ProvideProperty("MissingBackColor", "System.Windows.Forms.TextBox")]
    public partial class RequiredFieldsChecker : Component, IExtenderProvider
    {
        public RequiredFieldsChecker(IContainer container)
        {
            container.Add(this);
        }

        // We can only extend TextBoxes.
        public bool CanExtend(object extendee)
        {
            return (extendee is TextBox);
        }

        // The list of our clients and their colors.
        private readonly List<TextBox> _clients = new List<TextBox>();
        private readonly Dictionary<TextBox, Color> _missingColors = new Dictionary<TextBox, Color>();
        private readonly Dictionary<TextBox, Color> _presentColors = new Dictionary<TextBox, Color>();

        // Implement the MissingBackColor extension property.
        // Return this client's MissingBackColor value.
        [Category("Appearance")]
        [DefaultValue(null)]
        public Color? GetMissingBackColor(TextBox clientTextBox)
        {
            // Return the control's MissingBackColor if it exists.
            if (_missingColors.ContainsKey(clientTextBox))
            {
                return _missingColors[clientTextBox];
            }

            return null;
        }
        // Set this control's MissingBackColor.
        [Category("Appearance")]
        [DefaultValue(null)]
        public void SetMissingBackColor(TextBox clientTextBox, Color? pMissingBackColor)
        {
            if (pMissingBackColor.HasValue)
            {
                // Save the client's colors.
                _missingColors[clientTextBox] = pMissingBackColor.Value;
                _presentColors[clientTextBox] = clientTextBox.BackColor;

                // If the control isn't already
                // in our client list, add it.
                if (!_clients.Contains(clientTextBox))
                {
                    _clients.Add(clientTextBox);
                    clientTextBox.Validating += Client_Validating;
                }
            }
            else
            {
                // If the client is in our client list, remove it.
                if (_clients.Contains(clientTextBox))
                {
                    _clients.Remove(clientTextBox);
                    _missingColors.Remove(clientTextBox);
                    _presentColors.Remove(clientTextBox);
                    clientTextBox.Validating -= Client_Validating;
                }
            }
        }

        // Display the appropriate BackColor.
        private void Client_Validating(object sender, CancelEventArgs e)
        {
            ValidateClient(sender as TextBox);
        }
        private void ValidateClient(TextBox clientTextBox)
        {
            clientTextBox.BackColor = CorrectColor(clientTextBox);
        }

        // Return the correct color for a TextBox.
        private Color CorrectColor(TextBox clientTextBox)
        {
            if (clientTextBox.Text.Length < 1)
            {
                return _missingColors[clientTextBox];
            }
            else
            {
                return _presentColors[clientTextBox];
            }
        }
        // Return the first required field that is blank.
        public TextBox FirstMissingField()
        {
            // Check all of the fields.
            CheckAllFields();

            // See if any clients are blank.
            foreach (var clientTextBox in _clients)
            {
                if (clientTextBox.Text.Length == 0) return clientTextBox;
            }

            return null;
        }
        // Check all clients now. This is useful
        // for initializing background colors.
        public void CheckAllFields()
        {
            foreach (var clientTextBox in _clients)
            {
                ValidateClient(clientTextBox);
            }
        }
    }
}
