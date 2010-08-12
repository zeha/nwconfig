using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Hofstaedtler.Config
{
	/// <summary>
	/// Zusammenfassung für formAbout.
	/// </summary>
	public class formAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblProgram;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.LinkLabel labelLink;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.PictureBox pictureIcon;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public formAbout()
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
			this.lblProgram = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelLink = new System.Windows.Forms.LinkLabel();
			this.labelVersion = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.pictureIcon = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// lblProgram
			// 
			this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblProgram.Location = new System.Drawing.Point(56, 16);
			this.lblProgram.Name = "lblProgram";
			this.lblProgram.Size = new System.Drawing.Size(368, 16);
			this.lblProgram.TabIndex = 0;
			this.lblProgram.Text = "hofstaedtler.config";
			// 
			// labelCopyright
			// 
			this.labelCopyright.Location = new System.Drawing.Point(16, 88);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(392, 23);
			this.labelCopyright.TabIndex = 1;
			this.labelCopyright.Text = "Copyright © 1999-2005, Christian Hofstaedtler";
			// 
			// labelLink
			// 
			this.labelLink.Location = new System.Drawing.Point(16, 112);
			this.labelLink.Name = "labelLink";
			this.labelLink.Size = new System.Drawing.Size(392, 23);
			this.labelLink.TabIndex = 2;
			this.labelLink.TabStop = true;
			this.labelLink.Text = "http://www.hofstaedtler.com/";
			this.labelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLink_LinkClicked);
			// 
			// labelVersion
			// 
			this.labelVersion.Location = new System.Drawing.Point(16, 64);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(376, 23);
			this.labelVersion.TabIndex = 3;
			this.labelVersion.Text = "Vx.y";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 3);
			this.label1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(344, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "A Reader for NetWare Configuration Reports";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(352, 152);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(72, 24);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pictureIcon
			// 
			this.pictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureIcon.Location = new System.Drawing.Point(16, 16);
			this.pictureIcon.Name = "pictureIcon";
			this.pictureIcon.Size = new System.Drawing.Size(32, 32);
			this.pictureIcon.TabIndex = 8;
			this.pictureIcon.TabStop = false;
			// 
			// formAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(434, 186);
			this.Controls.Add(this.pictureIcon);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelVersion);
			this.Controls.Add(this.labelLink);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.lblProgram);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "formAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Info ...";
			this.Load += new System.EventHandler(this.formAbout_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void formAbout_Load(object sender, System.EventArgs e)
		{
			System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
			labelVersion.Text = "Version " + a.GetName().Version.ToString();
		}

		private void labelLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(labelLink.Text);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
