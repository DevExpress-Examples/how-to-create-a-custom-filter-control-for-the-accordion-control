using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace WindowsFormsApp7 {
    public partial class CustomFilterControl : XtraUserControl, IFilterContent {
        public CustomFilterControl() {
            InitializeComponent();
            this.cbEdit.EditValueChanged += TextEdit1_EditValueChanged;
        }

        object IFilterContent.FilterValue { get { return this.cbEdit.EditValue; } }
        Control IFilterContent.Control { get { return this; } }
        UserLookAndFeel IFilterContent.LookAndFeel { get { return LookAndFeel; } }

        object changed = new object();
        private void TextEdit1_EditValueChanged(object sender, EventArgs e) {
            EventHandler handler = Events[changed] as EventHandler;
            if(handler != null) handler(this, EventArgs.Empty);
        }
        event EventHandler IFilterContent.FilterValueChanged {
            add { Events.AddHandler(changed, value); }
            remove { Events.RemoveHandler(changed, value); }
        }
        // Update any colors when the skin is changed.
        void IFilterContent.UpdateAppearance() { }
        // Update layout of controls when the size is changed.
        void IFilterContent.UpdateLayout() { 
            // For example, update the combobox bounds.
            this.cbEdit.Bounds = new Rectangle(20, (Height - this.cbEdit.Height) / 2, Width - 40, this.cbEdit.Height);
        }
    }
}
