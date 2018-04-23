using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace EmptyWinApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.productReportsTableAdapter.Fill(this.productReports._ProductReports);
        }
        private void pivotGridControl1_FieldFilterChanging(object sender,
                PivotFieldFilterChangingEventArgs e) {
            if(object.ReferenceEquals(e.Field, fieldCategoryName)) {
                if((e.Field.FilterValues.FilterType == PivotFilterType.Excluded && 
                        e.Values.Contains("Beverages")) ||
                    (e.Field.FilterValues.FilterType == PivotFilterType.Included &&
                        !e.Values.Contains("Beverages"))) {
                    MessageBox.Show("You are not allowed to hide the 'Beverages' value.");
                    e.Cancel = true;
                }
            }
        }
    }
}