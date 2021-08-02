/*
 * Erstellt mit SharpDevelop.
 * Benutzer: franz.klose
 * Datum: 20.02.2017
 * Zeit: 11:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Cookie_Clicker_Beta
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.TbCookies = new System.Windows.Forms.TextBox();
			this.TbFaktor = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(418, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(418, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// TbCookies
			// 
			this.TbCookies.Location = new System.Drawing.Point(23, 61);
			this.TbCookies.Name = "TbCookies";
			this.TbCookies.Size = new System.Drawing.Size(100, 20);
			this.TbCookies.TabIndex = 2;
			// 
			// TbFaktor
			// 
			this.TbFaktor.Location = new System.Drawing.Point(141, 61);
			this.TbFaktor.Name = "TbFaktor";
			this.TbFaktor.Size = new System.Drawing.Size(100, 20);
			this.TbFaktor.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 412);
			this.Controls.Add(this.TbFaktor);
			this.Controls.Add(this.TbCookies);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox TbFaktor;
		private System.Windows.Forms.TextBox TbCookies;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
