using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für formResults.
	/// </summary>
	public class formResults : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFile_Open;
		private System.Windows.Forms.MenuItem menuFile_Quit;
		private System.Windows.Forms.ListView listItems;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupServer1;
		private System.Windows.Forms.Label labelServer1Text;
		private System.Windows.Forms.GroupBox groupServer2;
		private System.Windows.Forms.Label labelServer2Text;
		private System.Windows.Forms.ColumnHeader col02Version;
		private System.Windows.Forms.ColumnHeader colDescription;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader col01Version;
		private System.Windows.Forms.CheckBox chkEquals;
		private System.Windows.Forms.CheckBox chkMissing;
		private System.Windows.Forms.CheckBox chkConflicts;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelp_Info;
		private System.Windows.Forms.MenuItem menuSeperator01;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formResults()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			this.groupServer1.Text = "";
			this.groupServer2.Text = "";

			System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
			this.Text = "hofstaedtler.config " + a.GetName().Version.ToString();

		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFile_Open = new System.Windows.Forms.MenuItem();
			this.menuSeperator01 = new System.Windows.Forms.MenuItem();
			this.menuFile_Quit = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelp_Info = new System.Windows.Forms.MenuItem();
			this.listItems = new System.Windows.Forms.ListView();
			this.colName = new System.Windows.Forms.ColumnHeader();
			this.col01Version = new System.Windows.Forms.ColumnHeader();
			this.col02Version = new System.Windows.Forms.ColumnHeader();
			this.colDescription = new System.Windows.Forms.ColumnHeader();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelStatus = new System.Windows.Forms.Label();
			this.chkConflicts = new System.Windows.Forms.CheckBox();
			this.chkMissing = new System.Windows.Forms.CheckBox();
			this.chkEquals = new System.Windows.Forms.CheckBox();
			this.groupServer2 = new System.Windows.Forms.GroupBox();
			this.labelServer2Text = new System.Windows.Forms.Label();
			this.groupServer1 = new System.Windows.Forms.GroupBox();
			this.labelServer1Text = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupServer2.SuspendLayout();
			this.groupServer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFile_Open,
																					 this.menuSeperator01,
																					 this.menuFile_Quit});
			this.menuFile.Text = "&Datei";
			// 
			// menuFile_Open
			// 
			this.menuFile_Open.Index = 0;
			this.menuFile_Open.Text = "Öf&fnen ...";
			this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
			// 
			// menuSeperator01
			// 
			this.menuSeperator01.Index = 1;
			this.menuSeperator01.Text = "-";
			// 
			// menuFile_Quit
			// 
			this.menuFile_Quit.Index = 2;
			this.menuFile_Quit.Text = "B&eenden";
			this.menuFile_Quit.Click += new System.EventHandler(this.menuFile_Quit_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 1;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuHelp_Info});
			this.menuHelp.Text = "&?";
			// 
			// menuHelp_Info
			// 
			this.menuHelp_Info.Index = 0;
			this.menuHelp_Info.Text = "&Info ...";
			this.menuHelp_Info.Click += new System.EventHandler(this.menuHelp_Info_Click);
			// 
			// listItems
			// 
			this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.colName,
																						this.col01Version,
																						this.col02Version,
																						this.colDescription});
			this.listItems.FullRowSelect = true;
			this.listItems.GridLines = true;
			this.listItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listItems.HideSelection = false;
			this.listItems.Location = new System.Drawing.Point(0, 0);
			this.listItems.MultiSelect = false;
			this.listItems.Name = "listItems";
			this.listItems.Size = new System.Drawing.Size(864, 412);
			this.listItems.TabIndex = 0;
			this.listItems.View = System.Windows.Forms.View.Details;
			this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 120;
			// 
			// col01Version
			// 
			this.col01Version.Text = "Version";
			this.col01Version.Width = 90;
			// 
			// col02Version
			// 
			this.col02Version.Text = "Version";
			this.col02Version.Width = 90;
			// 
			// colDescription
			// 
			this.colDescription.Text = "Description";
			this.colDescription.Width = 400;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.labelStatus);
			this.panel1.Controls.Add(this.chkConflicts);
			this.panel1.Controls.Add(this.chkMissing);
			this.panel1.Controls.Add(this.chkEquals);
			this.panel1.Controls.Add(this.groupServer2);
			this.panel1.Controls.Add(this.groupServer1);
			this.panel1.Location = new System.Drawing.Point(0, 416);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(864, 112);
			this.panel1.TabIndex = 3;
			// 
			// labelStatus
			// 
			this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelStatus.Location = new System.Drawing.Point(384, 8);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(100, 24);
			this.labelStatus.TabIndex = 8;
			this.labelStatus.Text = "-status-";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// chkConflicts
			// 
			this.chkConflicts.Checked = true;
			this.chkConflicts.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConflicts.Location = new System.Drawing.Point(144, 8);
			this.chkConflicts.Name = "chkConflicts";
			this.chkConflicts.Size = new System.Drawing.Size(72, 16);
			this.chkConflicts.TabIndex = 6;
			this.chkConflicts.Text = "Ungleich";
			this.chkConflicts.CheckedChanged += new System.EventHandler(this.chkConflicts_CheckedChanged);
			// 
			// chkMissing
			// 
			this.chkMissing.Checked = true;
			this.chkMissing.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkMissing.Location = new System.Drawing.Point(224, 8);
			this.chkMissing.Name = "chkMissing";
			this.chkMissing.Size = new System.Drawing.Size(72, 16);
			this.chkMissing.TabIndex = 5;
			this.chkMissing.Text = "Fehlend";
			this.chkMissing.CheckedChanged += new System.EventHandler(this.chkMissing_CheckedChanged);
			// 
			// chkEquals
			// 
			this.chkEquals.Checked = true;
			this.chkEquals.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEquals.Location = new System.Drawing.Point(64, 8);
			this.chkEquals.Name = "chkEquals";
			this.chkEquals.Size = new System.Drawing.Size(72, 16);
			this.chkEquals.TabIndex = 4;
			this.chkEquals.Text = "Gleich";
			this.chkEquals.CheckedChanged += new System.EventHandler(this.chkEquals_CheckedChanged);
			// 
			// groupServer2
			// 
			this.groupServer2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.groupServer2.Controls.Add(this.labelServer2Text);
			this.groupServer2.Location = new System.Drawing.Point(440, 32);
			this.groupServer2.Name = "groupServer2";
			this.groupServer2.Size = new System.Drawing.Size(416, 72);
			this.groupServer2.TabIndex = 3;
			this.groupServer2.TabStop = false;
			this.groupServer2.Text = "Server xxx";
			// 
			// labelServer2Text
			// 
			this.labelServer2Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelServer2Text.Location = new System.Drawing.Point(3, 16);
			this.labelServer2Text.Name = "labelServer2Text";
			this.labelServer2Text.Size = new System.Drawing.Size(410, 53);
			this.labelServer2Text.TabIndex = 1;
			// 
			// groupServer1
			// 
			this.groupServer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.groupServer1.Controls.Add(this.labelServer1Text);
			this.groupServer1.Location = new System.Drawing.Point(8, 32);
			this.groupServer1.Name = "groupServer1";
			this.groupServer1.Size = new System.Drawing.Size(416, 72);
			this.groupServer1.TabIndex = 2;
			this.groupServer1.TabStop = false;
			this.groupServer1.Text = "Server xxx";
			// 
			// labelServer1Text
			// 
			this.labelServer1Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelServer1Text.Location = new System.Drawing.Point(3, 16);
			this.labelServer1Text.Name = "labelServer1Text";
			this.labelServer1Text.Size = new System.Drawing.Size(410, 53);
			this.labelServer1Text.TabIndex = 0;
			// 
			// formResults
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(864, 529);
			this.Controls.Add(this.listItems);
			this.Controls.Add(this.panel1);
			this.Menu = this.mainMenu1;
			this.Name = "formResults";
			this.Text = "hofstaedtler.config";
			this.panel1.ResumeLayout(false);
			this.groupServer2.ResumeLayout(false);
			this.groupServer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void menuFile_Quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private Source source1;
		private Source source2;
		private System.Collections.SortedList combined;

		private class CombinedModule
		{
			public Module m1;
			public Module m2;
		}

		private void menuFile_Open_Click(object sender, System.EventArgs e)
		{
			formSelectFiles fsf = new formSelectFiles();
			if (fsf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				source1 = new Source(fsf.File1);
				source2 = new Source(fsf.File2);
				combined = new SortedList();

				try 
				{
					source1.ReadData();
					source2.ReadData();
				} 
				catch (Exception ex)
				{
					formException fE = new formException();
					fE.setExceptionData(ex);
					fE.ShowDialog(this);
					source1 = null;
					source2 = null;
					return;
				} 

				{	// create the combined list
					CombinedModule cm;
					// copy over all modules from server1
					foreach(Module m in source1.Modules.Values)
					{
						cm = new CombinedModule();
						cm.m1 = m;
						combined.Add(m.Name, cm);
					}

					// copy over server2 data and add new modules
					foreach(Module m in source2.Modules.Values)
					{
						if (combined[m.Name] == null)
						{
							cm = new CombinedModule();
							combined.Add(m.Name, cm);
						} 
						else 
						{
							cm = (CombinedModule)combined[m.Name];
						}
						cm.m2 = m;
						combined[m.Name] = cm;
					}
				}

				// draw the lists out
				fillinList(chkEquals.Checked,chkMissing.Checked,chkConflicts.Checked);

				groupServer1.Text = source1.ServerName + " - " + source1.File.Substring(source1.File.LastIndexOf("\\")+1);
				groupServer2.Text = source2.ServerName + " - " + source2.File.Substring(source2.File.LastIndexOf("\\")+1);
			}
		}

		private void fillinList(bool displayEqual, bool displayMissing, bool displayConflicts)
		{
			this.listItems.Items.Clear();
			if (combined == null)
				return;
			
			foreach(CombinedModule cm in combined.Values)
			{
				String Name; String Description;
				Name = (cm.m1 != null) ? cm.m1.Name : cm.m2.Name;
				Description = (cm.m1 != null) ? cm.m1.Description : cm.m2.Description;

				String Ver1; String Ver2;
				Ver1 = (cm.m1 != null) ? cm.m1.Version : "";
				Ver2 = (cm.m2 != null) ? cm.m2.Version : "";

				String Desc1; String Desc2;
				Desc1 = (cm.m1 != null) ? cm.m1.Description : "";
				Desc2 = (cm.m2 != null) ? cm.m2.Description : "";

				String Date1; String Date2;
				Date1 = (cm.m1 != null) ? cm.m1.Date : "";
				Date2 = (cm.m2 != null) ? cm.m2.Date : "";

				if ((!displayEqual) && (Ver1 == Ver2) && (Desc1 == Desc2) && (Date1 == Date2))
					continue;

				if ((Ver1 != Ver2) || (Desc1 != Desc2) || (Date1 != Date2))
				{
					if ((Ver1 == "") || (Ver2 == ""))
					{
						if (!displayMissing)
							continue;
					}
					else
					{
						if (!displayConflicts)
							continue;
					}
				}

				ListViewItem item = this.listItems.Items.Add(Name);
				item.SubItems.Add(Ver1);
				item.SubItems.Add(Ver2);
				item.SubItems.Add(Description);

				if ((Ver1 != Ver2) || (Desc1 != Desc2) || (Date1 != Date2))
				{
					item.ForeColor = Color.Red;
					if ((Ver1 == "") || (Ver2 == ""))
					{
						item.ForeColor = Color.Brown;
					}
				}	
			}		
		}

		private void listItems_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (listItems.SelectedItems.Count == 0)
				return;
			if (combined == null)
				return;

			String Name = listItems.SelectedItems[0].Text;
			if (combined[Name] == null)
				return;
			CombinedModule cm = (CombinedModule)combined[Name];

			labelServer1Text.Text = "";
			labelServer2Text.Text = "";
			labelServer1Text.ForeColor = Color.Black;
			labelServer2Text.ForeColor = Color.Black;

			if (cm.m1 != null)
			{
				labelServer1Text.Text = cm.m1.Name + " " + cm.m1.Version + " " + cm.m1.Date + "\n" + cm.m1.Description + "\n";
				if (cm.m1.LoadCount>1)
					labelServer1Text.Text += "Load Count: " + cm.m1.LoadCount.ToString();
			}
			if (cm.m2 != null)
			{
				labelServer2Text.Text = cm.m2.Name + " " + cm.m2.Version + " " + cm.m2.Date + "\n" + cm.m2.Description + "\n";
				if (cm.m2.LoadCount>1)
					labelServer2Text.Text += "Load Count: " + cm.m2.LoadCount.ToString();
			}

			labelStatus.Text = "Gleich";
			if (labelServer1Text.Text != labelServer2Text.Text)
			{
				labelServer1Text.ForeColor = Color.Red;
				labelServer2Text.ForeColor = Color.Red;
				labelStatus.Text = "Ungleich";
				if ((cm.m1 == null) || (cm.m2 == null))
				{
					labelStatus.Text = "Fehlt";
					labelServer1Text.ForeColor = Color.Brown;
					labelServer2Text.ForeColor = Color.Brown;
				}
			}
		}

		private void menuHelp_Info_Click(object sender, System.EventArgs e)
		{
			formAbout fA = new formAbout();
			fA.Show();
		}

		private void chkMissing_CheckedChanged(object sender, System.EventArgs e)
		{
			fillinList(chkEquals.Checked,chkMissing.Checked,chkConflicts.Checked);
		}

		private void chkConflicts_CheckedChanged(object sender, System.EventArgs e)
		{
			fillinList(chkEquals.Checked,chkMissing.Checked,chkConflicts.Checked);
		}

		private void chkEquals_CheckedChanged(object sender, System.EventArgs e)
		{
			fillinList(chkEquals.Checked,chkMissing.Checked,chkConflicts.Checked);
		}

	}
}
