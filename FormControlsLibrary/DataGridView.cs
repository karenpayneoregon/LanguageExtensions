using System.Data;

namespace FormControlsLibrary
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataTable DataTable => (DataTable) DataSource;
    }
}
