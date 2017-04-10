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
			this.mainTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 7;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.Controls.Add(this.idLabel, 1, 1);
			this.mainTableLayoutPanel.Controls.Add(this.playlistIdTextBox, 3, 1);
			this.mainTableLayoutPanel.Controls.Add(this.startButton, 5, 1);
			this.mainTableLayoutPanel.Controls.Add(this.videoIdsTextBox, 1, 3);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 5;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(674, 446);
			this.mainTableLayoutPanel.TabIndex = 0;
			// 
			// idLabel
			// 
			this.idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(10, 18);
			this.idLabel.Margin = new System.Windows.Forms.Padding(0);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(95, 13);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "Playlist-URL / -ID: ";
			// 
			// playlistIdTextBox
			// 
			this.playlistIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistIdTextBox.Location = new System.Drawing.Point(115, 14);
			this.playlistIdTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.playlistIdTextBox.Name = "playlistIdTextBox";
			this.playlistIdTextBox.Size = new System.Drawing.Size(403, 20);
			this.playlistIdTextBox.TabIndex = 1;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.AutoSize = true;
			this.startButton.Location = new System.Drawing.Point(528, 10);
			this.startButton.Margin = new System.Windows.Forms.Padding(0);
			this.startButton.Name = "startButton";
			this.startButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.startButton.Size = new System.Drawing.Size(136, 29);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "IDs heraussuchen!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// videoIdsTextBox
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.videoIdsTextBox, 5);
			this.videoIdsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.videoIdsTextBox.Location = new System.Drawing.Point(10, 49);
			this.videoIdsTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.videoIdsTextBox.Name = "videoIdsTextBox";
			this.videoIdsTextBox.Size = new System.Drawing.Size(654, 387);
			this.videoIdsTextBox.TabIndex = 3;
			this.videoIdsTextBox.Text = "";
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 446);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Name = "mainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Video-IDs aus Playlisten heraussuchen!";
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
	}
}

