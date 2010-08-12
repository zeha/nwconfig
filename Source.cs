using System;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für Source.
	/// </summary>
	public class Source
	{
		public String File;
		public String ServerName;
		public System.Collections.SortedList Modules;

		public Source(String file)
		{
			File = file;
			Modules = new System.Collections.SortedList();
		}

		public bool ReadData()
		{
			System.IO.StreamReader f = new System.IO.StreamReader(File);
			String[] data;
			String line = null;
			Module thisMod;
			bool haveStart = false;

			{
				line = f.ReadLine();
				String cmp = "Novell File Server Configuration Report For Server: ";
				if (line.StartsWith(cmp))
				{
					ServerName = line.Substring(cmp.Length).Trim();
				}
			}

			while ((line = f.ReadLine()) != null)
			{
				if (haveStart)
				{
					if (line.StartsWith("---"))
						continue;

					if (line.StartsWith("End of Modules List"))
						break;

					// ACPIASL.NLM   v1.00.20         Oct. 29, 2004  ACPI Architecture Services Layer for ACPI compliant systems
					// ACPIASL.NLM   v1.00.15    Dec.  4, 2003  ACPI Architecture Services Layer for ACPI compliant systems
					//line = line.Replace("  "," ");
					//line = line.Replace("  "," ");
					
					char[] seper = new char[1];
					seper[0] = ' ';
 
					data = line.Split(seper, 2);
					if (Modules[data[0]] != null)
					{
						thisMod = (Module)Modules[data[0]];
						thisMod.LoadCount++;
						Modules[data[0]] = thisMod;
						continue;
					}
					thisMod = new Module();
					thisMod.Name = data[0];

					data = data[1].Trim().Split(seper, 2);

					// can also look like:       blah.nlm                               blah.nlm
					// if it looks normal, get a version string and a date
					if (data.Length > 1)
					{
						thisMod.Version = data[0];

						data = data[1].Trim().Split(seper, 2);
						if (data.Length > 1)
						{ // process date
							String day; String month; String year;

							month = data[0];

							data = data[1].Trim().Split(seper, 2);
							day = data[0];

							data = data[1].Trim().Split(seper, 2);
							year = data[0];

							thisMod.Date = month + " " + day + " " + year;
						}
						thisMod.Description = data[1].Trim();

					} 
					else 
					{
						thisMod.Version = "";
						thisMod.Date = "";
						thisMod.Description = data[0].Trim();
					}

					thisMod.LoadCount = 1;

					this.Modules.Add(thisMod.Name, thisMod);
				} 
				else 
				{
					// search for start header
					if (line.StartsWith("Top of Modules List"))
					{
						haveStart = true;
					}


				}
			}
			f.Close();
			return true;
		}
	}

	public class Module
	{
		// FileArray(thisItem) = New Object() {Trim(Left(curLine, 12)), versionInfo, yearInfo, monthInfo, dayInfo, copyInfo}
		public String Name;
		public String Version;
		public String Date;
		public String Description;
		public int LoadCount;
	}
}
