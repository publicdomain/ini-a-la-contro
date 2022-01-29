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
    using System.Windows.Forms;
    using Blez;

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
        /// Initializes a new instance of the <see cref="T:INIalaContro.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
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
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
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
