using System;
using System.Windows.Forms;
using KeyAuth;

namespace injector
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000225F File Offset: 0x0000045F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		// Token: 0x04000037 RID: 55
		public static string GameFolder;
	}
}
