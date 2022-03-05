
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
        /// The settings data.
        /// </summary>
        SettingsData settingsData = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:INIalaContro.ConfigureLnkParserForm"/> class.
        /// </summary>
        /// <param name="settingsData">Settings data.</param>
        public ConfigureLnkParserForm(SettingsData settingsData)
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set settings data
            this.SettingsData = settingsData;
        }

        /// <summary>
        /// Gets or sets the settings data.
        /// </summary>
        /// <value>The settings data.</value>
        public SettingsData SettingsData { get => settingsData; set => settingsData = value; }

        /// <summary>
        /// Handles the executable path button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExecutablePathButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
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
    }
}
