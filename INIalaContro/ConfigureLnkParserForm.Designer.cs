
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
			this.executableLabel = new System.Windows.Forms.Label();
			this.argumentsLabel = new System.Windows.Forms.Label();
			this.regexLabel = new System.Windows.Forms.Label();
			this.groupLabel = new System.Windows.Forms.Label();
			this.regexTextBox = new System.Windows.Forms.TextBox();
			this.groupTextBox = new System.Windows.Forms.TextBox();
			this.argumentsTextBox = new System.Windows.Forms.TextBox();
			this.executablePathButton = new System.Windows.Forms.Button();
			this.okButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.okButton = new System.Windows.Forms.Button();
			this.lnkTableLayoutPanel.SuspendLayout();
			this.okButtonTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// lnkTableLayoutPanel
			// 
			this.lnkTableLayoutPanel.ColumnCount = 2;
			this.lnkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.lnkTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.lnkTableLayoutPanel.Controls.Add(this.executableLabel, 0, 0);
			this.lnkTableLayoutPanel.Controls.Add(this.argumentsLabel, 0, 1);
			this.lnkTableLayoutPanel.Controls.Add(this.regexLabel, 0, 2);
			this.lnkTableLayoutPanel.Controls.Add(this.groupLabel, 0, 3);
			this.lnkTableLayoutPanel.Controls.Add(this.regexTextBox, 1, 2);
			this.lnkTableLayoutPanel.Controls.Add(this.groupTextBox, 1, 3);
			this.lnkTableLayoutPanel.Controls.Add(this.argumentsTextBox, 1, 1);
			this.lnkTableLayoutPanel.Controls.Add(this.executablePathButton, 1, 0);
			this.lnkTableLayoutPanel.Controls.Add(this.okButtonTableLayoutPanel, 0, 4);
			this.lnkTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lnkTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.lnkTableLayoutPanel.Name = "lnkTableLayoutPanel";
			this.lnkTableLayoutPanel.RowCount = 5;
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.lnkTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.lnkTableLayoutPanel.Size = new System.Drawing.Size(288, 159);
			this.lnkTableLayoutPanel.TabIndex = 0;
			// 
			// executableLabel
			// 
			this.executableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.executableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.executableLabel.Location = new System.Drawing.Point(3, 0);
			this.executableLabel.Name = "executableLabel";
			this.executableLabel.Size = new System.Drawing.Size(109, 32);
			this.executableLabel.TabIndex = 0;
			this.executableLabel.Text = "&Executable:";
			this.executableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// argumentsLabel
			// 
			this.argumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.argumentsLabel.Location = new System.Drawing.Point(3, 32);
			this.argumentsLabel.Name = "argumentsLabel";
			this.argumentsLabel.Size = new System.Drawing.Size(109, 32);
			this.argumentsLabel.TabIndex = 1;
			this.argumentsLabel.Text = "&Arguments:";
			this.argumentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// regexLabel
			// 
			this.regexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regexLabel.Location = new System.Drawing.Point(3, 64);
			this.regexLabel.Name = "regexLabel";
			this.regexLabel.Size = new System.Drawing.Size(109, 32);
			this.regexLabel.TabIndex = 2;
			this.regexLabel.Text = "&Regex:";
			this.regexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupLabel
			// 
			this.groupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupLabel.Location = new System.Drawing.Point(3, 96);
			this.groupLabel.Name = "groupLabel";
			this.groupLabel.Size = new System.Drawing.Size(109, 32);
			this.groupLabel.TabIndex = 3;
			this.groupLabel.Text = "Group:";
			this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// regexTextBox
			// 
			this.regexTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regexTextBox.Location = new System.Drawing.Point(118, 67);
			this.regexTextBox.Name = "regexTextBox";
			this.regexTextBox.Size = new System.Drawing.Size(167, 26);
			this.regexTextBox.TabIndex = 2;
			// 
			// groupTextBox
			// 
			this.groupTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupTextBox.Location = new System.Drawing.Point(118, 99);
			this.groupTextBox.Name = "groupTextBox";
			this.groupTextBox.Size = new System.Drawing.Size(167, 26);
			this.groupTextBox.TabIndex = 3;
			// 
			// argumentsTextBox
			// 
			this.argumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.argumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.argumentsTextBox.Location = new System.Drawing.Point(118, 35);
			this.argumentsTextBox.Name = "argumentsTextBox";
			this.argumentsTextBox.Size = new System.Drawing.Size(167, 26);
			this.argumentsTextBox.TabIndex = 1;
			// 
			// executablePathButton
			// 
			this.executablePathButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.executablePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.executablePathButton.Location = new System.Drawing.Point(118, 3);
			this.executablePathButton.Name = "executablePathButton";
			this.executablePathButton.Size = new System.Drawing.Size(167, 26);
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
			this.okButtonTableLayoutPanel.Location = new System.Drawing.Point(0, 128);
			this.okButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.okButtonTableLayoutPanel.Name = "okButtonTableLayoutPanel";
			this.okButtonTableLayoutPanel.RowCount = 1;
			this.okButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.okButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.okButtonTableLayoutPanel.Size = new System.Drawing.Size(288, 31);
			this.okButtonTableLayoutPanel.TabIndex = 4;
			// 
			// okButton
			// 
			this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(73, 1);
			this.okButton.Margin = new System.Windows.Forms.Padding(1);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(142, 29);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "&OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OnOkButtonClick);
			// 
			// ConfigureLnkParserForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 159);
			this.Controls.Add(this.lnkTableLayoutPanel);
			this.Name = "ConfigureLnkParserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configure LNK Parser";
			this.lnkTableLayoutPanel.ResumeLayout(false);
			this.lnkTableLayoutPanel.PerformLayout();
			this.okButtonTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.TableLayoutPanel okButtonTableLayoutPanel;
		private System.Windows.Forms.Button executablePathButton;
		private System.Windows.Forms.TextBox argumentsTextBox;
		private System.Windows.Forms.TextBox groupTextBox;
		private System.Windows.Forms.TextBox regexTextBox;
		private System.Windows.Forms.Label groupLabel;
		private System.Windows.Forms.Label regexLabel;
		private System.Windows.Forms.Label argumentsLabel;
		private System.Windows.Forms.Label executableLabel;
		private System.Windows.Forms.TableLayoutPanel lnkTableLayoutPanel;
	}
}
