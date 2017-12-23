using System.Windows.Forms;

namespace SampleApp.ViewHelpers {

    public static class DataGridViewHelper {

        public static void SetDGVProperties(DataGridView dgv) {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.MultiSelect = true;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv.RowHeadersVisible = false;

            // https://stackoverflow.com/questions/252689/why-does-the-doublebuffered-property-default-to-false-on-a-datagridview-and-why#254874
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                                              System.Reflection.BindingFlags.NonPublic |
                                              System.Reflection.BindingFlags.Instance |
                                              System.Reflection.BindingFlags.SetProperty,
                                              null,
                                              dgv,
                                              new object[] { true });
        }

    }
}
