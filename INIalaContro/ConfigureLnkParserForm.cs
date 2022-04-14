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
            // Show open file dialog
            this.executableOpenFileDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the script path button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnScriptPathButtonClick(object sender, EventArgs e)
        {
            // Show open file dialog
            this.scriptOpenFileDialog.ShowDialog();
        }

        /// <summary>
        /// Handles the ok button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOkButtonClick(object sender, EventArgs e)
        {
            // Close dialog
            this.Close();
        }

        /// <summary>
        /// Handles the configure lnk parser form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnConfigureLnkParserFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // Executable path
            ((MainForm)this.Owner).SettingsData.ExecutablePath = this.executableOpenFileDialog.FileName.Length > 0 ? this.executableOpenFileDialog.FileName : string.Empty;

            // Script ṕath
            ((MainForm)this.Owner).SettingsData.ScriptPath = this.scriptOpenFileDialog.FileName.Length > 0 ? this.scriptOpenFileDialog.FileName : string.Empty;
        }

        /// <summary>
        /// Handles the configure lnk parser form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnConfigureLnkParserFormLoad(object sender, EventArgs e)
        {
            // Set GUI by settings data
            this.executableOpenFileDialog.FileName = ((MainForm)this.Owner).SettingsData.ExecutablePath;
            this.scriptOpenFileDialog.FileName = ((MainForm)this.Owner).SettingsData.ScriptPath;
        }
    }
}

