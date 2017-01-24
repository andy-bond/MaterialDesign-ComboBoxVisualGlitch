// Author:  Andy Bond
// Date:    1/3/17

using System.Windows.Controls;

namespace MaterialDesign_ComboBoxVisualGlitch
{
    /// <summary>
    /// Interaction logic for Settings_ReportSettings.xaml
    /// </summary>
    public partial class Settings_ReportSettings : UserControl
    {

        #region Constructor

        // Constructor
        public Settings_ReportSettings()
        {
            InitializeComponent();

            // Initialize FileType ComboBox Selection
            // ISSUE: The correct item is selected, however, the item does not appear in the combobox when the control loads
            // after the combobox is dropped down, you will note the correctly selected item will appear and all selected items appear correctly if clicked
            foreach (ComboBoxItem cbi in FileType_CB.Items)
            {
                if (cbi.Name == Properties.Settings.Default.FileTypeSelection)
                {
                    cbi.IsSelected = true;
                    break;
                }
            }
        }

        #endregion

        #region Events

        // Occurs when Selection Changes in FileType ComboBox
        private void FileType_CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FileType_CB.SelectedItem != null)
            {
                Properties.Settings.Default.FileTypeSelection = ((ComboBoxItem)FileType_CB.SelectedItem).Name;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

    }
}
