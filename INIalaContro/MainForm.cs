// <copyright file="MainForm.cs" company="PublicDomainWeekly.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace INIalaContro
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using Blez;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The ini contents.
        /// </summary>
        string iniContents = string.Empty;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:INIalaContro.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain weekly tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our site
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=52043.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/ini-a-la-contro");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"ini-file-icon by UXwing - UXwing license{Environment.NewLine}" +
                $"https://uxwing.com/ini-file-icon/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: Contro{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #28, Week #04 @ January 28, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Set general section
                this.iniContents = $"[General]{Environment.NewLine}numRows={Environment.NewLine}numCols={Environment.NewLine}";

                // Declare items list
                List<string> itemList = new List<string>();

                // Declare paths list
                List<string> pathList = new List<string>();

                // Set items 
                foreach (var item in Directory.GetFileSystemEntries(this.folderBrowserDialog.SelectedPath, "*", SearchOption.AllDirectories))
                {
                    // Test for directory
                    if (File.GetAttributes(item).HasFlag(FileAttributes.Directory))
                    {
                        // Directory
                        itemList.Add(Path.GetDirectoryName(item));
                        pathList.Add(item);
                    }
                    else
                    {
                        /* File */

                        // Check for .lnk
                        if (Path.GetExtension(item).ToLowerInvariant() == ".lnk")
                        {
                            // Add shortcut item
                            try
                            {
                                itemList.Add(Path.GetFileNameWithoutExtension(item));
                                pathList.Add(ShortcutTarget.GetShortcutTarget(item));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Shortcut processing error:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        } // Check for .url
                        else if (Path.GetExtension(item).ToLowerInvariant() == ".url")
                        {
                            // Process until URL=
                            foreach (var line in File.ReadAllLines(item))
                            {
                                // Check for a "="
                                if (line.Contains("="))
                                {
                                    // Set KeyValuePair
                                    var keyValue = line.Split(new char[] { '=' });

                                    if (keyValue[0].ToLowerInvariant() == "url")
                                    {
                                        itemList.Add(Path.GetFileNameWithoutExtension(item));
                                        pathList.Add(keyValue[1]);
                                    }
                                }
                            }
                        } // Process other files
                        else
                        {
                            itemList.Add(Path.GetFileName(item));
                            pathList.Add(item);
                        }
                    }
                }

                /* Titles */

                // Set titles section
                this.iniContents += $"[Titles]{Environment.NewLine}";

                // Add items
                for (int i = 0; i < itemList.Count; i++)
                {
                    this.iniContents += $"Title{i + 1}={itemList[i]}{Environment.NewLine}";
                }

                /* Paths */

                // Set titles section
                this.iniContents += $"[Paths]{Environment.NewLine}";

                // Add items
                for (int i = 0; i < itemList.Count; i++)
                {
                    this.iniContents += $"Path{i + 1}={pathList[i]}{Environment.NewLine}";
                }

                // Set processed items in status
                this.processedCountToolStripStatusLabel.Text = itemList.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the copy button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyButtonClick(object sender, EventArgs e)
        {
            // TODO Check there's something to work with [Can be made DRY]
            if (this.iniContents.Length == 0)
            {
                // Advise user
                MessageBox.Show("Please set target directory.", "Missng folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Copy ini file contents
                Clipboard.Clear();
                Clipboard.SetText(this.iniContents);

                // Advise user
                MessageBox.Show("Ini file contents have bee copied..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the save button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            // TODO Check there's something to work with [Can be made DRY]
            if (this.iniContents.Length == 0)
            {
                // Advise user
                MessageBox.Show("Please set target directory.", "Missng folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {// Reset save file dialog
                this.saveFileDialog.FileName = string.Empty;

                // Open save file dialog
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.saveFileDialog.FileName.Length > 0)
                {
                    try
                    {
                        // Save to file
                        File.WriteAllText(this.saveFileDialog.FileName, this.iniContents);
                    }
                    catch (Exception exception)
                    {
                        // Inform user
                        MessageBox.Show($"Error when saving to \"{Path.GetFileName(this.saveFileDialog.FileName)}\":{Environment.NewLine}{exception.Message}", "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Inform user
                    MessageBox.Show($"Saved {this.processedCountToolStripStatusLabel.Text} items to \"{Path.GetFileName(this.saveFileDialog.FileName)}\"", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
