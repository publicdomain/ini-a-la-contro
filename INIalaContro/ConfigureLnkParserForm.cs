using System;
using System.Drawing;
using System.Windows.Forms;
using PublicDomain;

namespace INIalaContro
{
    /// <summary>
    /// Description of ConfigureLnkParserForm.
    /// </summary>
    public partial class ConfigureLnkParserForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:INIalaContro.ConfigureLnkParserForm"/> class.
        /// </summary>
        public ConfigureLnkParserForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the executable path button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExecutablePathButtonClick(object sender, EventArgs e)
        {
            // Clear file name
            this.openFileDialog.FileName = string.Empty;

            // Show open file dialog
            this.openFileDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the ok button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOkButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the configure lnk parser form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnConfigureLnkParserFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Executable path
            if (this.openFileDialog.FileName.Length > 0)
            {
                ((MainForm)this.Owner).SettingsData.ExecutablePath = this.openFileDialog.FileName;
            }

            // Arguments
            if (this.argumentsTextBox.Text.Length > 0)
            {
                ((MainForm)this.Owner).SettingsData.Arguments = this.argumentsTextBox.Text;
            }

            // Regex
            if (this.regexTextBox.Text.Length > 0)
            {
                ((MainForm)this.Owner).SettingsData.Regex = this.regexTextBox.Text;
            }

            // Group
            ((MainForm)this.Owner).SettingsData.Group = (int)this.groupNumericUpDown.Value;
        }
    }
}

