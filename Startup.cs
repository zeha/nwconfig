using System;
using System.Windows.Forms;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für Startup.
	/// </summary>
	public class Startup
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			try 
			{
				Application.Run(new formResults());
			} 
			catch (Exception ex)
			{
				Exception ex2 = new Exception("Unhandled Exception detected by Main Thread", ex);
				formException fE = new formException();
				fE.setExceptionData(ex2);
				fE.ShowDialog();
				return;
			} 
		}

	}
}
