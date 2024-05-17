using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace cerTOpfx
{
	// Token: 0x02000002 RID: 2
	public partial class mainForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public mainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000026C
		private void browseButton_Click(object sender, EventArgs e)
		{
			if (this.openCertOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.filePathTextBox.Text = this.openCertOpenFileDialog.FileName;
				this.certificateFileName = this.openCertOpenFileDialog.FileName;
				this.certificatePostfix = this.certificateFileName.Split(new char[]
				{
					'.'
				}).LastOrDefault<string>();
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020DC File Offset: 0x000002DC
		private void convertButton_Click(object sender, EventArgs e)
		{
			X509Certificate x509Certificate = new X509Certificate(this.certificateFileName);
			byte[] bytes = x509Certificate.Export(X509ContentType.Pfx, "!cbiatwt2");
			this.certificateFileName = this.certificateFileName.Replace(this.certificatePostfix, "pfx");
			File.WriteAllBytes(this.certificateFileName, bytes);
			MessageBox.Show("Done");
		}

		// Token: 0x04000001 RID: 1
		private string certificateFileName;

		// Token: 0x04000002 RID: 2
		private string certificatePostfix;
	}
}
