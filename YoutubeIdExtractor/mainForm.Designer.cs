namespace YoutubeIdExtractor
{
	partial class mainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.idLabel = new System.Windows.Forms.Label();
			this.playlistIdTextBox = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.videoIdsTextBox = new System.Windows.Forms.RichTextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.loadButton = new System.Windows.Forms.Button();
			this.readStatisticsCheckbox = new System.Windows.Forms.CheckBox();
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 11;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.Controls.Add(this.idLabel, 1, 1);
			this.mainTableLayoutPanel.Controls.Add(this.playlistIdTextBox, 3, 1);
			this.mainTableLayoutPanel.Controls.Add(this.startButton, 5, 1);
			this.mainTableLayoutPanel.Controls.Add(this.videoIdsTextBox, 1, 3);
			this.mainTableLayoutPanel.Controls.Add(this.saveButton, 7, 1);
			this.mainTableLayoutPanel.Controls.Add(this.loadButton, 9, 1);
			this.mainTableLayoutPanel.Controls.Add(this.videoIdsTextBox, 1, 5);
			this.mainTableLayoutPanel.Controls.Add(this.readStatisticsCheckbox, 3, 3);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 7;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(899, 549);
			this.mainTableLayoutPanel.TabIndex = 0;
			// 
			// idLabel
			// 
			this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(10, 22);
			this.idLabel.Margin = new System.Windows.Forms.Padding(0);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(123, 17);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "Playlist-URL / -ID: ";
			// 
			// playlistIdTextBox
			// 
			this.playlistIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistIdTextBox.Location = new System.Drawing.Point(143, 19);
			this.playlistIdTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.playlistIdTextBox.Name = "playlistIdTextBox";
			this.playlistIdTextBox.Size = new System.Drawing.Size(632, 22);
			this.playlistIdTextBox.TabIndex = 1;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.AutoSize = true;
			this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.startButton.Location = new System.Drawing.Point(532, 10);
			this.startButton.Margin = new System.Windows.Forms.Padding(0);
			this.startButton.Name = "startButton";
			this.startButton.Padding = new System.Windows.Forms.Padding(20, 4, 20, 4);
			this.startButton.Size = new System.Drawing.Size(104, 41);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Los!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// videoIdsTextBox
			// 
			this.videoIdsTextBox.BackColor = System.Drawing.Color.White;
			this.mainTableLayoutPanel.SetColumnSpan(this.videoIdsTextBox, 9);
			this.videoIdsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.videoIdsTextBox.Location = new System.Drawing.Point(10, 92);
			this.videoIdsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.videoIdsTextBox.Name = "videoIdsTextBox";
			this.videoIdsTextBox.ReadOnly = true;
			this.videoIdsTextBox.Size = new System.Drawing.Size(850, 387);
			this.videoIdsTextBox.TabIndex = 3;
			this.videoIdsTextBox.Text = "";
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.AutoSize = true;
			this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveButton.Location = new System.Drawing.Point(678, 10);
			this.saveButton.Margin = new System.Windows.Forms.Padding(0);
			this.saveButton.Name = "saveButton";
			this.saveButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.saveButton.Size = new System.Drawing.Size(95, 29);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Speichern";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
			// 
			// loadButton
			// 
			this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.loadButton.AutoSize = true;
			this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loadButton.Location = new System.Drawing.Point(783, 10);
			this.loadButton.Margin = new System.Windows.Forms.Padding(0);
			this.loadButton.Name = "loadButton";
			this.loadButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.loadButton.Size = new System.Drawing.Size(77, 29);
			this.loadButton.TabIndex = 2;
			this.loadButton.Text = "Laden";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButtonClick);
			// 
			// readStatisticsCheckbox
			// 
			this.readStatisticsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.readStatisticsCheckbox.AutoSize = true;
			this.readStatisticsCheckbox.Location = new System.Drawing.Point(143, 61);
			this.readStatisticsCheckbox.Margin = new System.Windows.Forms.Padding(0);
			this.readStatisticsCheckbox.Name = "readStatisticsCheckbox";
			this.readStatisticsCheckbox.Size = new System.Drawing.Size(632, 21);
			this.readStatisticsCheckbox.TabIndex = 4;
			this.readStatisticsCheckbox.Text = "Statistiken direkt einlesen";
			this.readStatisticsCheckbox.UseVisualStyleBackColor = true;
			// 
			// mainForm
			// 
			this.AcceptButton = this.startButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 446);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Strohis ID-Extractor";
			this.mainTableLayoutPanel.ResumeLayout(false);
			this.mainTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox playlistIdTextBox;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.RichTextBox videoIdsTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.CheckBox readStatisticsCheckbox;
	}
}

