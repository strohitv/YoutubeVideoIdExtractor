namespace YoutubeIdExtractor
{
	partial class loadForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.playlistLabel = new System.Windows.Forms.Label();
			this.playlistComboBox = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.loadButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.showStatisticsCheckBox = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.Controls.Add(this.playlistLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.playlistComboBox, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.showStatisticsCheckBox, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 117);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// playlistLabel
			// 
			this.playlistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistLabel.AutoSize = true;
			this.playlistLabel.Location = new System.Drawing.Point(10, 14);
			this.playlistLabel.Margin = new System.Windows.Forms.Padding(0);
			this.playlistLabel.Name = "playlistLabel";
			this.playlistLabel.Size = new System.Drawing.Size(82, 13);
			this.playlistLabel.TabIndex = 0;
			this.playlistLabel.Text = "Playlist wählen: ";
			// 
			// playlistComboBox
			// 
			this.playlistComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.playlistComboBox.FormattingEnabled = true;
			this.playlistComboBox.Location = new System.Drawing.Point(102, 10);
			this.playlistComboBox.Margin = new System.Windows.Forms.Padding(0);
			this.playlistComboBox.Name = "playlistComboBox";
			this.playlistComboBox.Size = new System.Drawing.Size(251, 21);
			this.playlistComboBox.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
			this.flowLayoutPanel1.Controls.Add(this.loadButton);
			this.flowLayoutPanel1.Controls.Add(this.cancelButton);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 74);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(343, 29);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// loadButton
			// 
			this.loadButton.AutoSize = true;
			this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.loadButton.Location = new System.Drawing.Point(0, 0);
			this.loadButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.loadButton.Name = "loadButton";
			this.loadButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.loadButton.Size = new System.Drawing.Size(77, 29);
			this.loadButton.TabIndex = 0;
			this.loadButton.Text = "Laden";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.AutoSize = true;
			this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(87, 0);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.cancelButton.Size = new System.Drawing.Size(99, 29);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Abbrechen";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// showStatisticsCheckBox
			// 
			this.showStatisticsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.showStatisticsCheckBox.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.showStatisticsCheckBox, 3);
			this.showStatisticsCheckBox.Location = new System.Drawing.Point(13, 44);
			this.showStatisticsCheckBox.Name = "showStatisticsCheckBox";
			this.showStatisticsCheckBox.Size = new System.Drawing.Size(337, 17);
			this.showStatisticsCheckBox.TabIndex = 3;
			this.showStatisticsCheckBox.Text = "Statistiken direkt einlesen";
			this.showStatisticsCheckBox.UseVisualStyleBackColor = true;
			// 
			// loadForm
			// 
			this.AcceptButton = this.loadButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 117);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "loadForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Gespeicherte Playlist laden";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label playlistLabel;
		private System.Windows.Forms.ComboBox playlistComboBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.CheckBox showStatisticsCheckBox;
	}
}