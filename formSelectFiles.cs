using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class formSelectFiles : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtFile2;
		private System.Windows.Forms.TextBox txtFile1;
		private System.Windows.Forms.Button btnOpenF1;
		private System.Windows.Forms.Button btnOpenF2;
		private System.Windows.Forms.OpenFileDialog dlgFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public String File1 = "";
		public String File2 = "";

		public formSelectFiles()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.txtFile2 = new System.Windows.Forms.TextBox();
			this.txtFile1 = new System.Windows.Forms.TextBox();
			this.btnOpenF1 = new System.Windows.Forms.Button();
			this.btnOpenF2 = new System.Windows.Forms.Button();
			this.dlgFile = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFile2
			// 
			this.txtFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile2.Location = new System.Drawing.Point(136, 96);
			this.txtFile2.Name = "txtFile2";
			this.txtFile2.Size = new System.Drawing.Size(336, 20);
			this.txtFile2.TabIndex = 1;
			this.txtFile2.Text = "";
			// 
			// txtFile1
			// 
			this.txtFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFile1.Location = new System.Drawing.Point(136, 64);
			this.txtFile1.Name = "txtFile1";
			this.txtFile1.Size = new System.Drawing.Size(336, 20);
			this.txtFile1.TabIndex = 1;
			this.txtFile1.Text = "";
			// 
			// btnOpenF1
			// 
			this.btnOpenF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenF1.Location = new System.Drawing.Point(480, 64);
			this.btnOpenF1.Name = "btnOpenF1";
			this.btnOpenF1.Size = new System.Drawing.Size(80, 23);
			this.btnOpenF1.TabIndex = 3;
			this.btnOpenF1.Text = "Öffnen ...";
			this.btnOpenF1.Click += new System.EventHandler(this.btnOpenF1_Click);
			// 
			// btnOpenF2
			// 
			this.btnOpenF2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenF2.Location = new System.Drawing.Point(480, 96);
			this.btnOpenF2.Name = "btnOpenF2";
			this.btnOpenF2.Size = new System.Drawing.Size(80, 23);
			this.btnOpenF2.TabIndex = 4;
			this.btnOpenF2.Text = "Öffnen ...";
			this.btnOpenF2.Click += new System.EventHandler(this.btnOpenF2_Click);
			// 
			// dlgFile
			// 
			this.dlgFile.DefaultExt = "txt";
			this.dlgFile.Filter = "Config-Dateien|C*.txt|Alle Text-Dateien|*.txt|Alle Dateien|*.*";
			this.dlgFile.Title = "Datei öffnen...";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 64);
			this.label1.Name = "label1";
			this.label1.TabIndex = 5;
			this.label1.Text = "Server 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 96);
			this.label2.Name = "label2";
			this.label2.TabIndex = 6;
			this.label2.Text = "Server 2";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(480, 168);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(392, 168);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 24);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Abbrechen";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(472, 40);
			this.label3.TabIndex = 9;
			this.label3.Text = "Dateien auswählen ...";
			// 
			// formSelectFiles
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 205);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOpenF2);
			this.Controls.Add(this.btnOpenF1);
			this.Controls.Add(this.txtFile1);
			this.Controls.Add(this.txtFile2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formSelectFiles";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dateien auswählen";
			this.Load += new System.EventHandler(this.formSelectFiles_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOpenF1_Click(object sender, System.EventArgs e)
		{
			dlgFile.FileName = "";
			dlgFile.ShowDialog();
			if (dlgFile.FileName != "")
				txtFile1.Text = dlgFile.FileName;
		}

		private void btnOpenF2_Click(object sender, System.EventArgs e)
		{
			dlgFile.FileName = "";
			dlgFile.ShowDialog();
			if (dlgFile.FileName != "")
				txtFile2.Text = dlgFile.FileName;
		}

		private void formSelectFiles_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			File1 = txtFile1.Text;
			File2 = txtFile2.Text;
		}
	}
}
