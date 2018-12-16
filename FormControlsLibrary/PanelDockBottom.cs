using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControlsLibrary
{
    [ToolboxBitmap(typeof(Panel))]
    [ToolboxItem(true)]
    public sealed class PanelDockBottom : Panel
    {
        public PanelDockBottom()
        {
            Size = new System.Drawing.Size(1, 48);
            Dock = DockStyle.Bottom;
        }
    }
}
