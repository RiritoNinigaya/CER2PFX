namespace cerTOpfx
{
	// Token: 0x02000002 RID: 2
	public partial class mainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002138 File Offset: 0x00000338
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002170 File Offset: 0x00000370
		private void InitializeComponent()
		{
			this.filePathTextBox = new global::System.Windows.Forms.TextBox();
			this.browseButton = new global::System.Windows.Forms.Button();
			this.openCertOpenFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.convertButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.filePathTextBox.Enabled = false;
			this.filePathTextBox.Location = new global::System.Drawing.Point(12, 12);
			this.filePathTextBox.Name = "filePathTextBox";
			this.filePathTextBox.Size = new global::System.Drawing.Size(447, 20);
			this.filePathTextBox.TabIndex = 0;
			this.browseButton.Location = new global::System.Drawing.Point(465, 12);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new global::System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new global::System.EventHandler(this.browseButton_Click);
			this.openCertOpenFileDialog.Title = "Select Certificate";
			this.convertButton.Location = new global::System.Drawing.Point(13, 39);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new global::System.Drawing.Size(527, 23);
			this.convertButton.TabIndex = 2;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new global::System.EventHandler(this.convertButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(544, 66);
			base.Controls.Add(this.convertButton);
			base.Controls.Add(this.browseButton);
			base.Controls.Add(this.filePathTextBox);
			base.Name = "mainForm";
			this.Text = "Convert .cer to .pfx";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox filePathTextBox;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button browseButton;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.OpenFileDialog openCertOpenFileDialog;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button convertButton;
	}
}
