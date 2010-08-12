using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für formException.
	/// </summary>
	public class formException : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox exceptionText;
		private System.Windows.Forms.Button btnOK;

		private Exception myException;
		private System.Windows.Forms.Button btnClipboard;

		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formException()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
		}

		// make up an exception string
		private String makeExceptionString(System.Exception e, String template)
		{
			// prefill with template
			String msg = template;

			// message?
			if (e.Message != null)
				msg = msg.Replace("%exception%",e.GetType().ToString() + ": " + e.Message);
			else
				msg = msg.Replace("%exception%","-no data-");

			// stacktrace
			if (e.StackTrace != null)
				msg = msg.Replace("%stacktrace%",e.StackTrace.Replace("\\","/").Replace("\n"," \\par\n"));
			else
				msg = msg.Replace("%stacktrace%","-no data-");

			// if we have an inner exception, include it too in the output string...
			if (e.InnerException != null)
				msg += makeExceptionString(e.InnerException, template);

			return msg;
		}

		public void setExceptionData(System.Exception e)
		{
			myException = e;
			if (myException != null)
			{
				// build exception rtf string

				// get executing assembly
				System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
				
				// exception text, prefill with rtf header
				String exT = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3079{\\fonttbl{\\f0\\fswiss\\fcharset0 Arial;}}\n{\\colortbl ;\\red128\\green0\\blue0;}\n";

				// exception template
				String exT_template = "\\viewkind4\\uc1\\pard\\cf1\\b\\f0\\fs24 Occoured Exception: %exception% \\fs20\\par\n\\cf0\\b0\\par\n" + 
					"Stack Trace: \\par\n%stacktrace%\n\\par\\par\n";

				exT += makeExceptionString(myException, exT_template);

				// add assembly version number
				exT = exT + "hofstaedtler.config Version: " + a.GetName().Version.ToString() + "\n\\par\n}";
				exceptionText.Rtf = exT;
			}
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
			this.exceptionText = new System.Windows.Forms.RichTextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClipboard = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// exceptionText
			// 
			this.exceptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.exceptionText.Location = new System.Drawing.Point(8, 8);
			this.exceptionText.Name = "exceptionText";
			this.exceptionText.Size = new System.Drawing.Size(480, 248);
			this.exceptionText.TabIndex = 0;
			this.exceptionText.Text = "-";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(272, 264);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			// 
			// btnClipboard
			// 
			this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClipboard.Location = new System.Drawing.Point(352, 264);
			this.btnClipboard.Name = "btnClipboard";
			this.btnClipboard.Size = new System.Drawing.Size(136, 23);
			this.btnClipboard.TabIndex = 4;
			this.btnClipboard.Text = "Copy to clipboard";
			this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
			// 
			// formException
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 293);
			this.Controls.Add(this.btnClipboard);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.exceptionText);
			this.Name = "formException";
			this.Text = "hofstaedtler.config Exception Information Dialog";
			this.Load += new System.EventHandler(this.formException_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void formException_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnClipboard_Click(object sender, System.EventArgs e)
		{
			exceptionText.SelectAll();
			exceptionText.Copy();
			exceptionText.Select(0,0);
		}
	}
}
