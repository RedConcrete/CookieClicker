/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Franz
 * Datum: 11.10.2016
 * Zeit: 13:54
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Clicker
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ClickButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TbClick = new System.Windows.Forms.TextBox();
			this.Buy1 = new System.Windows.Forms.Button();
			this.Buy2 = new System.Windows.Forms.Button();
			this.Buy3 = new System.Windows.Forms.Button();
			this.Buy4 = new System.Windows.Forms.Button();
			this.Buy5 = new System.Windows.Forms.Button();
			this.Buy6 = new System.Windows.Forms.Button();
			this.U1 = new System.Windows.Forms.TextBox();
			this.U2 = new System.Windows.Forms.TextBox();
			this.U3 = new System.Windows.Forms.TextBox();
			this.U4 = new System.Windows.Forms.TextBox();
			this.U5 = new System.Windows.Forms.TextBox();
			this.U6 = new System.Windows.Forms.TextBox();
			this.U1timer = new System.Windows.Forms.Timer(this.components);
			this.U2timer = new System.Windows.Forms.Timer(this.components);
			this.U3timer = new System.Windows.Forms.Timer(this.components);
			this.U4timer = new System.Windows.Forms.Timer(this.components);
			this.U5timer = new System.Windows.Forms.Timer(this.components);
			this.U6timer = new System.Windows.Forms.Timer(this.components);
			this.CpS1 = new System.Windows.Forms.TextBox();
			this.CsP2 = new System.Windows.Forms.TextBox();
			this.cpps = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.cppps = new System.Windows.Forms.TextBox();
			this.cpppps = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.Cost1 = new System.Windows.Forms.TextBox();
			this.Cost2 = new System.Windows.Forms.TextBox();
			this.Cost3 = new System.Windows.Forms.TextBox();
			this.Cost4 = new System.Windows.Forms.TextBox();
			this.Cost5 = new System.Windows.Forms.TextBox();
			this.Cost6 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ClickButton
			// 
			this.ClickButton.BackColor = System.Drawing.Color.Transparent;
			this.ClickButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClickButton.ForeColor = System.Drawing.Color.Transparent;
			this.ClickButton.Image = ((System.Drawing.Image)(resources.GetObject("ClickButton.Image")));
			this.ClickButton.Location = new System.Drawing.Point(25, 111);
			this.ClickButton.Name = "ClickButton";
			this.ClickButton.Size = new System.Drawing.Size(280, 275);
			this.ClickButton.TabIndex = 7;
			this.ClickButton.UseVisualStyleBackColor = false;
			this.ClickButton.Click += new System.EventHandler(this.ClickClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(311, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Upgrade 1";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(311, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Upgrade 2";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(311, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Upgrade 3";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(311, 337);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Upgrade 4";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Window;
			this.label5.Location = new System.Drawing.Point(311, 364);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Upgrade 5";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Window;
			this.label6.Location = new System.Drawing.Point(311, 391);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Upgrade 6";
			// 
			// TbClick
			// 
			this.TbClick.Location = new System.Drawing.Point(47, 405);
			this.TbClick.Name = "TbClick";
			this.TbClick.ReadOnly = true;
			this.TbClick.Size = new System.Drawing.Size(233, 20);
			this.TbClick.TabIndex = 7;
			// 
			// Buy1
			// 
			this.Buy1.BackColor = System.Drawing.Color.DimGray;
			this.Buy1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy1.Location = new System.Drawing.Point(379, 251);
			this.Buy1.Name = "Buy1";
			this.Buy1.Size = new System.Drawing.Size(75, 23);
			this.Buy1.TabIndex = 8;
			this.Buy1.Text = "Buy";
			this.Buy1.UseVisualStyleBackColor = false;
			this.Buy1.Click += new System.EventHandler(this.Buy1Click);
			// 
			// Buy2
			// 
			this.Buy2.BackColor = System.Drawing.Color.Gray;
			this.Buy2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy2.Location = new System.Drawing.Point(379, 278);
			this.Buy2.Name = "Buy2";
			this.Buy2.Size = new System.Drawing.Size(75, 23);
			this.Buy2.TabIndex = 9;
			this.Buy2.Text = "Buy";
			this.Buy2.UseVisualStyleBackColor = false;
			this.Buy2.Click += new System.EventHandler(this.Buy2Click);
			// 
			// Buy3
			// 
			this.Buy3.BackColor = System.Drawing.Color.DarkGray;
			this.Buy3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy3.Location = new System.Drawing.Point(379, 305);
			this.Buy3.Name = "Buy3";
			this.Buy3.Size = new System.Drawing.Size(75, 23);
			this.Buy3.TabIndex = 10;
			this.Buy3.Text = "Buy";
			this.Buy3.UseVisualStyleBackColor = false;
			this.Buy3.Click += new System.EventHandler(this.Buy3Click);
			// 
			// Buy4
			// 
			this.Buy4.BackColor = System.Drawing.Color.Silver;
			this.Buy4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy4.Location = new System.Drawing.Point(379, 332);
			this.Buy4.Name = "Buy4";
			this.Buy4.Size = new System.Drawing.Size(75, 23);
			this.Buy4.TabIndex = 11;
			this.Buy4.Text = "Buy";
			this.Buy4.UseVisualStyleBackColor = false;
			this.Buy4.Click += new System.EventHandler(this.Buy4Click);
			// 
			// Buy5
			// 
			this.Buy5.BackColor = System.Drawing.Color.Gainsboro;
			this.Buy5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy5.Location = new System.Drawing.Point(379, 359);
			this.Buy5.Name = "Buy5";
			this.Buy5.Size = new System.Drawing.Size(75, 23);
			this.Buy5.TabIndex = 12;
			this.Buy5.Text = "Buy";
			this.Buy5.UseVisualStyleBackColor = false;
			this.Buy5.Click += new System.EventHandler(this.Buy5Click);
			// 
			// Buy6
			// 
			this.Buy6.BackColor = System.Drawing.Color.Gainsboro;
			this.Buy6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Buy6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Buy6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Buy6.Location = new System.Drawing.Point(379, 386);
			this.Buy6.Name = "Buy6";
			this.Buy6.Size = new System.Drawing.Size(75, 23);
			this.Buy6.TabIndex = 13;
			this.Buy6.Text = "Buy";
			this.Buy6.UseVisualStyleBackColor = false;
			// 
			// U1
			// 
			this.U1.BackColor = System.Drawing.SystemColors.Info;
			this.U1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U1.Cursor = System.Windows.Forms.Cursors.No;
			this.U1.Location = new System.Drawing.Point(460, 254);
			this.U1.Name = "U1";
			this.U1.ReadOnly = true;
			this.U1.Size = new System.Drawing.Size(100, 20);
			this.U1.TabIndex = 14;
			// 
			// U2
			// 
			this.U2.BackColor = System.Drawing.SystemColors.Info;
			this.U2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U2.Cursor = System.Windows.Forms.Cursors.No;
			this.U2.Location = new System.Drawing.Point(460, 281);
			this.U2.Name = "U2";
			this.U2.ReadOnly = true;
			this.U2.Size = new System.Drawing.Size(100, 20);
			this.U2.TabIndex = 15;
			// 
			// U3
			// 
			this.U3.BackColor = System.Drawing.SystemColors.Info;
			this.U3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U3.Cursor = System.Windows.Forms.Cursors.No;
			this.U3.Location = new System.Drawing.Point(460, 308);
			this.U3.Name = "U3";
			this.U3.ReadOnly = true;
			this.U3.Size = new System.Drawing.Size(100, 20);
			this.U3.TabIndex = 16;
			// 
			// U4
			// 
			this.U4.BackColor = System.Drawing.SystemColors.Info;
			this.U4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U4.Cursor = System.Windows.Forms.Cursors.No;
			this.U4.Location = new System.Drawing.Point(460, 335);
			this.U4.Name = "U4";
			this.U4.ReadOnly = true;
			this.U4.Size = new System.Drawing.Size(100, 20);
			this.U4.TabIndex = 17;
			// 
			// U5
			// 
			this.U5.BackColor = System.Drawing.SystemColors.Info;
			this.U5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U5.Cursor = System.Windows.Forms.Cursors.No;
			this.U5.Location = new System.Drawing.Point(460, 362);
			this.U5.Name = "U5";
			this.U5.ReadOnly = true;
			this.U5.Size = new System.Drawing.Size(100, 20);
			this.U5.TabIndex = 18;
			// 
			// U6
			// 
			this.U6.BackColor = System.Drawing.SystemColors.Info;
			this.U6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.U6.Cursor = System.Windows.Forms.Cursors.No;
			this.U6.Location = new System.Drawing.Point(460, 389);
			this.U6.Name = "U6";
			this.U6.ReadOnly = true;
			this.U6.Size = new System.Drawing.Size(100, 20);
			this.U6.TabIndex = 19;
			// 
			// U1timer
			// 
			this.U1timer.Interval = 2000;
			this.U1timer.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// U2timer
			// 
			this.U2timer.Tick += new System.EventHandler(this.U2timerTick);
			// 
			// U3timer
			// 
			this.U3timer.Tick += new System.EventHandler(this.U3timerTick);
			// 
			// U4timer
			// 
			this.U4timer.Tick += new System.EventHandler(this.U4timerTick);
			// 
			// U5timer
			// 
			this.U5timer.Tick += new System.EventHandler(this.U5timerTick);
			// 
			// CpS1
			// 
			this.CpS1.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.CpS1.Cursor = System.Windows.Forms.Cursors.No;
			this.CpS1.Location = new System.Drawing.Point(579, 254);
			this.CpS1.Name = "CpS1";
			this.CpS1.ReadOnly = true;
			this.CpS1.Size = new System.Drawing.Size(106, 20);
			this.CpS1.TabIndex = 20;
			// 
			// CsP2
			// 
			this.CsP2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.CsP2.Cursor = System.Windows.Forms.Cursors.No;
			this.CsP2.Location = new System.Drawing.Point(579, 280);
			this.CsP2.Name = "CsP2";
			this.CsP2.ReadOnly = true;
			this.CsP2.Size = new System.Drawing.Size(106, 20);
			this.CsP2.TabIndex = 21;
			// 
			// cpps
			// 
			this.cpps.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cpps.Cursor = System.Windows.Forms.Cursors.No;
			this.cpps.Location = new System.Drawing.Point(579, 308);
			this.cpps.Name = "cpps";
			this.cpps.ReadOnly = true;
			this.cpps.Size = new System.Drawing.Size(106, 20);
			this.cpps.TabIndex = 28;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Window;
			this.label12.Location = new System.Drawing.Point(705, 255);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Cost:";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Window;
			this.label11.Location = new System.Drawing.Point(705, 282);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 23);
			this.label11.TabIndex = 23;
			this.label11.Text = "Cost:";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Window;
			this.label10.Location = new System.Drawing.Point(705, 309);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "Cost: 100000";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.Window;
			this.label9.Location = new System.Drawing.Point(705, 336);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 23);
			this.label9.TabIndex = 25;
			this.label9.Text = "Cost:";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Window;
			this.label8.Location = new System.Drawing.Point(705, 363);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 23);
			this.label8.TabIndex = 26;
			this.label8.Text = "Cost:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Window;
			this.label7.Location = new System.Drawing.Point(705, 390);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 23);
			this.label7.TabIndex = 27;
			this.label7.Text = "Cost:";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(739, 440);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(118, 14);
			this.label13.TabIndex = 30;
			this.label13.Text = "Version : Alpha 0.4.4.1";
			// 
			// cppps
			// 
			this.cppps.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cppps.Cursor = System.Windows.Forms.Cursors.No;
			this.cppps.Location = new System.Drawing.Point(579, 335);
			this.cppps.Name = "cppps";
			this.cppps.ReadOnly = true;
			this.cppps.Size = new System.Drawing.Size(106, 20);
			this.cppps.TabIndex = 32;
			// 
			// cpppps
			// 
			this.cpppps.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cpppps.Cursor = System.Windows.Forms.Cursors.No;
			this.cpppps.Location = new System.Drawing.Point(579, 362);
			this.cpppps.Name = "cpppps";
			this.cpppps.ReadOnly = true;
			this.cpppps.Size = new System.Drawing.Size(106, 20);
			this.cpppps.TabIndex = 33;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.textBox5.Cursor = System.Windows.Forms.Cursors.No;
			this.textBox5.Location = new System.Drawing.Point(579, 389);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(106, 20);
			this.textBox5.TabIndex = 34;
			// 
			// Cost1
			// 
			this.Cost1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost1.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost1.Location = new System.Drawing.Point(742, 252);
			this.Cost1.Name = "Cost1";
			this.Cost1.ReadOnly = true;
			this.Cost1.Size = new System.Drawing.Size(106, 20);
			this.Cost1.TabIndex = 35;
			// 
			// Cost2
			// 
			this.Cost2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost2.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost2.Location = new System.Drawing.Point(742, 279);
			this.Cost2.Name = "Cost2";
			this.Cost2.ReadOnly = true;
			this.Cost2.Size = new System.Drawing.Size(106, 20);
			this.Cost2.TabIndex = 36;
			// 
			// Cost3
			// 
			this.Cost3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost3.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost3.Location = new System.Drawing.Point(742, 307);
			this.Cost3.Name = "Cost3";
			this.Cost3.ReadOnly = true;
			this.Cost3.Size = new System.Drawing.Size(106, 20);
			this.Cost3.TabIndex = 37;
			// 
			// Cost4
			// 
			this.Cost4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost4.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost4.Location = new System.Drawing.Point(742, 333);
			this.Cost4.Name = "Cost4";
			this.Cost4.ReadOnly = true;
			this.Cost4.Size = new System.Drawing.Size(106, 20);
			this.Cost4.TabIndex = 38;
			// 
			// Cost5
			// 
			this.Cost5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost5.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost5.Location = new System.Drawing.Point(742, 360);
			this.Cost5.Name = "Cost5";
			this.Cost5.ReadOnly = true;
			this.Cost5.Size = new System.Drawing.Size(106, 20);
			this.Cost5.TabIndex = 39;
			// 
			// Cost6
			// 
			this.Cost6.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Cost6.Cursor = System.Windows.Forms.Cursors.No;
			this.Cost6.Location = new System.Drawing.Point(742, 387);
			this.Cost6.Name = "Cost6";
			this.Cost6.ReadOnly = true;
			this.Cost6.Size = new System.Drawing.Size(106, 20);
			this.Cost6.TabIndex = 40;
			// 
			// MainForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(869, 463);
			this.Controls.Add(this.ClickButton);
			this.Controls.Add(this.Cost6);
			this.Controls.Add(this.Cost5);
			this.Controls.Add(this.Cost4);
			this.Controls.Add(this.Cost3);
			this.Controls.Add(this.Cost2);
			this.Controls.Add(this.Cost1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.cpppps);
			this.Controls.Add(this.cppps);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cpps);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.CsP2);
			this.Controls.Add(this.CpS1);
			this.Controls.Add(this.U6);
			this.Controls.Add(this.U5);
			this.Controls.Add(this.U4);
			this.Controls.Add(this.U3);
			this.Controls.Add(this.U2);
			this.Controls.Add(this.U1);
			this.Controls.Add(this.Buy6);
			this.Controls.Add(this.Buy5);
			this.Controls.Add(this.Buy4);
			this.Controls.Add(this.Buy3);
			this.Controls.Add(this.Buy2);
			this.Controls.Add(this.Buy1);
			this.Controls.Add(this.TbClick);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Clicker";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox Cost6;
		private System.Windows.Forms.TextBox Cost5;
		private System.Windows.Forms.TextBox Cost4;
		private System.Windows.Forms.TextBox Cost3;
		private System.Windows.Forms.TextBox Cost2;
		private System.Windows.Forms.TextBox Cost1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox cpppps;
		private System.Windows.Forms.TextBox cppps;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox cpps;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox CsP2;
		private System.Windows.Forms.TextBox CpS1;
		private System.Windows.Forms.Timer U6timer;
		private System.Windows.Forms.Timer U5timer;
		private System.Windows.Forms.Timer U4timer;
		private System.Windows.Forms.Timer U3timer;
		private System.Windows.Forms.Timer U2timer;
		private System.Windows.Forms.Timer U1timer;
		private System.Windows.Forms.TextBox U6;
		private System.Windows.Forms.TextBox U5;
		private System.Windows.Forms.TextBox U4;
		private System.Windows.Forms.TextBox U3;
		private System.Windows.Forms.TextBox U2;
		private System.Windows.Forms.TextBox U1;
		private System.Windows.Forms.Button Buy6;
		private System.Windows.Forms.Button Buy5;
		private System.Windows.Forms.Button Buy4;
		private System.Windows.Forms.Button Buy3;
		private System.Windows.Forms.Button Buy2;
		private System.Windows.Forms.Button Buy1;
		private System.Windows.Forms.TextBox TbClick;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClickButton;
		
	
		
	}
}
