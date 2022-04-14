
namespace INIalaContro
{
	partial class ConfigureLnkParserForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lnkTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.scriptPathButton = new System.Windows.Forms.Button();
			this.executableLabel = new System.Windows.Forms.Label();
			this.scriptFileLabel = new System.Windows.Forms.Label();
			this.executablePathButton = new System.Windows.Forms.Button();
			this.okButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.okButton = new System.Windows.Forms.Button();
			this.executableOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.scriptOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.lnkTableLayoutPanel.SuspendLayout();
			this.okButtonTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lnkTableLayoutPanel
			// 
			this.lnkTableLayoutPanel.ColumnCount = 2;
			this.lnkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.lnkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.lnkTableLayoutPanel.Controls.Add(this.scriptPathButton, 1, 1);
			this.lnkTableLayoutPanel.Controls.Add(this.executableLabel, 0, 0);
			this.lnkTableLayoutPanel.Controls.Add(this.scriptFileLabel, 0, 1);
			this.lnkTableLayoutPanel.Controls.Add(this.executablePathButton, 1, 0);
			this.lnkTableLayoutPanel.Controls.Add(this.okButtonTableLayoutPanel, 0, 2);
			this.lnkTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lnkTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.lnkTableLayoutPanel.Name = "lnkTableLayoutPanel";
			this.lnkTableLayoutPanel.RowCount = 3;
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.lnkTableLayoutPanel.Size = new System.Drawing.Size(288, 106);
			this.lnkTableLayoutPanel.TabIndex = 0;
			// 
			// scriptPathButton
			// 
			this.scriptPathButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scriptPathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scriptPathButton.Location = new System.Drawing.Point(118, 41);
			this.scriptPathButton.Name = "scriptPathButton";
			this.scriptPathButton.Size = new System.Drawing.Size(167, 32);
			this.scriptPathButton.TabIndex = 5;
			this.scriptPathButton.Text = "Browse for &script";
			this.scriptPathButton.UseVisualStyleBackColor = true;
			this.scriptPathButton.Click += new System.EventHandler(this.OnScriptPathButtonClick);
			// 
			// executableLabel
			// 
			this.executableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.executableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.executableLabel.Location = new System.Drawing.Point(3, 0);
			this.executableLabel.Name = "executableLabel";
			this.executableLabel.Size = new System.Drawing.Size(109, 38);
			this.executableLabel.TabIndex = 0;
			this.executableLabel.Text = "&Executable:";
			this.executableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// scriptFileLabel
			// 
			this.scriptFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scriptFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scriptFileLabel.Location = new System.Drawing.Point(3, 38);
			this.scriptFileLabel.Name = "scriptFileLabel";
			this.scriptFileLabel.Size = new System.Drawing.Size(109, 38);
			this.scriptFileLabel.TabIndex = 1;
			this.scriptFileLabel.Text = "&Script file:";
			this.scriptFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// executablePathButton
			// 
			this.executablePathButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.executablePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.executablePathButton.Location = new System.Drawing.Point(118, 3);
			this.executablePathButton.Name = "executablePathButton";
			this.executablePathButton.Size = new System.Drawing.Size(167, 32);
			this.executablePathButton.TabIndex = 0;
			this.executablePathButton.Text = "&Browse for .exe";
			this.executablePathButton.UseVisualStyleBackColor = true;
			this.executablePathButton.Click += new System.EventHandler(this.OnExecutablePathButtonClick);
			// 
			// okButtonTableLayoutPanel
			// 
			this.okButtonTableLayoutPanel.ColumnCount = 3;
			this.lnkTableLayoutPanel.SetColumnSpan(this.okButtonTableLayoutPanel, 2);
			this.okButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.okButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.okButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.okButtonTableLayoutPanel.Controls.Add(this.okButton, 1, 0);
			this.okButtonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.okButtonTableLayoutPanel.Location = new System.Drawing.Point(0, 76);
			this.okButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.okButtonTableLayoutPanel.Name = "okButtonTableLayoutPanel";
			this.okButtonTableLayoutPanel.RowCount = 1;
			this.okButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.okButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.okButtonTableLayoutPanel.Size = new System.Drawing.Size(288, 30);
			this.okButtonTableLayoutPanel.TabIndex = 4;
			// 
			// okButton
			// 
			this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(73, 1);
			this.okButton.Margin = new System.Windows.Forms.Padding(1);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(142, 28);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "&OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OnOkButtonClick);
			// 
			// executableOpenFileDialog
			// 
			this.executableOpenFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
			this.executableOpenFileDialog.Title = "Executable path";
			// 
			// scriptOpenFileDialog
			// 
			this.scriptOpenFileDialog.Filter = "All Files (*.*)|*.*";
			this.scriptOpenFileDialog.Title = "Script path";
			// 
			// ConfigureLnkParserForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 106);
			this.Controls.Add(this.lnkTableLayoutPanel);
			this.Name = "ConfigureLnkParserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configure LNK Parser";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnConfigureLnkParserFormFormClosing);
			this.Load += new System.EventHandler(this.OnConfigureLnkParserFormLoad);
			this.lnkTableLayoutPanel.ResumeLayout(false);
			this.okButtonTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog scriptOpenFileDialog;
		private System.Windows.Forms.Button scriptPathButton;
		private System.Windows.Forms.OpenFileDialog executableOpenFileDialog;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TableLayoutPanel okButtonTableLayoutPanel;
		private System.Windows.Forms.Button executablePathButton;
		private System.Windows.Forms.Label scriptFileLabel;
		private System.Windows.Forms.Label executableLabel;
		private System.Windows.Forms.TableLayoutPanel lnkTableLayoutPanel;
	}
}
