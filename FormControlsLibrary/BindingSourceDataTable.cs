using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Windows.Forms;

namespace FormControlsLibrary
{
    public class BindingSourceDataTable : BindingSource
    {
        public BindingSourceDataTable(IContainer container) : base(container)
        {
        }
        public BindingSourceDataTable() : base()
        {
        }
        public BindingSourceDataTable(object datasource, string datamember) : base(datasource, datamember)
        {
        }
        public new DataTable DataSource { get; set; }
        public ContainerControl ContainerControl { get; set; } = null;
        public override ISite Site
        {
            get => base.Site;
            set
            {
                base.Site = value;

                if (value?.GetService(typeof(IDesignerHost)) is IDesignerHost host)
                {
                    var componentHost = host.RootComponent;
                    if (componentHost is ContainerControl)
                    {
                        ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }
    }
}
