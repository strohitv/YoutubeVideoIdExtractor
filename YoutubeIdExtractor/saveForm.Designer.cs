namespace YoutubeIdExtractor
{
	partial class saveForm
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.playlistLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.playlistTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
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
			this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.playlistLabel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.playlistTextBox, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 5);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 114);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// nameLabel
			// 
			this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(10, 13);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(93, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Name: ";
			// 
			// playlistLabel
			// 
			this.playlistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistLabel.AutoSize = true;
			this.playlistLabel.Location = new System.Drawing.Point(10, 43);
			this.playlistLabel.Margin = new System.Windows.Forms.Padding(0);
			this.playlistLabel.Name = "playlistLabel";
			this.playlistLabel.Size = new System.Drawing.Size(93, 13);
			this.playlistLabel.TabIndex = 1;
			this.playlistLabel.Text = "Playlist-Link / -ID: ";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Location = new System.Drawing.Point(113, 10);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(342, 20);
			this.nameTextBox.TabIndex = 2;
			// 
			// playlistTextBox
			// 
			this.playlistTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.playlistTextBox.Location = new System.Drawing.Point(113, 40);
			this.playlistTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.playlistTextBox.Name = "playlistTextBox";
			this.playlistTextBox.Size = new System.Drawing.Size(342, 20);
			this.playlistTextBox.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
			this.flowLayoutPanel1.Controls.Add(this.saveButton);
			this.flowLayoutPanel1.Controls.Add(this.cancelButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 70);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 29);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.saveButton.AutoSize = true;
			this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.Location = new System.Drawing.Point(0, 0);
			this.saveButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.saveButton.Name = "saveButton";
			this.saveButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.saveButton.Size = new System.Drawing.Size(95, 29);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Speichern";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cancelButton.AutoSize = true;
			this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(105, 0);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
			this.cancelButton.Size = new System.Drawing.Size(99, 29);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Abbrechen";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// saveForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 114);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "saveForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Neue Playlist hinzufügen";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label playlistLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox playlistTextBox;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
	}
}