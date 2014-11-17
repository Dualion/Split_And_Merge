using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_And_Merge
{
    static class Program
    {
		//private static bool bOk = false;
		//private static string path = "";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
		static void Main(string[] Args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			//if (Args != null)
			//	if (Args.Length > 0)
			//		if (Args[0] != "")
			//		{
			//			try
			//			{
			//				FileInfo fi = new FileInfo(Args[0]);
			//				bOk = fi.Exists;
			//			}
			//			catch (System.IO.FileNotFoundException) { MessageBox.Show("The file \"" + Args[0] + "\" could not be found."); return; }
			//			catch (Exception Ex) { MessageBox.Show("The file \"" + Args[0] + "\" could not be loaded.\n\nError Message:\n" + Ex.Message); return; }

			//			if (!bOk)
			//			{ MessageBox.Show("The file \"" + Args[0] + "\" is not a valid file."); return; }
			//			path = Args[0];
			//		}

			Application.Run(new Split());
        }
    }
}
