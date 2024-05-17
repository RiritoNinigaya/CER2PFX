using System;
using System.Windows.Forms;

namespace cerTOpfx
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000023AA File Offset: 0x000005AA
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new mainForm());
		}
	}
}
